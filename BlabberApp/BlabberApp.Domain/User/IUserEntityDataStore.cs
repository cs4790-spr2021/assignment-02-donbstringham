namespace BlabberApp.Domain
{
    public interface IUserEntityDataStore
    {
        void Create(UserEntity usr);
        UserEntity Read(string username);
        void Update(UserEntity user);
        void Delete(string username);
    }
}