using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Models
{
    public abstract class Shape
    {
        public string Name { get; set; }

        private readonly IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public override string ToString()
        {
            return $"Drawing {Name} as {_renderer.WhatToRenderAs}";
        }
    }
}
