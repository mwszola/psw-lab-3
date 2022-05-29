namespace Task2;

public class Uni
{
    private readonly double[] ListaDopuszczalnychOcen = {2, 3, 3.5, 4, 4.5, 5};
    private readonly List<Student> ListaStudentow = new();

    public Student DodajStudenta(string imie, string nazwisko, int rokSt)
    {
        // Utworzenie obiektu klasy "Student"
        var nrIndeksu = ListaStudentow.Count + 1;
        var student = new Student(nrIndeksu, imie, nazwisko, rokSt);

        // Wprowadzenie ocen studenta z klawiatury
        Console.WriteLine("Prosze, podaj oceny studenta oddzielone przecinkiem:");
        var input = Console.ReadLine()?.Split(",") ?? Array.Empty<string>();

        // Konwersja ocen
        var oceny = input.Select(double.Parse).ToList();

        // Porownanie wprowadzonych ocen z lista dopuszczalnych ocen
        if (oceny.Any(ocena => !ListaDopuszczalnychOcen.Contains(ocena)))
        {
            throw new ApplicationException(
                $"Dopuszczalne oceny to: {ListaDopuszczalnychOcen.Aggregate("", (current, ocena) => current + (" " + ocena))}");
        }
        // Przypisanie ocen studentowi
        student.Oceny = oceny;
        // Dodanie studenta do "ListaStudentow"
        ListaStudentow.Add(student);

        return student;
    }

    public Student? ZnajdzStudenta(int nr_indeksu)
    {
        var st = ListaStudentow.Find(st => st.Nr_indeksu == nr_indeksu);
        if (st == null)
        {
            Console.WriteLine("Nie znaleziono studenta");    
        }

        return st;
    }

    public Student? UsunStudenta(int nr_indeksu)
    {
        var st = ZnajdzStudenta(nr_indeksu);
        if (st != null)
        {
            ListaStudentow.Remove(st);
            Console.WriteLine($"Student o numerze indeksu: {nr_indeksu}, zostal usuniety z listy");
        }
        
        return st;
    }

    public double ObliczSrednia(Student student)
    {
        double srednia = 0;
        if (student.Oceny.Count > 0)
        {
            srednia = student.Oceny.Sum() / student.Oceny.Count;
        }

        return srednia;
    }

    public double ObliczSredniaAll()
    {
        double sumaOcen = 0;
        double liczbaOcen = 0;
        if (ListaStudentow.Count <= 0)
        {
            return 0;
        }
        
        foreach (var student in ListaStudentow)
        {
            sumaOcen += student.Oceny.Sum();
            liczbaOcen += student.Oceny.Count;
        }

        return sumaOcen / liczbaOcen;
    }
}