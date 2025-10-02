using System.ComponentModel;
using System.Reflection;

namespace HealthInsuranceInquiry.Application.Helper;

public static class EnumHelper
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute != null ? attribute.Description : value.ToString();
    }

    public static TEnum GetEnumFromId<TEnum>(int id) where TEnum : Enum
    {
        foreach (var value in Enum.GetValues(typeof(TEnum)))
        {
            if ((int)value == id)
            {
                return (TEnum)value;
            }
        }

        throw new ArgumentException($"No matching value found in {typeof(TEnum).Name} for id {id}.");
    }
}
