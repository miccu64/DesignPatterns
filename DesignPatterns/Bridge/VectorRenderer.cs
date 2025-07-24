using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "lines";
    }
}
