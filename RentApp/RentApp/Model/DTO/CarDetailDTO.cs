using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Model.DTO
{
    public record CarDetailDTO(
         int Id,
         string? FuelName,
         string? TransmissionName,
         string? ColorName,
         string? CarState,
         double KiloMeter,
         string? ModelYear,
         string? Plate,
         string? BrandName,
         string? ModelName,
         double DailyPrice
        
        );
    
}
