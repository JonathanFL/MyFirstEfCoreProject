using System;
using System.Collections.Generic;
using System.Text;
using MyFirstEfCoreProject;

namespace MyFirstEfCoreProject.Model
{
    class Product
    {
        public int Id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public string type { get; set; }
    }
}
