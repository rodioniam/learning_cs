using System.Collections;

namespace Learning_C_;


public static class IteratorPattern
{
    public static void Result()
    {
        Build.Iterator();
    }
}


public class NumberSequence : IEnumerable<int> // это итерируемый объект
{
    private readonly int start;
    private readonly int count;

    public NumberSequence(int start, int count)
    {
        this.start = start;
        this.count = count;
    }

    // public IEnumerator<int> GetEnumerator() // при использовании yield это тоже не нужно
    // {
    //     return new NumberEnumerator(start, count);
    // }

    public IEnumerator<int> GetEnumerator() // это использование yield
    {
        for (int i = 0; i < count; i++)
        {
            yield return start + i;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() // реализация non-generic метода
    {
        return GetEnumerator();
    }
}

// весь этот класс можно заменить на метод с yield
// public class NumberEnumerator : IEnumerator<int> // это итератор
// {
//     private readonly int start;
//     private readonly int count;
//     private int currentIndex;

//     public NumberEnumerator(int start, int count)
//     {
//         this.start = start;
//         this.count = count;
//         currentIndex = -1; // счетчик для движения вперед
//     }

//     public int Current
//     {
//         get
//         {
//             if (currentIndex < 0 || currentIndex >= count)
//             {
//                 throw new InvalidOperationException("Enumerator is in an invalid state");
//             }
//             return start + currentIndex;
//         }
//     }

//     object IEnumerator.Current => Current; // делегирование non generic метода в generic

//     public bool MoveNext()
//     {
//         if (currentIndex + 1 < count)
//         {
//             currentIndex ++;
//             return true;
//         }
//         return false;
//     }

//     public void Reset()
//     {
//         currentIndex = -1;
//     }

//     public void Dispose()
//     {
        
//     }
// }

static class Build
{
    public static void Iterator()
    {
        IEnumerable<int> sequence = new NumberSequence(start: 20, count: 5);

        // /*
        // цикл foreach при начале работы вызывает метод GetEnumerator у итерируемого объекта, который в свою очеред вызывает итератор
        // далее он по очередно вызывает Current и MoveNext. Как только MoveNext вернет false он закончит работу
        // */
        // // foreach (var number in sequence)
        // // {
        // //     Console.WriteLine(number);
        // // }

        var enumerator = sequence.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        Console.WriteLine();

        foreach (var worker in Worker.GetWorkersByYield())
        {
            Console.WriteLine(worker.Name);
        }
    }
}

public class Worker
{
    public required string Name { get; set; }

    // метод-итератор у итерируемого объекта который возвращает по одному объекту
    public static IEnumerable<Worker> GetWorkersByYield() // тут только в момент когда код доходит до yield
    {
        yield return new Worker { Name = "John" };
        yield return new Worker { Name = "Marry" };
        yield return new Worker { Name = "Dillon" };
        yield break;
        // yield return new Worker { Name = "Looser" }; // прерывает код
    }

    public static IEnumerable<Worker> GetWorkers() // тут происходит создание всех объектов и их возвращение сразу
    {
        return
        [
            new Worker { Name = "John" },
            new Worker { Name = "Marry" },
            new Worker { Name = "Dillon" }
        ];
    }
}
