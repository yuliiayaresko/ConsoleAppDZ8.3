using System;

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Rectangle rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine($"Площа прямокутника: {rect.GetArea()}"); // Виведе 50

        
        Square square = new Square { Side = 5 };
        Console.WriteLine($"Площа квадрата: {square.GetArea()}"); // Виведе 25

        Console.ReadKey();
    }
}
//я розділила на класи бо помилка була в тому що прямокутнику площа рахувалась як 10*10 бо в  класі Square властивості Width і Height залежали одна від одної, отримувався неправильний  результат, тому воно не може вивести 100