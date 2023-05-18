using System;

public class Form
{
    protected string color;

    public Form(string color)
    {
        this.color = color;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Ritar en form med färgen: " + color);
    }
}

public class Cirkel : Form
{
    private double radius;

    public Cirkel(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Ritar en cirkel med radius: " + radius);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Form shape = new Form("Röd");
        shape.Draw();

        Console.WriteLine();

        Cirkel circle = new Cirkel("Blå", 5.0);
        circle.Draw();

        Console.ReadLine();
    }
}
