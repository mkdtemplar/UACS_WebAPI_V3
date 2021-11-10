namespace Contracts
{
    public interface IRepositoryManager
    {
        IStudentRepository Student {get;}
        IAddressRepository Address {get;}
        void Save();
    }
}