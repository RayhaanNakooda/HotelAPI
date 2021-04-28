using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelAPI.Models;

namespace HotelAPI.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {

        List<Hotel> hotels = HotelListUtil.hotels;

        public HotelController()
        {

            if(hotels.Count == 0){
            Hotel h1 = new Hotel(1, "Hotel Translyvania" , "https://en.wikipedia.org/wiki/Hotel_Transylvania" , "Hollywood", 5 , "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Hotel_Transylvania_logo.svg/250px-Hotel_Transylvania_logo.svg.png");
            Hotel h2 = new Hotel(2, "Hilton" , "https://en.wikipedia.org/wiki/Hotel_Transylvania" , "Durban", 5 , "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Hotel_Transylvania_logo.svg/250px-Hotel_Transylvania_logo.svg.png");

            hotels.Add(h1);
            hotels.Add(h2);
            }
           
        }

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return hotels;            
        }


        [HttpGet]
        public Hotel GetHotel(string s)
        {
            return hotels.Where(h => h.Name.Contains(s)).FirstOrDefault();           
        }


        [HttpPost]
        public void PostHotel(Hotel h){
            hotels.Add(h);
        }

    }


}