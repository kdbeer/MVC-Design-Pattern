public interface IServiceLocator
{
    object GetService(Type serviceType);
}

public class NotificationSystem
{
    private IMessagingService svc;
    public NotificationSystem(IServiceLocator locator) {
        svc = (IMessagingService) locator.GetService(typeOf(ImessagingService));
    }

    public void InterestingEventHappened()
    {
        svc.SendMessage();
    }
}