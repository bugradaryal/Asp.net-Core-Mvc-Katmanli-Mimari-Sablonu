using System.Collections.Generic;
using Entities;

namespace DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
    }
}
