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
    public class ReferanslarManager : IReferanslarService
    {
        IReferanslarDAL _referanslarDAL;

        public ReferanslarManager(IReferanslarDAL referanslarDAL)
        {
            _referanslarDAL = referanslarDAL;
        }

        public void TAdd(Referanslar t)
        {
            _referanslarDAL.Insert(t);
        }

        public void TDelete(Referanslar t)
        {
            _referanslarDAL.Delete(t);
        }

        public Referanslar TGetByID(int id)
        {
            return _referanslarDAL.GetByID(id);
        }

        public List<Referanslar> TGetList()
        {
           return _referanslarDAL.GetList();
        }

        public void TUpdate(Referanslar t)
        {
            _referanslarDAL.Update(t);
        }
    }
}
