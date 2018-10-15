using Common;
using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginShell
{
    public partial class MainShell : Form
    {

        PluginService<IPlugin> pluginService;

        public MainShell()
        {
            InitializeComponent();
        }

        private void MainShell_Load(object sender, EventArgs e)
        {
            var pluginsFolderPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Plugins");
            pluginService = new PluginService<IPlugin>(pluginsFolderPath, "*.dll", true);
            pluginService.PluginsAdded += pluginService_PluginAdded;
            pluginService.PluginsChanged += pluginService_PluginChanged;
            pluginService.PluginsRemoved += pluginService_PluginRemoved;


            pluginService.Start();
        }

        private void MainShell_FormClosing(object sender, FormClosingEventArgs e)
        {
            pluginService.Stop();
        }

        #region Event handlers

        private static void pluginService_PluginRemoved(PluginService<IPlugin> sender, List<IPlugin> plugins)
        {
            foreach (var plugin in plugins)
            {
                Console.WriteLine("PluginRemoved: {0}.", plugin.Name);
                plugin.Dispose();
            }
        }

        private static void pluginService_PluginChanged(PluginService<IPlugin> sender, List<IPlugin> oldPlugins, List<IPlugin> newPlugins)
        {
            Console.WriteLine("PluginChanged: {0} plugins -> {1} plugins.", oldPlugins.Count, newPlugins.Count);
            foreach (var plugin in oldPlugins)
            {
                Console.WriteLine("~removed: {0}.", plugin.Name);
                plugin.Dispose();
            }
            foreach (var plugin in newPlugins)
            {
                Console.WriteLine("~added: {0}.", plugin.Name);
            }
        }

        private static void pluginService_PluginAdded(PluginService<IPlugin> sender, List<IPlugin> plugins)
        {
            foreach (var plugin in plugins)
            {
                Console.WriteLine("PluginAdded: {0}.", plugin.Name);
                //Console.WriteLine(plugin.SayHelloTo("Tony Stark"));
            }
        }

        #endregion

    }
}
