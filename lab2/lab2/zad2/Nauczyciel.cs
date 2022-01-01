using System.Collections.ObjectModel;

namespace lab2.zad2;

public class Nauczyciel : Uczen
{
    private string tytulNaukowy;
    private Collection<Uczen> podwladniUczniowie;

    public void whichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        foreach (Uczen uczen in podwladniUczniowie)
        {
            if (uczen.getAge(dateToCheck) > 12 || uczen.CanGoAloneToHome())
            {
                Console.WriteLine(uczen.getFullName());
            }
        }
    }
}