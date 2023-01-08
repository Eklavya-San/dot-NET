namespace Drawing;
public enum Color {
        RED,GREEN,BLUE
    };
public abstract class Shape {
    
    protected Color Color {
        get;
        set;
    }
    public abstract void Draw ();
    
}