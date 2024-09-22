using RentApp.Data;
using RentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Service
{
    public class TransmissionService
    {
        TransmissionData transmissionData = new TransmissionData();

        public void Add(Transmission transmission)
        {
            transmissionData.Add(transmission);
            Console.WriteLine("VİTES EKLENDİ NEYİNİ EKLİYOSAK ARTIK!");
        }

        public void GetById(int id)
        {
            Transmission transmission = transmissionData.GetById(id);
            if (transmission != null)
            {
                Console.WriteLine("Aranan vites kutusu bulunamadı!!!");
                return;
            }
            Console.WriteLine(transmission);

        }
        public void Delete(int id)
        {
            Transmission transmission = transmissionData.Delete(id);
            if (transmission is null)
            {
                Console.WriteLine("vites silinemedi!");
            }
            Console.WriteLine("seçilen viites silindi!");
        }
        public void GetAll()
        {
            List<Transmission> transmissions = transmissionData.GetAll();
            transmissions.ForEach(X => Console.WriteLine(X));
        }
        public void Update(int id, Transmission Updatedtransmission)
        {
            Transmission? transmission = transmissionData.Update(id, Updatedtransmission);
            if (transmission is null)
            {
                Console.WriteLine("Aranan vites kutusu yok !");
            }
            Console.WriteLine("vites güncellendi: ");
            Console.WriteLine(transmission);
        }
    }
}
