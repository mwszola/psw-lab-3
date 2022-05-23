namespace Lab3;

public class Rgb
{
    public int RValue { get; set; }
    public int GValue { get; set; }
    public int BValue { get; set; }

    public Rgb()
    {
    }

    public Rgb(int rValue, int gValue, int bValue)
    {
        RValue = rValue;
        GValue = gValue;
        BValue = bValue;
    }
}