using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Open_newApp
{
    public interface IAppHandler
    {
        Task<bool> LaunchApp(string packageName);
        void OpenExternalApp(string text);
    }
}
