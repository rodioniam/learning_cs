namespace Learning_C_;


public static class InterfaceUpdate
{
    public static void Result()
    {

        Sword[] inventory = { new Dagger(), new GreatSword() };
        Knight knight = new();
        Box box = new();

        foreach (var item in inventory)
        {
            knight.CheckInfo(item);
            knight.Fire(item);
            Console.WriteLine();
        }
        knight.CheckInfo(box);
    }
}


interface IShowInfo
{
    public void ShowInfo();
}

interface ISword
{
    int Damage { get; }
    void Use();
}

abstract class Sword : IShowInfo, ISword
{
    public abstract int Damage { get; }
    public abstract void Use();

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage: {Damage}");
    }
}


class Dagger : Sword
{
    public override int Damage { get { return 3; } }
    public override void Use()
    {
        Console.WriteLine("Poke!");
    }
}

class GreatSword : Sword
{
    public override int Damage { get { return 5; } }
    public override void Use()
    {
        Console.WriteLine("Bdums!!!");
    }
}


class Box : IShowInfo
{
    public void ShowInfo()
    {
        Console.WriteLine("Box items: ");
    }
}

class Knight
{
    // рыцарь может использовать любой меч, который реализует интерфейс ISword
    // это удобно масштабировать, так как потом можно добавить новый тип оружия с реализованным тем же самым интерфейсом и не придется обновлять класс рыцаря
    public void Fire(ISword sword)
    {
        sword.Use();
    }

    // может смотреть информацию о любом предмете, который реализует интерфейс IShowInfo
    public void CheckInfo(IShowInfo item)
    {
        item.ShowInfo();
    }
}