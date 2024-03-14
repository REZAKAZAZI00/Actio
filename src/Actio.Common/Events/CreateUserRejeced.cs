namespace Actio.Common.Events
{
    public class CreateUserRejeced : IRejectedEvent
    {
        public string Email { get; set; }
        public string Reason { get; }
        public string Code { get; }

        protected CreateUserRejeced()
        {

        }

        public CreateUserRejeced(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }


    }
}
