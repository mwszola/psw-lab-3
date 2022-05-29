namespace Task2;

public static class Program
{
    public static void Main()
    {
        var uni = new Uni();
        var isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Prosze, podaj akcje:");
            Console.WriteLine("1) Dodaj studenta");
            Console.WriteLine("2) Usun studenta z listy");
            Console.WriteLine("3) Oblicz srednia ocen studenta");
            Console.WriteLine("4) Oblicz srednia wszystkich studentow");
            Console.WriteLine("5) Zakoncz program");

            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Dodawanie studenta..");
                        Console.WriteLine("Podaj imie:");
                        var imie = Console.ReadLine() ?? "N/A";
                        Console.WriteLine("Podaj nazwisko:");
                        var nazwisko = Console.ReadLine() ?? "N/A";
                        Console.WriteLine("Podaj rok studiow:");
                        var rokSt = int.Parse(Console.ReadLine() ?? "0");
                        var student = uni.DodajStudenta(imie, nazwisko, rokSt);
                        Console.WriteLine("Dodano studenta...");
                        student.DisplayStudent();
                    }
                    catch (ApplicationException error)
                    {
                        Console.WriteLine(error.Message);
                    }

                    break;
                case "2":
                    Console.WriteLine("Usuwanie studenta z listy...");
                    Console.WriteLine("Prosze, podaj numer indeksu");
                    uni.UsunStudenta(int.Parse(Console.ReadLine()));
                    break;
                case "3":
                    Console.WriteLine("Obliczanie sredniej ocen studenta...");
                    Console.WriteLine("Prosze, podaj nr indeksu studenta");
                    var st_3 = uni.ZnajdzStudenta(int.Parse(Console.ReadLine() ?? "-1"));
                    if (st_3 != null)
                    {
                        Console.WriteLine($"Srednia wynosi {uni.ObliczSrednia(st_3)}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Obliczanie sredniej ocen wszystkich studentow");
                    Console.WriteLine($"Srednia wynosi: {uni.ObliczSredniaAll()}");
                    break;
                case "5":
                    Console.WriteLine("Zakonczenie programu...");
                    isRunning = false;
                    break;
            }
        }
    }
}