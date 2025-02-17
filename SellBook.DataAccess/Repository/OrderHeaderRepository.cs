using SellBook.DataAccess.Data;
using SellBook.DataAccess.Repository.IRepository;
using SellBook.Models;
using SellBook.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBook.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private AppDbContext _db;
        public OrderHeaderRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
