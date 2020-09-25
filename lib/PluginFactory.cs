using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    class PluginFactory : Factory,IPluginFactory
    {
        public override IPlugin GetPlugin(string pluginName)
        {
            return this.list_plugin.Find(x => x.PluginName == pluginName);
        }
    }
}
