namespace Actio.Common.Events
{
    public class ActivitiyCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; }

        public Guid Id { get;  }

        public string Category { get; }
        public string Name { get; }
        public string Description { get;  }

        public DateTime CreatedAt { get;  }

        protected ActivitiyCreated()
        {
                
        }
        public ActivitiyCreated(Guid id,Guid userId,string category,string name,string description,DateTime createAt)
        {
            Id = id;
            UserId = userId;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createAt;
        }
    }
}
