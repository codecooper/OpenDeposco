using System.Xml.Serialization;

namespace OpenDeposco;
public partial class AddressType
{
    [XmlIgnore]
    public IDictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
}
