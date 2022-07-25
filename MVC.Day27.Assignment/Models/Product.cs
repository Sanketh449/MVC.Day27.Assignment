using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Day27.Assignment.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU_NO { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Boolean IsAvailable { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;



        public Category Category { get; set; }
        //Foreign Key Column
        public int CategoryId { get; set; }


    }
}