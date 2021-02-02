using System;
using System.Collections;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory: IUserEntityDataStore
    {
        public InMemory() {}
        public InMemory(ICollection c) {}
        public bool Create(UserEntity userEntity){return true;}
        public bool Delete(UserEntity userEntity){return true;}
        public bool DeleteByID(string ID){return true;}
        public bool DeleteByName(string name){return true;}
        public bool Update(UserEntity userEntity){return true;}
        public bool UpdateByID(string ID){return true;}
        public bool UpdateByName(string name){return true;}
        public bool Write(UserEntity userEntity){return true;}
        public UserEntity ReadByID(string ID){return new UserEntity();}
        public UserEntity ReadByName(string name){return new UserEntity();}
        public UserEntity ReadByUsername(string userName){return new UserEntity();}
    }
}
