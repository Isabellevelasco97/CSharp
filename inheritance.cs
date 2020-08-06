using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* 
    Derived class (child) - class that inherits from another class
    Base class (parent) - class being inherited from
    < access-specifier > class < base_class > {
        ...
    }
    class < derived_class > : < base class > {
        ...
    }
     */
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
         // protected modifier is used to specify that access is limited to the containing type
         // or types derived from the containing class so the type or member can only be accessed 
         // by code in the same class or in a derived class.
     }
     // Derived class
     class Rectangle: Shape
     {
         public int getArea()
         {
             return (width * height);
         }
     }
     class RectangleTester
     {
         static void notMain(string[] args)
         {
             Rectangle rect = new Rectangle();
             rect.setWidth(5);
             rect.setHeight(7);

             Console.WriteLine("Total area: {0}", rect.getArea());
             // {0} is place holder for object
             Console.ReadKey();
         }
     }

}