using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {
        List<Address> GetAll();
        Address GetById(int id);
        void Add(Address address);
        void Update(Address address);
        void Delete(int id);
    }
}
