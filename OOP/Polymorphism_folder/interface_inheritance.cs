namespace Learning_C_;


public static class InterfaceInheritance
{
    public static void Result()
    {
        Driverr driver = new();
        IVehicle[] garage = { new Bike(), new Carr(), new Parachute() }; // я могу добавить парашут сюда и он будет сразу работать

        foreach (var item in garage)
        {
            driver.Drive(item); ;
            Console.WriteLine();
        }

        driver.UseGadget(new Parachute());
    }
}

interface IVehicle
{
    int Speed { get; }
    void Use();
}

interface IGadget : IVehicle // унаследование интерфейса позволит объектам все равно работать даже при наличии нового функционала
{
    void Deploy();
}


class Bike : IVehicle // это не наследование интерфейса, а его реализация
{
    public int Speed { get { return 3; } }
    public void Use()
    {
        Console.WriteLine("Slow bike.");
    }
}

class Carr : IVehicle
{
    public int Speed { get { return 60; } }
    public void Use()
    {
        Console.WriteLine("Just a regular car.");
    }
}

class Parachute : IGadget // класс с реализацией двойного интерфейса
{
    public int Speed { get { return 2; } }

    public void Deploy()
    {
        Console.WriteLine("Deployed parachute.");
    }

    public void Use()
    {
        Console.WriteLine("Gadget equipped.");
    }
}

// даже не имея обновленного метода для использования гаджетов персонаж сможет использовать их по умолчанию
class Driverr
{
    public void Drive(IVehicle vehicle)
    {
        vehicle.Use();
    }

    public void UseGadget(IGadget gadget)
    {
        gadget.Deploy();
    }
}