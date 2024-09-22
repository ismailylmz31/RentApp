using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Model
{
    public class Car
    {
        public int Id;
        public int ColorId;
        public int FuelId;
        public int TransmissionId;
        public string? CarState;
        public double KiloMeter;
        public string? ModelYear;
        public string? Plate;
        public string? BrandName;
        public string? ModelName;
        public double DailyPrice;
        

        public Car(int id, int colorId, int fuelId, int transmissionId, string carState, double kiloMeter, string modelYear, string plate, string brandName, string modelName, double dailyPrice)
        {
            this.Id = id;
            this.ColorId = colorId;
            this.FuelId = fuelId;
            this.TransmissionId = transmissionId;
            this.CarState = carState;
            this.KiloMeter = kiloMeter;
            this.ModelYear = modelYear;
            this.Plate = plate;
            this.BrandName = brandName;
            this.ModelName = modelName;
            this.DailyPrice = dailyPrice;
        }
    }
}
