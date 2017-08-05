public interface IServiceLocator
{
    object GetService(Type serviceType);
}

public class NotificationSystem
{
    public static Tservice GetService<Tservice>(this IServiceLocator locator) {
        return (Tservice) locator.GetService(typeOf(Tservice));
    }    
}