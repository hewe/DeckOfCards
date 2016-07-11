using System;
using System.Reflection;

namespace DeckOfCards.Utilities
{
    internal class DescriptionAttribute : Attribute
    {
        private string _description;

        public DescriptionAttribute(string description)
        {
            _description = description;
        }

        public override string ToString()
        {
            return _description;
        }
    }

    internal static class EnumToDescriptionStringExtension
    {
        internal static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = 
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.ToString();
        }
    }
}