using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    class FileService : IFileService
    {
        private static readonly Lazy<FileService> instance = new Lazy<FileService>(() => new FileService());

        private FileService()
        {

        }

        /// <summary>
        /// Returns instance of FileService.
        /// </summary>
        /// <returns></returns>
        public static FileService GetInstance()
        {
            return instance.Value;
        }

        /// <summary>
        /// Deletes the file by the specified path.
        /// </summary>
        /// <param name="path">Source path</param>
        public void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                throw new FileNotFoundException("File not found! Make sure the data is entered correctly!");
            }
        }

        /// <summary>
        /// Moves the file to the specified location.
        /// </summary>
        /// <param name="path">Source path</param>
        /// <param name="newPath">New source path</param>
        public void Move(string path, string newPath)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Check the correct data entry!");
            }
            if (!Directory.Exists(newPath))
            {
                throw new DirectoryNotFoundException("Check the correct data entry!");
            }
            File.Move(path, newPath);
        }

        /// <summary>
        ///  Reads the file by the specified path.
        /// </summary>
        /// <param name="path">Source path</param>
        /// <returns>Returns the read text</returns>
        public string Read(string path)
        {
            var file = new FileInfo(path);
            if (file.Exists && string.Equals(file.Extension, "txt", StringComparison.Ordinal))
            {
                return File.ReadAllText(path);
            }
            else
            {
                throw new FileNotFoundException("File not found! Make sure the data is entered correctly!");
            }
        }

        /// <summary>
        /// Saves the file by the specified path.
        /// </summary>
        /// <param name="path">Source path</param>
        /// <param name="save">New source path</param>
        public void Save(string path, string save)
        {
            var file = new FileInfo(path);
            file.CopyTo(save);
        }
    }
}
