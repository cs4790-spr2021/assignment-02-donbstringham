namespace BlabberApp.Domain
{
    public interface IUserEntityReadWrite : IUserEntityRead, IUserEntityWrite {
        bool Delete(UserEntity usr);
        bool DeleteByID(string ID);
        bool DeleteByName(string name);
        bool Update(UserEntity usr);
    }
}