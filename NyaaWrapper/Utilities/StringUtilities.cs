using System.Collections.Generic;
using NyaaWrapper.Structures;

namespace NyaaWrapper.Utilities
{
    internal static class StringUtilities
    
    {
        public static string GetCategory(string catUri)
        {
            string[] cats = catUri.Replace("/?c=","").Split("_");
            
            List<CategoryStruct> catList = new List<CategoryStruct>
            {
                new CategoryStruct {Name = "Anime", Subs = new []{"Anime Music Video", "English-translated", "Non-English-translated", "Raw"}},
                new CategoryStruct {Name = "Audio", Subs = new []{"Lossless", "Lossy"}},
                new CategoryStruct {Name = "Literature", Subs = new []{"English-translated", "Non-English-translated", "Raw"}},
                new CategoryStruct {Name = "Live Action", Subs = new []{"English-translated", "Idol/Promotional Video", "Non-English-translated", "Raw"}},
                new CategoryStruct {Name = "Pictures", Subs = new []{"Graphics", "Photos"}},
                new CategoryStruct {Name = "Software", Subs = new []{"Applications", "Games"}}
            };

            return $"{catList[int.Parse(cats[0])-1].Name} - {catList[int.Parse(cats[0])-1].Subs[int.Parse(cats[1])-1]}";
        }
    }
}