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
    public class LoglarManager : ILoglarService
    {
        ILoglarDAL _loglarDAL;

        public LoglarManager(ILoglarDAL loglarDAL)
        {
            _loglarDAL = loglarDAL;
        }

        public void TAdd(Loglar t)
        {
           _loglarDAL.Insert(t);
        }

        public void TDelete(Loglar t)
        {
            _loglarDAL.Delete(t);
        }

        public Loglar TGetByID(int id)
        {
            return _loglarDAL.GetByID(id);
        }

        public List<Loglar> TGetList()
        {
            return _loglarDAL.GetList();
        }

        public void TUpdate(Loglar t)
        {
            _loglarDAL.Update(t);
        }
    }
}
