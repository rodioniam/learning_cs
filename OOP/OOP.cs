using System.Runtime.Versioning;

namespace Learning_C_;


class Gun
{
    public Gun()
    {
        
    }
    public Gun(bool isLoaded) // это создание конструктора класса
    {
        _isLoaded = isLoaded; // при создании нового экземпляра класса будут применены эти параметры
        // можно вызывать и методы класса
        // Reload();
    }
    // принцип инкапсуляции тут в том, что я не могу зарядить оружие, я могу только стрелять, а оно само заряжается
    private bool _isLoaded;

    private void Reload()
    {
        Console.WriteLine("Loading...");

        _isLoaded = true;

        Console.WriteLine("Loaded!");
    }

    public void Shoot()
    {
        if (!_isLoaded)
        {
            Console.WriteLine("Weapon is not loaded!");
            Reload();
        }
        
        Console.WriteLine("Fire in the hole!");
        _isLoaded = false;
    }

}


class OOP
{
    public static void Incapsulation()
    {
        Console.WriteLine("First gun: \n");
        Gun gun = new Gun(isLoaded: true); // это конструктор класса 
        gun.Shoot();

        Console.WriteLine("\nSecond gun: \n");
        Gun gun2 = new Gun(); // использован перегруженный конструктор класса
        gun2.Shoot();
    }  
}