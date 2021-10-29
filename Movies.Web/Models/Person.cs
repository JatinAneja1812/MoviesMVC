using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Web.Models
{
    public class Person
    {
        public Person()
        {
        }

        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        public int NationalityId { get; set; }

        public Nationality Nationality { get; set; }

    }
}
