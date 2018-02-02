using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using NAudio.Wave; 
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Services.Services
{
    class AudioService : IAudioService
    {
        private static readonly Lazy<AudioService> instance = new Lazy<AudioService>(() => new AudioService());

        private readonly WaveOut _nAudio;

        private AudioService()
        {
            _nAudio = new WaveOut();
        }

        /// <summary>
        /// Returns instance of AudioService.
        /// </summary>
        /// <returns></returns>
        public static AudioService GetInstance()
        {
            return instance.Value;
        }

        /// <summary>
        /// Plays file by sourse path.
        /// </summary>
        /// <param name="path">Source path</param>
        public void Play(string path)
        {
            _nAudio.Init(new Mp3FileReader(path));
            _nAudio.Play();
        }

        /// <summary>
        /// Stops file by sourse path.
        /// </summary>
        public void Stop()
        {
            _nAudio.Stop();
        }

        /// <summary>
        /// Returns information about file by sourse path.
        /// </summary>
        /// <param name="path">Source path</param>
        /// <returns></returns>
        public AudioInfo GetInformarion(string path)
        {
            var fileInfo = new FileInfo(path);
            var instance = new AudioInfo()
            {
                Name = fileInfo.Name,
                Extension = fileInfo.Extension,
                Size = fileInfo.Length,
                Directory = fileInfo.DirectoryName
            };
            return instance;
        }
    }
}
