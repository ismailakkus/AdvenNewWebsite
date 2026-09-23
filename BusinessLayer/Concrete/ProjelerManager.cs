using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjelerManager : IProjelerService
    {  
        IProjelerDAL _projelerDAL;

        public ProjelerManager(IProjelerDAL projelerDAL)
        {
            _projelerDAL = projelerDAL;
        }

        public void TAdd(Projeler t)
        {
            _projelerDAL.Insert(t);
        }

        public void TDelete(Projeler t)
        {
            _projelerDAL.Delete(t);
        }

        public Projeler TGetByID(int id)
        {
            return _projelerDAL.GetByID(id);
        }

        public List<Projeler> TGetList()
        {
            return _projelerDAL.GetList();
        }

        public List<Projeler> TGetListWithTake1Random()
        {
            return _projelerDAL.GetList().Take(1).ToList();
        }

        public void TUpdate(Projeler t)
        {
            _projelerDAL.Update(t);
        }
    }
}
