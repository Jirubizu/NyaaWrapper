using System;

namespace NyaaWrapper.Attributes
{
    public class UriAttribute : Attribute
    {
        protected string UriValue { get; set; }

        public virtual string Uri => UriValue;

        public UriAttribute(string uri)
        {
            UriValue = uri;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            NameAttribute other = obj as NameAttribute;
            return other != null && other.Name == Uri;
        }

        public override int GetHashCode() => Uri?.GetHashCode() ?? 0;
    }
}