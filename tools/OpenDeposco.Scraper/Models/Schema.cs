namespace OpenDeposco.Scraper.Models;
internal class Schema
{
    public string FileName { get; set; } = null!;
    public string FileLink { get; set; } = null!;
    public string Size { get; set; } = null!;
    public string LastModified { get; set; } = null!;
    public string NameSpace { get; set; } = string.Empty;
    public List<string?> Imports { get; set; } = new List<string?>();
}
