using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeerSupport3.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string City { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
