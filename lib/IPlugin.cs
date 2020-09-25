using System;
using System.Drawing;
using lib;

namespace System.Drawing
{
    public class Image
    {

    }
}
namespace ds.test.impl
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        System.Drawing.Image image { get; }
        string Description { set; get; }
        int Run(int input1, int input2);
    }
}
