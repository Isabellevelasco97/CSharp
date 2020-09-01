using System;

// c# doesnt support multiple inheritance but 
// u can use interfaces to implement multiple inheritance

class Shape
{
    public void setWidth(int w)
    {
        width = w;
    }
    public void setHeight(int h)
    {
        height = h;
    }
    protected int width;
    protected int height;

    // Base class
    public interface PaintCost
    {
        int getCost(int area);
    }
    // Derived class
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }
    class RectangleTester
    {
        static void notMain(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;

            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    } 
}