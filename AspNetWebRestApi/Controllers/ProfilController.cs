using AspNetWebRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebRestApi.Controllers
{
    public class ProfilController : ApiController
    {
        public IEnumerable<MyProfil> Get()  
        {
            using (Context context = new Context())
            {
                return context.MyProfils.ToList();
            }
        }
    }
}
