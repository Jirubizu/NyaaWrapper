namespace NyaaWrapper.Structures
{
    public class NyaaTorrentStruct
    {
        public string Category { get; set; }
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string Magnet { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public int Seeders { get; set; }
        public int Leechers { get; set; }
        public int CompletedDownloads { get; set; }
    }
}