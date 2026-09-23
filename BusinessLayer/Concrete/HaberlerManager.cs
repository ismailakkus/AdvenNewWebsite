using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HaberlerManager : IHaberlerService
    {
        IHaberlerDAL _haberlerDAL;

        public HaberlerManager(IHaberlerDAL haberlerDAL)
        {
            _haberlerDAL = haberlerDAL;
        }

        public void TAdd(Haberler t)
        {
            _haberlerDAL.Insert(t);
        }

        public void TDelete(Haberler t)
        {
            _haberlerDAL.Delete(t);
        }

        public Haberler TGetByID(int id)
        {
            return _haberlerDAL.GetByID(id);
        }

        public List<Haberler> TGetList()
        {
            return _haberlerDAL.GetList();
        }

        public void TUpdate(Haberler t)
        {
            _haberlerDAL.Update(t);
        }
    }
}
