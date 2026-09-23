using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HizmetlerManager : IHizmetlerService
    {
        IHizmetlerDAL _hizmetlerDAL;

        public HizmetlerManager(IHizmetlerDAL hizmetlerDAL)
        {
            _hizmetlerDAL = hizmetlerDAL;
        }

        public void TAdd(Hizmetler t)
        {
            _hizmetlerDAL.Insert(t);
        }

        public void TDelete(Hizmetler t)
        {
            _hizmetlerDAL.Delete(t);
        }

        public Hizmetler TGetByID(int id)
        {
            return _hizmetlerDAL.GetByID(id);
        }

        public List<Hizmetler> TGetList()
        {
            return _hizmetlerDAL.GetList();
        }

        public void TUpdate(Hizmetler t)
        {
            _hizmetlerDAL.Update(t);
        }
    }
}
