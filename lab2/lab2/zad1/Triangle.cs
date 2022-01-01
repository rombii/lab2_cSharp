namespace lab2;

public class Triangle : Shape
{
    public override string Draw()
    {
        return base.Draw() + this.GetType().Name;
    }
}