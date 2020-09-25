using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lib
{
    abstract class Factory : IPluginFactory
    {
        protected List<IPlugin> list_plugin;
        public  int PluginCount { get => list_plugin.Count; }
        public  string[] GetPluginName { get => list_plugin.Select(x => x.PluginName).ToArray(); }

        public abstract IPlugin GetPlugin(string pluginName);
        public Factory()
        {
            this.list_plugin = new List<IPlugin>();
        }
    }
}
