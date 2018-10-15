using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing;
using System.Windows.Forms;

namespace Contracts
{
    public interface IPlugin : IDisposable
    {
        string Name { get; }
        Image Logo { get; }

        void InfoWindow(Panel pnlInfo);
        void MainWindow(Panel pnlMain);

    }
}
