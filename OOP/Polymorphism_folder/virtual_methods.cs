namespace Learning_C_;

public static class VirtualMethods
{
    public static void Result()
    {
        Car car = new SuperCar();
        Driver driver = new();
        driver.Drive(car);
    }
}


class Car
{
    public virtual void Drive() // данный модификатор позволяет переопределять данный метод у зависимых классов.
    {
        Console.WriteLine("I'm driving.");
    }
    protected virtual void StartEngine() // пример использования protected
    {
        Console.WriteLine("Starting the engine...");
    }
}

class SuperCar : Car
{
    public override void Drive() // так выглядит переопределенный метод в зависимом классе
    {
        StartEngine();
        Console.WriteLine("I'm driving very fast!");
    }
}

class Driver
{
    public void Drive(Car car)
    {
        car.Drive();
    }
}