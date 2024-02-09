using DisApi.BusinessLayer.Abstract;
using DisApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisApi.DataAccessLayer.Abstract;

namespace DisApi.BusinessLayer.Concrete
{
    public class ToothManager : IToothService
    {
        private readonly IToothDal _toothDal;

        public ToothManager(IToothDal toothDal)
        {
            _toothDal = toothDal;
        }

        public void TDelete(Tooth t)
        {
           _toothDal.Delete(t);
        }

        public Tooth TGetByID(int id)
        {
            return _toothDal.GetByID(id);
        }

        public List<Tooth> TGetList()
        {
           return _toothDal.GetList();
        }

        public void TInsert(Tooth t)
        {
            _toothDal.Insert(t);
        }

        public void TUpdate(Tooth t)
        {
            _toothDal.Update(t);
        }
    }
}
