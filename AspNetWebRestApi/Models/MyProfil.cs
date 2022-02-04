using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetWebRestApi.Models
{
    public class MyProfil
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
    }
}