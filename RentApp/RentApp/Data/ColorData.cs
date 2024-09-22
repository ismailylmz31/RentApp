

using RentApp.Model;

namespace RentApp.Data;

public class ColorData
{
    private List<Color> colors = new List<Color>()
    {
        new Color(1,"Siyah"),
    };


    public Color Add(Color color)
    {
        colors.Add(color);
        return color;
    }
    public Color? GetById(int id)
    {
        Color? color = colors.SingleOrDefault(x=> x.Id==id);
        return color;
    }
    public Color? Delete(int id)
    {
        Color? color = GetById(id);
        colors.Remove(color);
        return color;
    }
    public List<Color> GetAll()
    {
        return colors;
    }
    public Color? Update(int id,Color updatedColor)
    {
        Color color = GetById(id);
        if (color != null)
        {
            color = new Color(
                id: updatedColor.Id,
                name: updatedColor.Name

                );
        }
        return color;
    }
}
