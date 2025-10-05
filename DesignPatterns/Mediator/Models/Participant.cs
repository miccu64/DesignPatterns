namespace DesignPatterns.Mediator.Models
{
    public class Participant
    {
        private readonly ParticipantMediator _mediator;

        public int Value { get; private set; } = 0;

        public Participant(ParticipantMediator mediator)
        {
            _mediator = mediator;
            _mediator.Register(this);
        }

        public void Say(int n)
        {
            _mediator.Say(this, n);
        }

        public void Listen(int n)
        {
            Value += n;
        }
    }
}
