using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAddresses(int studentId, bool trackChanges);

        Address GetAddress(int studentId, int id, bool trackChanges);

        void CreateAddressForStudent(int studentId, Address address);

        void DeleteAddress(Address address);
    }
}