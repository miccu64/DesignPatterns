using DesignPatterns.Observer.Models;
using System;

namespace DesignPatterns.Observer
{
    public class Game
    {
        private Action<int> _ratsCountChanged;

        public void RegisterRat(Rat rat)
        {
            _ratsCountChanged += rat.OnRatsCountChanged;

            NotifyRats();
        }

        public void UnregisterRat(Rat rat)
        {
            _ratsCountChanged -= rat.OnRatsCountChanged;

            NotifyRats();
        }

        private void NotifyRats()
        {
            int ratsCount = _ratsCountChanged?.GetInvocationList()?.Length ?? 0;
            _ratsCountChanged?.Invoke(ratsCount);
        }
    }
}
