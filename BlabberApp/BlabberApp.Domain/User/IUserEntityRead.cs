namespace BlabberApp.Domain
{
    public interface IUserEntityRead {
        UserEntity ReadByID(string ID);
        UserEntity ReadByUsername(string Username);
        UserEntity ReadByName(string Name);
    }
}