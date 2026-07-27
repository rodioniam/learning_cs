using System.Linq; // как будто недавно стало не обязательно


namespace Learning_C_;

public static class WorkingWithArrays
{
    public static void Test()
    {
        // различные типичные задачи с массивами
        int[] myArray = {111, 45, 2, 987, 23, 2, 76, 9};

        int maxValue = myArray.Max();
        int minValue = myArray.Min();

        Console.WriteLine(maxValue);
        Console.WriteLine(minValue);
        
        // в скобочках после Where идет лямбда выражение
        int evenNumsSum = myArray.Where(i => i % 2 == 0).Sum();

        // поиск уникальных значений в массиве
        // пример того что получаю объект метода и нужно конвертировать его в массив.
        int[] uniqueValues = myArray.Distinct().ToArray();

        Console.WriteLine(evenNumsSum);
        // для того чтобы увидеть массив нужно конвертировать его в строку и указать разделитель
        Console.WriteLine(string.Join(',', uniqueValues));

        // сортировка массива 
        int[] orderedArray = myArray.OrderBy(i => i).ToArray();
        Array.Sort(myArray); // данный способ отсортирует массив in place
        Console.WriteLine(string.Join(',', myArray)); // будет уже отсортированный
        Console.WriteLine(string.Join(',', orderedArray));

        // часто используемый метод Find найдет и вернет первый подходящий под условие элемент массива
        int findFirstElement = Array.Find(myArray, i => i < 70);
        // тоже самое но ищет с конца
        int findLastElement = Array.Find(myArray, i => i < 70);
        // возвращает массив элементов, подходящих под условие
        int [] findAll = Array.FindAll(myArray, i => i < 70);
        // возвращает индекс элемента в массиве
        int valueIndex = Array.FindIndex(myArray, i => i == 2);
        // есть FindLastIndex - будет искать с конца
        int valueIndexEnd = Array.FindLastIndex(myArray, i => i == 2);
        Console.WriteLine(findFirstElement);
        Console.WriteLine(findLastElement);
        Console.WriteLine(string.Join(',', findAll));
        Console.WriteLine(valueIndex); // можно увидеть что индекс уже отсортированного вида массива
        Console.WriteLine(valueIndexEnd);

        // массив в обратном порядке
        Array.Reverse(myArray);
        Console.WriteLine(string.Join(',', myArray));


        // использование методов Linq удобнее, так как может давать exception
        int findFirstElementLinq = myArray.Where(i => i < 70).First();
        Console.WriteLine(findFirstElementLinq);


        // способ сформировать массив из другого массива при помощи срезов
        int[] firstArray = {1, 2, 3, 4, 5, 6, 7};
        // с первого индекса по третий (с 1 по 3 элемент) так как последний не включается
        int[] secondArray = firstArray[0..3];
        // можно опускать один из указателей 
        // - без первого = с первого элемента
        // - без второго = по последний
        Console.WriteLine(string.Join(',', secondArray));

    }
}