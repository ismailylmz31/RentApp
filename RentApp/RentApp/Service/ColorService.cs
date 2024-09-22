


using RentApp.Data;
using RentApp.Model;

namespace RentApp.Service;

public class ColorService
{
    ColorData colorData = new ColorData();


    public void Add(Color color)
    {
        colorData.Add(color);
        Console.WriteLine("Renk eklendi!");
    }
    public void GetById(int id)
    {
        Color color = colorData.GetById(id);
        if (color != null)
        {
            Console.WriteLine("ARADIĞINIZ RENK BULUNAMADI1");
            return;
        }
        Console.WriteLine(color);
    }

    public void Delete(int id)
    {
        Color color = colorData.Delete(id);
        if (color is null)
        {
            Console.WriteLine($"ARABA Bulunamadı : Id= {id}");
            return;
        }
        Console.WriteLine("Seçilen renk silindi!");
    }
    public void GetAll()
    {
        List<Color> colors = colorData.GetAll();
        colors.ForEach(x => Console.WriteLine(x));
    }
    public void Update(int id, Color updatedColor)
    {
        Color? color = colorData.Update(id, updatedColor);

        if (color is null)
        {
            Console.WriteLine($"Güncellemek istediğiniz renk bulunamadı: Id= {id}");
            return;
        }
        Console.WriteLine("renk güncellendi.");
        Console.WriteLine(color);

    }
}
