interface IServiceLocator
{
    ImessagingService GetMessageService();
}

class NotificationSystem
{
    private ImessagingService svc;

    public NotificationSystem(IServiceLocator locator) {    //Must return to ImessagingService
        svc = locator.GetMessageService();
    }

    public void InterestingEventHappened()
    {
        svc.SendMessage();
    }
}