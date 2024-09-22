using RentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Data
{
    public class TransmissionData
    {
        private List<Transmission> transmissions = new List<Transmission>() { 
        
            new Transmission(1,"Auto"),
            new Transmission(2,"Manuel")
        };

        public Transmission Add(Transmission transmission)
        {
            transmissions.Add(transmission);
            return transmission;
        }
        public Transmission GetById(int id)
        {
            Transmission? transmission = transmissions.SingleOrDefault(x=> x.Id == id);
            return transmission;
        }
        public Transmission Delete(int id)
        {
            Transmission? transmission = GetById(id);
            transmissions.Remove(transmission);
            return transmission;
        }

        public List<Transmission> GetAll()
        {
            return transmissions;
        }

        public Transmission? Update(int id, Transmission Updatedtransmission)
        {
            Transmission transmission = GetById(id);
            if (transmission != null)
            {
                transmission = new Transmission(
                    id: Updatedtransmission.Id,
                    name: Updatedtransmission.Name
                    );
            }
            return transmission;
        }

    }
}
