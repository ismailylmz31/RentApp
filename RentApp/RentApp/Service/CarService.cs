using RentApp.Data;
using RentApp.Model;
using RentApp.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Service
{
    public class CarService
    {
        private CarData carData = new CarData();
        private ColorData colorData = new ColorData();
        private TransmissionData transmissionData = new TransmissionData();
        private FuelData fuelData = new FuelData();
        public void Add(Car car)
        {
            carData.Add(car);
            Console.WriteLine("Araba eklendide bu ödev biraz uzun değilmi!!!! ");
        }
        public void GetById(int id)
        {
            Car? car = carData.GetById(id);
            if (car is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre ARABA bulunamadı :{id}");
                return;
            }
            Console.WriteLine($"Seçilen ARABA id si: {id}");
            Console.WriteLine(car);
        }
        public void delete(int id)
        {
            Car? car = carData.Delete(id);
            if (car is null)
            {
                Console.WriteLine($"ARABA Bulunamadı : Id= {id}");
                return;
            }
            Console.WriteLine("ARABA  Silindi.");
            Console.WriteLine(car);
        }
        public void GetAll()
        {
            List<Car> cars = carData.GetAll();
            cars.ForEach(x => Console.WriteLine(x));
        }

        public void Update(int id, Car updatedCar)
        {
            Car? car = carData.Update(id, updatedCar);
            if (car is null)
            {
                Console.WriteLine($"Güncellemek istediğiniz ARABA bulunamadı: Id= {id}");
                return;
            }
            Console.WriteLine("ARABA güncellendi.");
            Console.WriteLine(car);
        }

        public void GettAllDetails()
        {

            List<Color> colors = colorData.GetAll();
            List<Fuel> fuels = fuelData.GetAll();
            List<Transmission> transmissions = transmissionData.GetAll(); 

           
            List<CarDetailDTO> carDetailDTOs = carData.GetAllDetails(colors, fuels, transmissions);           
            carDetailDTOs.ForEach(dto => Console.WriteLine(dto));
        }

        public void GetAllDetailsByPriceRange(double min, double max)
        {

            List<Color> colors = colorData.GetAll();
            List<Fuel> fuels = fuelData.GetAll();
            List<Transmission> transmissions = transmissionData.GetAll();


            List<CarDetailDTO> carDetailDTOs = carData.GetAllDetailsByPriceRange(colors, fuels, transmissions,min,max);         
            carDetailDTOs.ForEach(dto => Console.WriteLine(dto));
        }
        public void GetAllDetailsByKilometerRange(double min, double max)
        {

            List<Color> colors = colorData.GetAll();
            List<Fuel> fuels = fuelData.GetAll();
            List<Transmission> transmissions = transmissionData.GetAll();


            List<CarDetailDTO> carDetailDTOs = carData.GetAllDetailsByKilometerRange(colors, fuels, transmissions, min, max);             
            carDetailDTOs.ForEach(dto => Console.WriteLine(dto));
        }

        public void GetAllDetailsByBrandNameContains(string brandName)
        {

            List<Color> colors = colorData.GetAll();
            List<Fuel> fuels = fuelData.GetAll();
            List<Transmission> transmissions = transmissionData.GetAll();


            List<CarDetailDTO> carDetailDTOs = carData.GetAllDetailsByBrandNameContains(colors, fuels, transmissions, brandName);
            carDetailDTOs.ForEach(dto => Console.WriteLine(dto));
        }
        public void GetAllDetailsByFuelId(int fuelId)
        {

            List<Color> colors = colorData.GetAll();
            List<Fuel> fuels = fuelData.GetAll();
            List<Transmission> transmissions = transmissionData.GetAll();


            List<CarDetailDTO> carDetailDTOs = carData.GetAllDetailsByFuelId(colors, fuels, transmissions, fuelId);
            carDetailDTOs.ForEach(dto => Console.WriteLine(dto));
        }

    }
}
