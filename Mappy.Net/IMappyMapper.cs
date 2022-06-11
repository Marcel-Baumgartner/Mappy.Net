namespace Mappy.Net;

public interface IMappyMapper
{
    public T Map<T>(object data);
}