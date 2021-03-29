using NyaaWrapper.Enumerators;

namespace NyaaWrapper
{
    public class QueryOptions
    {
        public string Search { get; set; } = "";
        public int Amount { get; set; } = 0;
        public Categories Category { get; set; } = Categories.All;
        public Filters Filter { get; set; } = Filters.NoFilter;
    }
}