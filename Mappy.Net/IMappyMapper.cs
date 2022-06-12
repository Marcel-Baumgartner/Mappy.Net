namespace Mappy.Net;

public interface IMappyMapper
{
    public T Map<T>(object data);
    public T Map<T>(T source, object data);
}