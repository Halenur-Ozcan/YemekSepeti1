using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public List<Address> GetAll()
        {
            return _addressDal.GetList();
        }

        public Address GetById(int id)
        {
            return _addressDal.Get(a => a.Id == id);
        }

        public void Add(Address address)
        {
            _addressDal.Add(address);
        }

        public void Update(Address address)
        {
            _addressDal.Update(address);
        }

        public void Delete(int id)
        {
            var address = _addressDal.Get(a => a.Id == id);
            _addressDal.Delete(address);
        }
    }
}
