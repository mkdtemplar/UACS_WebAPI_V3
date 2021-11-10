using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Address> GetAddresses(int studentId, bool trackChanges) =>
            FindByCondition(a => a.StudentId.Equals(studentId), trackChanges);

        public Address GetAddress(int studentId, int addressId, bool trackChanges) =>
            FindByCondition(a => a.StudentId.Equals(studentId) && a.AddressId.Equals(addressId), trackChanges).SingleOrDefault();

        public void CreateAddressForStudent(int studentId, Address address)
        {
            address.StudentId = studentId;
            Create(address);
        }

        public void DeleteAddress(Address address)
        {
            Delete(address);
        }
    }
}