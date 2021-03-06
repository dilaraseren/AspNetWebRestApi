using AspNetWebRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebRestApi.Controllers
{
    public class TemperatureController : ApiController
    {

        public IEnumerable<Weather> Get() 
        {
            using (Context context = new Context())
            {
                return context.Weathers.ToList();
            }
        }

        public Weather Get(int Id)   
        {
            using (Context context = new Context())
            {
                return context.Weathers.FirstOrDefault(e => e.id == Id);
            }
        }

       
       




    }
}
