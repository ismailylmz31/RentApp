using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Model
{
    public class Transmission
    {
        public int Id;
        public string? Name;

        public Transmission(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
