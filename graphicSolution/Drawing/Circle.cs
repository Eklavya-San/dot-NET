using Drawing;

public class Circle : Shape{
    public Point Center {
        get;
        set;
    }
    public int Radius{
        get;
        set;
    }

    public Circle() {
        this.Center  = new Point (0,0);
        this.Radius =1;
    }
    public Circle (Point center , int Radius){
        this.Center = center;
        this.Radius = Radius;
    }
     public override void Draw() {
        Console.WriteLine();
    }
}