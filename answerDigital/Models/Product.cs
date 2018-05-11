using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace answerDigital.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthorised { get; set; }
        public int ColourId { get; set; }
        public string ColourName { get; set; }
    }
}