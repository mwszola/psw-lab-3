namespace Lab3;

public static class Program
{
    public static void Main()
    {
        var rgbColor = RGBController.GetColor(255, 255, 255);
        Console.WriteLine("Kolor 1:");
        RGBController.DisplayColor(rgbColor);
        
        var rgbColor2 = RGBController.GetColor(0, 0, 0);
        Console.WriteLine("Kolor 2:");
        RGBController.DisplayColor(rgbColor2);
        
        Console.WriteLine("Mieszanie kolorow... Rezultat:");
        var rgbColor3 = RGBController.RemixColors(rgbColor, rgbColor2);
        RGBController.DisplayColor(rgbColor3);
    }
}