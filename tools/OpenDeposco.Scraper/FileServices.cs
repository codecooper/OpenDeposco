using System.Text.Json;

namespace OpenDeposco.Scraper;
static internal class FileServices
{
    public static void SaveToDisk(this object content, string filePath)
    {
        var options = new JsonSerializerOptions() {  WriteIndented = true };
        var json = JsonSerializer.Serialize(content, options: options);
        File.WriteAllText(filePath, json);
    }
}
