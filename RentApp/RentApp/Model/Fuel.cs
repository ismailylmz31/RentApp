using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Model
{
    public class Fuel
    {
        public int Id;
        public string? Name;


        public Fuel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
