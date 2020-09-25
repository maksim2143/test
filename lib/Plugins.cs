using lib;
using System;
using System.Runtime.CompilerServices;

namespace ds.test.impl
{
    public static class Plugins 
    {
        public static int PluginCount => plugin.PluginCount;

        public static string[] GetPluginName => plugin.GetPluginName;

        public static IPlugin GetPlugin(string pluginName)
        {
            return plugin.GetPlugin(pluginName);
        }
        private static PluginFactory plugin;
        private static void Create()
        {
           if (plugin == null) plugin = new PluginFactory();
        }
        static Plugins()
        {
            Create();
        }
    }
}
