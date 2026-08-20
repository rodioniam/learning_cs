// namespace Learning_C_;

/*
в этом коде есть недочеты, которые исправляет использование event

1 -- Можно вызват делегат напрямую извне - нарушение инкапсуляции
2 -- Можно выполнить полный сброс подписчиков делегата

*/


public static class EventsPatternObserver
{
    public static void Example()
    {
        // создается объект делегата
        var publisher = new MessagePublisher(); 

        // создаются объекты наблюдателей
        var smsSubscriber = new SmsSubscriber(); 
        var emailSubscriber = new EmailSubscriber(); 

        // подписка методов на делегат
        publisher.OnNotify += smsSubscriber.RecieveSms; 
        publisher.OnNotify += emailSubscriber.RecieveEmail;

        // publisher.OnNotify.Invoke("Direct invocation"); // недочет №1
        // publisher.OnNotify = null; // недочет №2

        publisher.RaiseEvent("Hello World!");
        Console.WriteLine();
    }

}

public delegate void Notify(string message);
// внутри этого метода происходит вызов делегата, на который подписано несколько методов
class MessagePublisher
{
    // public Notify? OnNotify; 
    public event Notify? OnNotify; // объявление event фиксит все недочеты
    // Использование `event` ограничивает работу с делегатом только подписками и отписками

    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message); // проверка что делегат не null -- если на делегат никто не подписан не будет ошибки.
    }
}

// наблюдатель -- главное чтобы сигнатура метода подходила делегату
class SmsSubscriber
{
    public void RecieveSms(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

class EmailSubscriber
{
    public void RecieveEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}