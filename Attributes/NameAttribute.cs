using System;

namespace NyaaWrapper.Attributes
{
    public class NameAttribute : Attribute
    {
        protected string NameValue { get; set; }

        public virtual string Name => NameValue;

        public NameAttribute(string name)
        {
            NameValue = name;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            NameAttribute other = obj as NameAttribute;
            return other != null && other.Name == Name;
        }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    }
}