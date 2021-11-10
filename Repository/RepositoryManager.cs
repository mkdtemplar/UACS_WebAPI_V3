using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IStudentRepository _studentRepository;
        private IAddressRepository _addressRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IStudentRepository Student
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(_repositoryContext);
                }

                return _studentRepository;
            }
        }

        public IAddressRepository Address
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_repositoryContext);
                }

                return _addressRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}