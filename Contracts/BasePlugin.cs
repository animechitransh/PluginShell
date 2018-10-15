using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Contracts
{
    public abstract class BasePlugin : MarshalByRefObject, IPlugin
    {
        public string Name { get; private set; }
        public Image Logo { get; private set; }

        public BasePlugin(string name,Image logo = null)
        {
            Name = name;
            Logo = logo;
        }

        public abstract string SayHelloTo(string personName);
        public abstract void InfoWindow(Panel pnlInfo);
        public abstract void MainWindow(Panel pnlMain);

        public virtual void Dispose()
        {
            //TODO:
        }
    }
}
