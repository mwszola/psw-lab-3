namespace Lab3;

public static class RGBController
{
    /* Metoda inicjujaca zestaw skladowych barw dla danego obiektu */
    public static RGB GetColor(int rValue, int gValue, int bValue)
    {
        return new RGB(rValue, gValue, bValue);
    }

    /* Metoda wyswietlajaca skladowe barw w formacie [R_value, G_value, B_value] */
    public static void DisplayColor(RGB color)
    {
        Console.WriteLine($"[{color.R_value}, {color.G_value}, {color.B_value}]");
    }

    /* Metoda mieszajaca kolory */
    public static RGB RemixColors(RGB color1, RGB color2)
    {
        return new RGB((color1.R_value + color2.R_value) / 2, (color1.G_value + color2.G_value) / 2,
            (color1.B_value + color2.B_value) / 2);
    }
}