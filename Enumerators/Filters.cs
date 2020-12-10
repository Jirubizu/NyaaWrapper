using NyaaWrapper.Attributes;

namespace NyaaWrapper.Enumerators
{
    public enum Filters
    {
        [Name("No Filter"), Uri("0")]
        NoFilter,
        
        [Name("No Remarks"), Uri("1")]
        NoRemarks,
        
        [Name("Trusted Only"), Uri("2")]
        TrustedOnly,
    }
}