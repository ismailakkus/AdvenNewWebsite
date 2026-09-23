using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SureclerManager : ISureclerService
    {
        ISureclerDAL _sureclerDAL;

        public SureclerManager(ISureclerDAL sureclerDAL)
        {
            _sureclerDAL = sureclerDAL;
        }

        public void TAdd(Surecler t)
        {
            _sureclerDAL.Insert(t);
        }

        public void TDelete(Surecler t)
        {
            _sureclerDAL.Delete(t);
        }

        public Surecler TGetByID(int id)
        {
            return _sureclerDAL.GetByID(id);
        }

        public List<Surecler> TGetList()
        {
            return _sureclerDAL.GetList();
        }

        public void TUpdate(Surecler t)
        {
            _sureclerDAL.Update(t);
        }
    }
}
