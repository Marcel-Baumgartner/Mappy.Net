namespace Mappy.Net;

public class Mapper
{
    public static IMappyMapper DefaultMapper { get; set; } = new MappyMapper();

    public static T Map<T>(object data)
    {
        return DefaultMapper.Map<T>(data);
    }

    public static T Map<T>(T source, object data)
    {
        return DefaultMapper.Map<T>(source, data);
    }
}