namespace Task2;

public class Uni
{
    public double[] ListaDopuszczalnychOcen = {2, 3, 3.5, 4, 4.5, 5};
    private readonly List<Student> ListaStudentow = new();

    public Student DodajStudenta(string imie, string nazwisko, int rokSt)
    {
        // 1. Utworz obiekt "Student"
        var nrIndeksu = ListaStudentow.Count + 1;
        var student = new Student(nrIndeksu, imie, nazwisko, rokSt);
        
        // 2. Pobierz oceny studenta z klawiatury
        Console.WriteLine("Prosze, podaj oceny studenta oddzielone przecinkiem:");
        var input = Console.ReadLine()?.Split(",") ?? Array.Empty<string>();

        // Konwersja ocen
        student.Oceny = input.Select(double.Parse).ToList();
        
        // 3. Dodaj studenta do "ListaStudentow"
        ListaStudentow.Add(student);
        
        return student;
    }

    public Student? UsunStudenta(int nr_indeksu)
    {
        var st = ListaStudentow.Find(st => st.Nr_indeksu == nr_indeksu);  
        if (st != null)
        {
            ListaStudentow.Remove(st);
            Console.WriteLine($"Student o numerze indeksu: {nr_indeksu}, zostal usuniety z listy");
        }
        else
        {
            Console.WriteLine($"Student o numerze indeksu: {nr_indeksu}, nie zostal znaleziony");
        }

        return st;
    } 
}