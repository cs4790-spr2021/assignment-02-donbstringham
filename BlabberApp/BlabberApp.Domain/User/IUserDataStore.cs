namespace BlabberApp.Domain
{
    public interface IUserEntityDataStore : IUserEntityReadWrite {
        bool Create(UserEntity usr);
    }
}