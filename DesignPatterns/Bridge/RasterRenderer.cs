using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }
}
