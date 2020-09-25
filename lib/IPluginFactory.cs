using ds.test.impl;
using System;

namespace lib
{
    interface IPluginFactory
    {
        int PluginCount { get; }
        string[] GetPluginName {  get; }
        IPlugin GetPlugin(string pluginName);
    }
}
