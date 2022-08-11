using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public List<Hotel> GetAllHotels()
        {
            using(var _DBContext = new DBContext())
            {
                return _DBContext.Hotels.Where(x => x.MyProperty == 1).ToList();
            }
        }
    }
}
