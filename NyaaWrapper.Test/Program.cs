using System;
using System.Collections.Generic;
using System.Text;
using NyaaWrapper.Structures;

namespace NyaaWrapper.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper nyaaWrapper = new();
            List<NyaaTorrentStruct> animeResults =
                nyaaWrapper.GetNyaaEntries(new QueryOptions {Search = "kimetsu no yaiba"}).Result;

            string animeResultsDisplay = GenerateOutString(animeResults);
            Console.WriteLine(animeResultsDisplay);
            
            List<NyaaTorrentStruct> sukeibeiResults =
                nyaaWrapper.GetSukebeiEntries(new QueryOptions {Search = "jav"}).Result;
            
            string sukeibeiGenerateOutString = GenerateOutString(sukeibeiResults);
            Console.WriteLine(sukeibeiGenerateOutString);
        }

        static string GenerateOutString(List<NyaaTorrentStruct> torrents)
        {
            StringBuilder stringBuilder = new();
            foreach (NyaaTorrentStruct torrent in torrents)
            {
                stringBuilder.AppendLine($"Name: {torrent.Name}");
                stringBuilder.AppendLine($"Id: {torrent.Id}");
                stringBuilder.AppendLine($"Category: {torrent.Category}");
                stringBuilder.AppendLine($"URL: {torrent.Url}");
                stringBuilder.AppendLine($"Download URL: {torrent.DownloadUrl}");
                stringBuilder.AppendLine($"Magnet: {torrent.Magnet}");
                stringBuilder.AppendLine($"Size: {torrent.Size}");
                stringBuilder.AppendLine($"Date: {torrent.Date}");
                stringBuilder.AppendLine($"Seeders: {torrent.Seeders}");
                stringBuilder.AppendLine($"Leechers: {torrent.Leechers}");
                stringBuilder.AppendLine($"Completed Downloads: {torrent.CompletedDownloads}");
                stringBuilder.AppendLine("----------------------------------------");
            }

            return stringBuilder.ToString();
        }
    }
}