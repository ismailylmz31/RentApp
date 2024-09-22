using RentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Data
{
    public class FuelData
    {
        private List<Fuel> fuels = new List<Fuel>()
        {
            new Fuel(1,"Diesel")
        };
        public Fuel Add(Fuel fuel)
        {
            fuels.Add(fuel);
            return fuel;
        }

        public Fuel? GetById(int id)
        {
            Fuel fuel = fuels.SingleOrDefault(x=> x.Id == id);
            return fuel;
        }
        public Fuel? Delete(int id)
        {
            Fuel fuel = GetById(id);
            fuels.Remove(fuel);
            return fuel;
        }
        public List<Fuel> GetAll()
        {
            return fuels;
        }

        public Fuel Update(int id, Fuel Updatedfuel)
        {
            Fuel fuel = GetById(id);
            if (fuel != null)
            {
                fuel = new Fuel(
                    id: Updatedfuel.Id,
                    name: Updatedfuel.Name
                    );
            }
            return fuel;
        }

    }
}
