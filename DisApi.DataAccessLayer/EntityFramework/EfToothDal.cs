using DisApi.DataAccessLayer.Abstract;
using DisApi.DataAccessLayer.Concrete;
using DisApi.DataAccessLayer.Repositories;
using DisApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisApi.DataAccessLayer.EntityFramework
{
    public class EfToothDal : GenericRepository<Tooth>, IToothDal
    {
        public EfToothDal(Context _context) : base(_context)
        {
        }
    }
}
