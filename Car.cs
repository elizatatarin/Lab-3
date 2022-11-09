using System;

class Car
{
    private string name;
    private string color;
    private double price;

    //Властивысть доступу до поля колір
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    //За замовчуванням
    public Car() : this("Name", "Color", 10000)
    {
    }

    //Конструктор з параметрами
    public Car(string name, string color, int price)
    {
        this.name = name;
        this.color = color;
        this.price = price;
    }

    //Введення даних про авто
    public void Input()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("Введіть марку машини");
        this.name = Console.ReadLine();
        Console.WriteLine("Введіть колір машини");
        this.color = Console.ReadLine();
        Console.WriteLine("Введіть вартість машини");
        this.price = Convert.ToDouble(Console.ReadLine());
    }

    //Виведення даних про авто
    public void Print()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Name: {this.name} Color: {this.color} Price: {this.price}");
    }

    //Перевірка чи збігається марка та колір
    public static bool operator ==(Car car1, Car car2)
    {
        return (car1.name == car2.name) && (car1.price == car2.price);
    }
    public static bool operator !=(Car car1, Car car2)
    {
        return (car1.name != car2.name) && (car1.price != car2.price);
    }

    //Виведення даних про авто за допомогою ToString
    public override string ToString()
    {
        return $"Name: {this.name} Color: {this.color} Price: {this.price}";
    }

    //Додає х% до ціни
    public void ChangePrice(double x)
    {
        price += price * x / 100;
    }
}


