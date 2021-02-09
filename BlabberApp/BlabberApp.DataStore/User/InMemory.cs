using System;
using System.Collections.Generic;
using BlabberApp.Domain;

namespace BlabberApp.DataStore
{
    public class InMemory : IUserEntityDataStore, IUserEntity
    {
        private List<UserEntity> Users;

        public InMemory()
        {
            Users = new List<UserEntity>();
        }

        public InMemory(UserEntity[] users)
        {
            Users = new List<UserEntity>();
            Users.AddRange(users);
        }

        public void Add(UserEntity user)
        {
            Create(user);
        }

        public int Count()
        {
            return Users.Count;
        }
        public void Create(UserEntity userEntity)
        {
            Users.Add(userEntity);
        }

        public void Delete(string username)
        {
            Users.RemoveAt(FindIndex(username));
        }

        public UserEntity Find(string username)
        {
            return Read(username);
        }

        public UserEntity Read(string username)
        {
            return Users[FindIndex(username)];
        }

        public void Remove(string username)
        {
            Delete(username);
        }

        public void Update(UserEntity user)
        {
            Users[FindIndex(user.GetId())] = user;
        }

        private int FindIndex(string username)
        {
            return Users.FindIndex((UserEntity u) => username.Equals(u.GetId()) == true);
        }
    }
}
