using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class UserOrderRepos : Repo, IRepo<UserOder , int , UserOder>
    {
        public UserOder Create(UserOder obj)
        {
            db.UserOder.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.UserOder.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<UserOder> Read()
        {
            return db.UserOder.ToList();
        }

        public UserOder Read(int id)
        {
            return db.UserOder.Find(id);
        }

        public UserOder Update(UserOder obj)
        {
            var ex = Read(obj.UserOrderID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
