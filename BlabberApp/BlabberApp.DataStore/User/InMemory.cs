using System;
using System.Collections.Generic;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory: IUserEntityDataStore
    {
        private List<UserEntity> _users;

        public InMemory()
        {
            _users = new List<UserEntity>();
        }

        public InMemory(UserEntity[] users)
        {
            _users = new List<UserEntity>();
            _users.AddRange(users);
        }

        public bool Create(UserEntity userEntity)
        {
            _users.Add(userEntity);
            return true;
        }
        public bool Delete(UserEntity userEntity){return true;}
        public bool DeleteByID(string ID){return true;}
        public bool DeleteByName(string name){return true;}
        public bool Update(UserEntity userEntity){return true;}
        public bool UpdateByID(string ID){return true;}
        public bool UpdateByName(string name){return true;}
        public bool Write(UserEntity userEntity)
        {
            throw new NotImplementedException("Not Implemented for this class");
        }
        public List<UserEntity> ReadAll()
        {
            return _users;
        }
        public UserEntity ReadByID(string ID){return new UserEntity();}
        public UserEntity ReadByName(string name){return new UserEntity();}
        public UserEntity ReadByUsername(string userName){return new UserEntity();}
        public int Count()
        {
            return _users.Count;
        }
    }
}
