using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using NyaaWrapper.Extensions;
using NyaaWrapper.Structures;
using NyaaWrapper.Utilities;

namespace NyaaWrapper
{
    public class Wrapper
    {
        private readonly IConfiguration config;

        public Wrapper(IConfiguration conf = null)
        {
            config = conf ?? Configuration.Default.WithDefaultLoader();
        }

        public async Task<List<NyaaTorrentStruct>> GetEntries(QueryOptions options)
        {
            options.Search = options.Search.Replace(" ", "+");
            IDocument document = await BrowsingContext.New(config).OpenAsync($"https://nyaa.si/?f={options.Filter.GetUri()}&c={options.Category.GetUri()}&q={options.Search}");
            List<NyaaTorrentStruct> torrents = new List<NyaaTorrentStruct>();
            IEnumerable<IElement> rows = document.QuerySelectorAll("tbody tr").Take(options.Amount != 0 ? options.Amount : 15);

            foreach (IElement row in rows)
            {
                var block = new List<string>();
                foreach (IElement td in row.Children.Where(m => m.LocalName == "td"))
                {
                    if (td.Children.Count(m => m.LocalName == "a") != 0)
                    {
                        foreach (IElement link in td.Children.Where(m => m.LocalName == "a"))
                        {
                            if (!link.GetAttribute("href").Contains("#comments"))
                            {
                                block.Add(link.GetAttribute("href"));
                            }
                        }
                    }

                    string temp = td.TextContent.Replace("\t", "").Replace("\n", "");
                    if (temp != "")
                    {
                        block.Add(temp);
                    }
                }

                torrents.Add(new NyaaTorrentStruct
                {
                    Category = StringUtilities.GetCategory(block[0]),
                    Id = int.Parse(block[1].Substring(6)),
                    Url = "https://nyaa.si" + block[1],
                    Name = block[2],
                    DownloadUrl = "https://nyaa.si" + block[3],
                    Magnet = block[4],
                    Size = block[5],
                    Date = block[6],
                    Seeders = int.Parse(block[7]),
                    Leechers = int.Parse(block[8]),
                    CompletedDownloads = int.Parse(block[9]),
                });
            }

            return torrents;
        }
    }
}