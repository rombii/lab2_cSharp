namespace lab2.zad2;

public class Uczen : Osoba
{
    private string szkola;
    private bool mozeSamWracacDoDomu;

    public void SetSchool(string szkola)
    {
        this.szkola = szkola;
    }

    public void ChangeSchool()
    {
        
    }

    public void SetCanGoHomeAlone(bool can)
    {
        this.mozeSamWracacDoDomu = can;
    }

    public bool CanGoAloneToHome()
    {
        return mozeSamWracacDoDomu;
    }
    
}