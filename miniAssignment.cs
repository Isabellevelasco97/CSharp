using System;
class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("I am an animal");
    }
}
class Giraffe : Animal
{
    private int heightInFt = 10;
    private int weightInLbs = 80;
    public override void speak()
    {
        base.speak();
        Console.WriteLine("I am big and tall");
    }
}
class Cat : Animal
{
    public override void speak()
    {
        Console.WriteLine("I am a cat and I love to sleep");
        for (int i = 0; i < 24; i++)
        {
            Console.WriteLine("zzz...");
        }
    }
}
class Hippo : Animal
{
    private int heightInFt = 10;
    private int weightInLbs = 80;
    public override void speak()
    {
        base.speak();
        Console.WriteLine("I am big and tall");
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("My name is the Hippo!");
        }
    }
}
class Program
{
    public static void notMain(String[] args)
    {
        new Animal().speak();
        Giraffe giraffe = new Giraffe();
        giraffe.speak();
        Cat cat = new Cat();
        cat.speak();
        Hippo hippo = new Hippo();
        hippo.speak();
    }

}