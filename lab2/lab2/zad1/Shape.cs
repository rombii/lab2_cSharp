namespace lab2;

public class Shape
{
    private double x;
    private double y;
    private double height;
    private double width;

    public void setX(double x)
    {
        this.x = x;
    }

    public double getX()
    {
        return x;
    }
    
    public void setY(double y)
    {
        this.y = y;
    }

    public double getY()
    {
        return x;
    }
    
    public void setHeight(double height)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }
    
    public void setWidth(double width)
    {
        this.width = width;
    }

    public double getWidth()
    {
        return width;
    }

    public virtual string Draw()
    {
        return "you try to draw: ";
    }
}