using HtmlAgilityPack;
using OpenDeposco.Scraper.Models;

namespace OpenDeposco.Scraper;

static internal class LiveDocumentService
{
    /// <summary>
    /// Get the contents of the Schemas for the REST API
    /// </summary>
    /// <param name="code">The code of your company/organization/sub-domain</param>
    /// <returns></returns>
    static internal List<Schema> GetSchemas (string code)
    {
        string url = $"https://{code}-ua.deposco.com/schema/";
        var web = new HtmlWeb();
        var doc = web.Load(url);

        // Find the table element you want to convert to the Schema object.
        var table = doc.DocumentNode.SelectSingleNode("//table") ?? throw new Exception("Table not found at link");

        // Create a list to store the table data as objects.
        var schemaList = new List<Schema>();

        // Iterate through the table rows skipping the header row.
        var rows = table.SelectNodes(".//tr[position() > 1]");
        if (rows != null)
        {
            foreach (var row in rows)
            {
                var columns = row.SelectNodes(".//td");
                if (columns != null && columns.Count >= 3)
                {
                    var anchorElement = columns[0].SelectSingleNode(".//a");
                    if (anchorElement == null)
                        continue;
                    var anchorLink = anchorElement.GetAttributeValue("href", ""); // Extract the href attribute.
                    var anchorText = anchorElement.InnerText; // Extract the inner text.
                    var item = new Schema
                    {
                        FileName = anchorText,
                        FileLink = anchorLink,
                        Size = columns[1].InnerText,
                        LastModified = columns[2].InnerText
                    };
                    schemaList.Add(item);
                }
            }
        }

        return schemaList;
    }
}
