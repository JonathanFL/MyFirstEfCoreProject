using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstEfCoreProject.Model
{
    class Printer
    {
        public int Id { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public int productId { get; set; }
    }
}
