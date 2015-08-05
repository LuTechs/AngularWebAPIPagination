using System;

namespace AngularWebAPIPagination.Models
{
    public class Product
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public float  Price { get; set; }
        public int Qty { get; set; }
        public DateTime Date { get; set; }
    }
}