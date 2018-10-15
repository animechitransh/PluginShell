using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public interface IService
    {
        bool IsRunning { get; }
        void Start();
        void Stop();
    }
}
