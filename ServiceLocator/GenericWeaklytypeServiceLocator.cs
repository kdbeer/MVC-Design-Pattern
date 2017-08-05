public interface IServiceLocator
{
    object GetService(Type serviceType);
    TServiec GetService<TServiec>();
}

public class NotificationSystem(IServiceLocator locator)
{
    private ImeassageService svc;

    public NotificationSystem(IServiceLocator locator) {
        svc = locator.GetService<ImeassageService>();
    }

    public void InterestingEventHappened()
    {
        svc.SendMessage();
    }
}