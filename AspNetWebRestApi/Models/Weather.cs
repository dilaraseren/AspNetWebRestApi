using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetWebRestApi.Models
{
    public class Weather
    { 
        [Key]
        public int id { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        
        public decimal temperature { get; set; }
    }
}