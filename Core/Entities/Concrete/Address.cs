using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
