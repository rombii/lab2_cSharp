namespace lab2;

public class Rectangle : Shape
{
    public override string Draw()
    {
        return base.Draw() + this.GetType().Name;
    }
}