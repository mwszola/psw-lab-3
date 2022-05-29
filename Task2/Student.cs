namespace Task2;

public class Student
{
    private int nr_indeksu;
    private string imie;
    private string nazwisko;
    private int rok_st;
    private List<double> oceny = new();

    public int Nr_indeksu
    {
        get => nr_indeksu;
        set => nr_indeksu = value;
    }
    
    public string Imie
    {
        get => imie;
        set => imie = value;
    }
    
    public string Nazwisko
    {
        get => nazwisko;
        set => nazwisko = value;
    }
    
    public int Rok_st
    {
        get => rok_st;
        set => rok_st = value;
    }

    public List<double> Oceny
    {
        get => oceny;
        set => oceny = value;
    }

    public Student(int nr_indeksu, string imie, string nazwisko, int rok_st)
    {
        Nr_indeksu = nr_indeksu;
        Imie = imie;
        Nazwisko = nazwisko;
        Rok_st = rok_st;
    }

    public void DisplayStudent()
    {
        Console.WriteLine(
            $"Student:\nnr_indeksu = {Nr_indeksu}\nimie = {Imie}\nnazwisko = {Nazwisko}\nrok_st = {Rok_st}");
        
        if (Oceny.Count <= 0) return;
        
        Console.WriteLine($"Oceny:{Oceny.Aggregate("", (current, ocena) => current + (" " + ocena))}");
    }
}