using System.ComponentModel;
using NyaaWrapper.Attributes;

namespace NyaaWrapper.Enumerators
{
    public enum Categories
    {
        [Name("All"), Uri("0_0")]
        All,
        
        // Anime Categories
        [Name("Anime"), Uri("1_0")]
        Anime,
        
        [Name("Anime Music Video"), Uri("1_1")]
        AnimeAMV,
        
        [Name("Anime English-Translated"), Uri("1_2")]
        AnimeEnglishTranslated,
        
        [Name("Anime Non-English-Translated"), Uri("1_3")]
        AnimeNonEnglishTranslated,
        
        [Name("Anime Raw"), Uri("1_4")]
        AnimeRaw,
        
        // Audio Categories
        [Name("Audio"), Uri("2_0")]
        Audio,
        
        [Name("Audio Lossless"), Uri("2_1")]
        AudioLossless,
        
        [Name("Audio Lossy"), Uri("2_2")]
        AudioLossy,

        // Literature Categories
        [Name("Literature"), Uri("3_0")]
        Literature,
        
        [Name("Literature English-Translated"), Uri("3_1")]
        LiteratureEnglishTranslated,

        [Name("Literature Non-English-Translated"), Uri("3_2")]
        LiteratureNonEnglishTranslated,

        [Name("Literature Raw"), Uri("3_3")]
        LiteratureRaw,

        // Live Action Categories
        [Name("Live Action"), Uri("4_0")]
        LiveAction,
        
        [Name("Live Action English-Translated"), Uri("4_1")]
        LiveActionEnglishTranslated,
        
        [Name("Live Action Idon/Promotional Video"), Uri("4_2")]
        LiveActionIdolPV,
        
        [Name("Live Action Non-English-Translated"), Uri("4_3")]
        LiveActionNonEnglishTranslated,
        
        [Name("Live Action Raw"), Uri("4_4")]
        LiveActionRaw,
        
        // Picture Categories
        [Name("Pictures"), Uri("5_0")]
        Pictures,
        
        [Name("Pictures Graphics"), Uri("5_1")]
        PicturesGraphics,
        
        [Name("Pictures Photos"), Uri("5_2")]
        PicturesPhotos,
        
        // Software Categories
        [Name("Software"), Uri("6_0")]
        Software,
        
        [Name("Software Application"), Uri("6_1")]
        SoftwareApplications,
        
        [Name("Software Games"), Uri("6_2")]
        SoftwareGames,
        
    }
}