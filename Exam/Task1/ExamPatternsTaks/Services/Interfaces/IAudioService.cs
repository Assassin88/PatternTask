using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAudioService
    {
        void Play(string path);
        void Stop();
        AudioInfo GetInformarion(string path);
    }
}
