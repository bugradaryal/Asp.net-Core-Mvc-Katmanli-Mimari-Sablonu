using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
    }
}
