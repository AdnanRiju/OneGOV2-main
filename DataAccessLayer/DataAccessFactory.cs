using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<Products, string, Products> ProductData()
        {
            return new ProductsRepo();
        }
        public static IRepo<Orders, int, Orders> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Categories, int, Categories> CategoriesData()
        {
            return new CategoriesRepo();
        }
        public static IRepo<UserOder, int, UserOder> UserOrderData()
        {
            return new UserOrderRepos();
        }

    }
}
