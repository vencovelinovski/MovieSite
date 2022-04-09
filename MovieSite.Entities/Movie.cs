using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieSite.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string PersonName { get; set; }
        public string PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime RealiseDate { get; set; }


    }
}
