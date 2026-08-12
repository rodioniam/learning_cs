namespace Learning_C_;


public static class AbstractClass
{
    public static void Result()
    {

        Weapon[] inventory = { new Spear(), new MachineGun() };
        Player player = new();

        foreach (var item in inventory)
        {
            player.CheckInfo(item);
            player.Fire(item);
            Console.WriteLine();
        }
    }
}


abstract class Weapon // абстрактный класс
{
    public abstract int Damage { get; } // абстрактное свойство
    public abstract void Use(); // реализацию абстрактного метода в абстрактном классе не пишут

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage: {Damage}");
    }
}


class Spear : Weapon
{
    public override int Damage { get { return 3; } } // реализация абстрактного свойства
    public override void Use() // реализация абстрактного метода из родительского класса
    {
        Console.WriteLine("Poke!");
    }
}

class MachineGun : Weapon
{
    public override int Damage { get { return 5; } }
    public override void Use()
    {
        Console.WriteLine("Tratatata!!!");
    }
}

class Player
{
    public void Fire(Weapon weapon)
    {
        // класс player может стрелять из всего что будет наследником абстрактного класса weapon
        weapon.Use();
    }

    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}