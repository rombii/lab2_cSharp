namespace lab2;

public class Circle : Shape
{
    public override string Draw()
    {
        return base.Draw() + this.GetType().Name;
    }
}