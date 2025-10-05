using DesignPatterns.Mediator.Models;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class ParticipantMediator
    {
        private readonly List<Participant> _participants = new List<Participant>();

        public void Register(Participant participant)
        {
            _participants.Add(participant);
        }

        public void Say(Participant participant, int n)
        {
            foreach (Participant p in _participants)
            {
                if (p != participant)
                    p.Listen(n);
            }
        }
    }
}
