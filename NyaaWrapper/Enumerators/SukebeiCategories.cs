using NyaaWrapper.Attributes;

namespace NyaaWrapper.Enumerators
{
    public enum SukebeiCategories
    {
        [Name("All"), Uri("0_0")]
        All,
        
        // Art Categories
        [Name("Art"), Uri("1_0")]
        Art,
        [Name("Anime"), Uri("1_1")]
        Anime,
        [Name("Doujinshi"), Uri("1_2")]
        Doujinshi,
        [Name("Games"), Uri("1_3")]
        Games,
        [Name("Manga"), Uri("1_4")]
        Manga,
        [Name("Pictures"), Uri("1_5")]
        Pictures,
        
        // Real life categories
        [Name("Real Life"), Uri("2_0")]
        RealLife,
        [Name("Photobooks and Pictures"), Uri("2_1")]
        PhotobooksAndPictures,
        [Name("Videos"), Uri("2_2")]
        Videos
    }
}