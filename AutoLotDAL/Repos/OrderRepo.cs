using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos
{
    class OrderRepo : BaseRepo<Order>, IRepo<Order>
    {
        public int Delete(int id)
        {
            Context.Entry(new Order() { CarId = id }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id)
        {
            Context.Entry(new Order() { CarId = id }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
    }
}
