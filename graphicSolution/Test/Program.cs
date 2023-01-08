using Drawing;
using System.Collections.Generic;
Point pt1 = new Point  (12,12);
Point pt2 = new Point (56,121);
Point pt3 = new Point  (1432,1212);
Point pt4 = new Point  (67,121);

Shape shape1 = new Line (pt1,pt2);
Shape shape2 = new Rectangle (pt3,pt4);
int Radius = 45;
Point center = new Point (45,23);
Shape  c1= new Circle (center,Radius);


List <Shape> shapes = new List<Shape> ();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(c1);

Console.WriteLine("Drawing all Shapes");

foreach (Shape s in shapes){
    s.Draw();
    // object.Print();
}