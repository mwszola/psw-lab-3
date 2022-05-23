namespace Lab3;

public static class RgbController
{
    /* Metoda inicjujaca zestaw skladowych barw dla danego obiektu */
    public static Rgb GetColor()
    {
        var rnd = new Random();
        return new Rgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
    }

    public static void DisplayColor(Rgb color)
    {
        Console.WriteLine("[" + color.RValue + ", " + color.GValue + ", " + color.BValue + "]");
    }
}