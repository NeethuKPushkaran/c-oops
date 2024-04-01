
//class Car
//{
//    string color = "red";

//    static void Main(string[] args)
//    {
//        //Multiple Objects
//        Car car1 = new Car();
//        Car car2 = new Car();
//        Console.WriteLine(car1.color);
//        Console.WriteLine(car2.color);
//    }
//}


class Car
{
    public string color = "red";
}

class Program
{
    static void Main(string[] args) { 
        Car car = new Car();
        Console.WriteLine(car.color);
    }
}