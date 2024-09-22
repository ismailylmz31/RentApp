using RentApp.Data;
using RentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Service
{
    public class FuelService
    {
        FuelData fuelData = new FuelData();

        public void Add(Fuel fuel)
        {
            fuelData.Add(fuel);
            Console.WriteLine("BENZİN, DİZEL, LPG, 3-5 TANE DAHA YAKIT TÜRÜ VAR AMA HATIRLAMIYOM ARAŞŞTIRMAKLA UĞRAŞMADIM");
        }


        public void GetById(int id)
        {
            Fuel fuel = fuelData.GetById(id);
            if (fuel != null)
            {
                Console.WriteLine("aranan yakıt bulunamadı!");
                return;
            }
            Console.WriteLine(fuel);
        }

        public void Delete(int id)
        {
            Fuel fuel = fuelData.Delete(id);
            if (fuel != null)
            {
                Console.WriteLine("SIKILDIM! OLMAYAN YAKITI SİLEMESİN");
            }
            Console.WriteLine(fuel);
        }


        public void GetAll()
        {
            List<Fuel> fuels = fuelData.GetAll();
            fuels.ForEach(x=> Console.WriteLine(x));
        }

        public void Update(int id,Fuel Updatedfuel)
        {
            Fuel? fuel = fuelData.Update(id,Updatedfuel);
            if (fuel != null)
            {
                Console.WriteLine("OLMAYAN YAKIT GÜNCELLENEMEZ!");
                return;
            }
            Console.WriteLine(fuel);
        }


    }
}
