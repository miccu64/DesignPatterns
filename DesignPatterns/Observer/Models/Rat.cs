using System;

namespace DesignPatterns.Observer.Models
{
    public class Rat : IDisposable
    {
        public int Attack { get; private set; } = 1;
        private readonly Game _game;

        public Rat(Game game)
        {
            _game = game;

            _game.RegisterRat(this);
        }

        public void OnRatsCountChanged(int ratsCount)
        {
            Attack = ratsCount;
        }

        public void Dispose()
        {
            _game.UnregisterRat(this);
        }
    }
}
