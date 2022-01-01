namespace lab2.zad2;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private string pesel;

    public void setFirstName(string imie)
    {
        this.imie = imie;
    }

    public void setLastName(string nazwisko)
    {
        this.nazwisko = nazwisko;
    }

    public void setPesel(string pesel)
    {
        this.pesel = pesel;
    }

    public int getAge(DateTime date)
    {
        int dzien = (int) pesel[4] * 10 + (int) pesel[5];
        int miesiac = (int) pesel[2] * 10 + (int) pesel[3];
        int rok;
        if (miesiac < 13)
        {
            rok = 1900 + (int) pesel[0] * 10 + (int) pesel[1];
        }
        else
        {
            rok = 2000 + (int) pesel[0] * 10 + (int) pesel[1];
        }

        int wiek = date.Year - rok;
        if (date.Month > miesiac)
        {
            wiek--;
        }
        else
        {
            if (date.Month == miesiac)
            {
                if (date.Day > dzien)
                {
                    wiek--;
                }
            }
        }

        return wiek;
    }

    public string getGender()
    {
        return (int) pesel[10] % 2 == 0 ? "k" : "m";
    }

    public string getEducationInfo()
    {
        return "";
    }

    public string getFullName()
    {
        return imie + " " + nazwisko;
    }
}