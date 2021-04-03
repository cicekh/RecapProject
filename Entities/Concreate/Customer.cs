using Core.Entities;

namespace Entities.Concreate
{
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
