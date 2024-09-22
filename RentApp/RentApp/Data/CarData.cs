

using RentApp.Model;
using RentApp.Model.DTO;

namespace RentApp.Data;

public class CarData
{
    private List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,1,"İstanbul",6001,"2024","31 İY 031","Mercedes-Benz","S580L 4MATIC",5000001),
    };

    // Bütün Repository classlarda GetById, GetAll,
   // Update,Delete,Add metodları olmalıdır

    public Car Add(Car car)
    {
        cars.Add(car);
        return car;
    }
    public Car? GetById(int id)
    {
        Car? car = cars.SingleOrDefault(x => x.Id == id);
        return car;
    }
    public Car? Delete(int id)
    {
        Car? car= GetById(id);
        cars.Remove(car);
        return car;
    }
    public List<Car> GetAll()
    {
        return cars;
    }


    public Car? Update(int id, Car updatedCar)
    {
        
        Car? car = GetById(id);
        if (car != null)
        {            
            car = new Car(
                id: updatedCar.Id,
                colorId: updatedCar.ColorId,
                fuelId: updatedCar.FuelId,
                transmissionId: updatedCar.TransmissionId,
                carState: updatedCar.CarState,
                kiloMeter: updatedCar.KiloMeter,
                modelYear: updatedCar.ModelYear,    
                plate: updatedCar.Plate,
                brandName: updatedCar.BrandName,
                modelName: updatedCar.ModelName,
                dailyPrice: updatedCar.DailyPrice
            );         
            
        }
        return car;
    }


    public List<CarDetailDTO> GetAllDetails(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        var result = from c in cars
                     join cl in colors on c.ColorId equals cl.Id
                     join f in fuels on c.FuelId equals f.Id
                     join t in transmissions on c.TransmissionId equals t.Id
                     select new CarDetailDTO(
                         c.Id,
                         f.Name,
                         t.Name,
                         cl.Name,
                         c.CarState,
                         c.KiloMeter,
                         c.ModelYear,
                         c.Plate,
                         c.BrandName,
                         c.ModelName,
                         c.DailyPrice
                     );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByPriceRange(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions,double min,double max)
    {
        var result = from c in cars
                     join cl in colors on c.ColorId equals cl.Id
                     join f in fuels on c.FuelId equals f.Id
                     join t in transmissions on c.TransmissionId equals t.Id
                     where c.DailyPrice >= min && c.DailyPrice <= max
                     select new CarDetailDTO(
                         c.Id,
                         f.Name,
                         t.Name,
                         cl.Name,
                         c.CarState,
                         c.KiloMeter,
                         c.ModelYear,
                         c.Plate,
                         c.BrandName,
                         c.ModelName,
                         c.DailyPrice
                     );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByKilometerRange(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions, double min, double max)
    {
        var result = from c in cars
                     join cl in colors on c.ColorId equals cl.Id
                     join f in fuels on c.FuelId equals f.Id
                     join t in transmissions on c.TransmissionId equals t.Id
                     where c.KiloMeter >= min && c.KiloMeter <= max
                     select new CarDetailDTO(
                         c.Id,
                         f.Name,
                         t.Name,
                         cl.Name,
                         c.CarState,
                         c.KiloMeter,
                         c.ModelYear,
                         c.Plate,
                         c.BrandName,
                         c.ModelName,
                         c.DailyPrice
                     );

        return result.ToList();
    }


    public List<CarDetailDTO> GetAllDetailsByBrandNameContains(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions, string brandName)
    {
        var result = from c in cars
                     join cl in colors on c.ColorId equals cl.Id
                     join f in fuels on c.FuelId equals f.Id
                     join t in transmissions on c.TransmissionId equals t.Id
                     where c.BrandName.Contains(brandName)
                     select new CarDetailDTO(
                         c.Id,
                         f.Name,
                         t.Name,
                         cl.Name,
                         c.CarState,
                         c.KiloMeter,
                         c.ModelYear,
                         c.Plate,
                         c.BrandName,
                         c.ModelName,
                         c.DailyPrice
                     );

        return result.ToList();
    }

    public List<CarDetailDTO> GetAllDetailsByFuelId(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions, int fuelId)
    {
        var result = from c in cars
                     join cl in colors on c.ColorId equals cl.Id
                     join f in fuels on c.FuelId equals f.Id
                     join t in transmissions on c.TransmissionId equals t.Id
                     where c.FuelId == fuelId 
                     select new CarDetailDTO(
                         c.Id,
                         f.Name,
                         t.Name,
                         cl.Name,
                         c.CarState,
                         c.KiloMeter,
                         c.ModelYear,
                         c.Plate,
                         c.BrandName,
                         c.ModelName,
                         c.DailyPrice
                     );

        return result.ToList();
    }




}
