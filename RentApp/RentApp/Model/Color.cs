using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Model
{
    public class Color
    {
        public int Id;
        public string? Name;

        public Color(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
