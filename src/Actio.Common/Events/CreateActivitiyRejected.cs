namespace Actio.Common.Events
{
    public class CreateActivitiyRejected : IRejectedEvent
    {
        public Guid Id { get; }
        public string Reason { get; }

        public string Code { get; }

        protected CreateActivitiyRejected()
        {

        }

        public CreateActivitiyRejected(Guid id, string reason, string code)
        {

            Id = id;
            Reason = reason;
            Code = code;
        }
    }
}
