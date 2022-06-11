using System.Reflection;

namespace Mappy.Net;

public class MappyMapper : IMappyMapper
{
    public T Map<T>(object data)
    {
        var type = typeof(T);
        var result = (T)Activator.CreateInstance(type)!;

        Dictionary<string, PropertyInfo> targetProps = new();
        foreach (var prop in type.GetProperties())
        {
            var formattedName = prop.Name.ToLower().Replace("_", "");
            
            targetProps.Add(formattedName, prop);
        }

        foreach (var dataProp in data.GetType().GetProperties())
        {
            var formattedName = dataProp.Name.ToLower().Replace("_", "");

            if (targetProps.ContainsKey(formattedName))
            {
                targetProps[formattedName].SetValue(result, dataProp.GetValue(data));
            }
        }

        return result;
    }
}