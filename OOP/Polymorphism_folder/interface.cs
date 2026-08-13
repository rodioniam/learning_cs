using System.Data;

namespace Learning_C_;

/*
Например, нужно два класса - один вытягивает данные из базы данных, а второй их обрабатывает (выводит на консоль)
И появляется необходимость вытягивать данные не только из базы данных, а еще из файлов, API запросов и тд.
Упростить решение этой задачи может правильное объявление логики через интерфейс,
для каждого нового источника информации просто адаптировать соответствующий класс
*/
public static class Interface
{
    public static void Result()
    {
        IDataProcessor dataProcessor = new ConsoleDataProcessor();

        dataProcessor.ProcessData(new DbDataProvider()); // в зависимости от того какой класс будет передан будет вызван тот или иной метод
        dataProcessor.ProcessData(new FileDataProvider());
        dataProcessor.ProcessData(new APIDataProvider());
    }
}


interface IDataProvider // так объявляется интерфейс, в названии принято добавлять букву I
{
    string GetData();
}

interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}


// обработчик данных (вывод на консоль)
class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider) // реализация классом интерфейса
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

// приемка данных из базы данных
class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from database";
    }
}

// приемка данных из файлов
class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from file";
    }
}

// приемка данных по API
class APIDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from API request";
    }
}