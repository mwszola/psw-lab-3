namespace Lab3;

internal static class Program
{
    public static void Main()
    {
        var color = RgbController.GetColor();
        RgbController.DisplayColor(color);
    }
}