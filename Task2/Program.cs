namespace Task2;

public static class Program
{
    public static void Main()
    {
        var uni = new Uni();
        var student = uni.DodajStudenta("John", "Doe", 1);
        student.DisplayStudent();

        Console.WriteLine("Podaj nr indeksu studenta:");
        var nrIndeksu = int.Parse(Console.ReadLine() ?? "-1");
        uni.UsunStudenta(nrIndeksu);
    }
}