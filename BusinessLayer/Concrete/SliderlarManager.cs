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
    public class SliderlarManager : ISliderlarService
    {
        ISliderlerDAL _sliderlarDAL;

        public SliderlarManager(ISliderlerDAL sliderlarDAL)
        {
            _sliderlarDAL = sliderlarDAL;
        }

        public void TAdd(Sliderlar t)
        {
            _sliderlarDAL.Insert(t);
        }

        public void TDelete(Sliderlar t)
        {
            _sliderlarDAL.Delete(t);
        }

        public Sliderlar TGetByID(int id)
        {
            return _sliderlarDAL.GetByID(id);
        }

        public List<Sliderlar> TGetList()
        {
            return _sliderlarDAL.GetList();
        }

        public void TUpdate(Sliderlar t)
        {
            _sliderlarDAL.Update(t);
        }
    }
}
