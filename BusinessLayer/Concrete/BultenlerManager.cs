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
    public class BultenlerManager : IBultenlerService
    {
        IBultenlerDAL _bultenlerDAL;

        public BultenlerManager(IBultenlerDAL bultenlerDAL)
        {
            _bultenlerDAL = bultenlerDAL;
        }

        public void TAdd(Bultenler t)
        {
            _bultenlerDAL.Insert(t);
        }

        public void TDelete(Bultenler t)
        {
            _bultenlerDAL.Delete(t);
        }

        public Bultenler TGetByID(int id)
        {
            return _bultenlerDAL.GetByID(id);
        }

        public List<Bultenler> TGetList()
        {
            return _bultenlerDAL.GetList();
        }

        public void TUpdate(Bultenler t)
        {
            _bultenlerDAL.Update(t);
        }
    }
}
