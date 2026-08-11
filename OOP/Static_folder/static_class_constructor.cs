namespace Learning_C_;


public class StaticClassConstructor
{
    public static void Result()
    {
        // M.Func(); // или тут если вызвать первым
        M m1 = new(); // тут вызовется статический и обычный конструктор, а далее только обычный
        M m2 = new(); 
        M m3 = new();
        M m4 = new();
    }

    public static void DbExample()
    {
        DbRepository dbConnection = new();
        dbConnection.GetData();
    }
    
}


class M
{
    public M()
    {
        Console.WriteLine("Constructor");
    }

    static M() // модификаторы доступа в со статическими конструкторами не используются
    {
        Console.WriteLine("Static constructor");
    }

    public static void Func()
    {
        Console.WriteLine("Created");
    }
}

// пример с теоретическим подключением к датабазе
class DbRepository
    {
        private static string? connectionString;

        static DbRepository()
        {
            ConfigurationManager configurationManager = new();
            connectionString = configurationManager.GetConnectionString();
        }

        public void GetData()
        {
            Console.WriteLine("Connected to db: " + connectionString);
        }
    }

/*
Благодаря статическому конструктору объект соединения будет создан только один раз
В последствии каждое новое создание экземпляра с подключенной базой не потребует создания 
нового подключения, так как оно уже было создано первый раз при помощи статического конструктора
*/
class ConfigurationManager
{
    public string GetConnectionString()
    {
        return "local db";
    }
}