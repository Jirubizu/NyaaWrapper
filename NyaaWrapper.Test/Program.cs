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
            List<NyaaTorrentStruct> entries =
                nyaaWrapper.GetEntries(new QueryOptions {Search = "kimetsu no yaiba"}).Result;
            StringBuilder stringBuilder = new();
            foreach (NyaaTorrentStruct torrent in entries)
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
            Console.WriteLine(stringBuilder);
        }
    }
}