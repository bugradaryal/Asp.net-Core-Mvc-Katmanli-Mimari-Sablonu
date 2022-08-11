using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager()
        {
            _hotelRepository = new HotelRepository();
        }

        public List<Hotel> GetAllHotels()
        {
            try
            {
                return _hotelRepository.GetAllHotels();
            }
            catch (Exception) 
            { 
                return null; 
            }
        }
    }
}
