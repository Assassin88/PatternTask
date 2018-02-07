using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceFactory
    {
        public static IAudioService GetAudioService()
        {
            return AudioService.GetInstance();
        }

        public static IFileService GetFileService()
        {
            return FileService.GetInstance();
        }

        public static IMessageBoxService GetMessageBoxService()
        {
            return MessageBoxService.GetInstance();
        }
    }
}
