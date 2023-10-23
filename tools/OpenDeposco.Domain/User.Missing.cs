using System.Runtime.Serialization;
namespace User;
public partial class UserType
{
    [DataMember(Name = "businessUnit")]
    [System.Xml.Serialization.XmlElementAttribute("businessUnit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? BusinessUnit { get; set; }

    [DataMember(Name = "companyName")]
    [System.Xml.Serialization.XmlElementAttribute("companyName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? CompanyName { get; set; }

    [DataMember(Name = "facility")]
    [System.Xml.Serialization.XmlElementAttribute("facility", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Facility { get; set; }

    [DataMember(Name = "organization")]
    [System.Xml.Serialization.XmlElementAttribute("organization", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Organization { get; set; }

    [DataMember(Name = "password")]
    [System.Xml.Serialization.XmlElementAttribute("password", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Password { get; set; }

    [DataMember(Name = "active")]
    [System.Xml.Serialization.XmlElementAttribute("active", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Active { get; set; }

    [DataMember(Name = "handheldMenu")]
    [System.Xml.Serialization.XmlElementAttribute("handheldMenu", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? HandheldMenu { get; set; }

    [DataMember(Name = "title")]
    [System.Xml.Serialization.XmlElementAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Title { get; set; }

    [DataMember(Name = "employeeNumber")]
    [System.Xml.Serialization.XmlElementAttribute("employeeNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? EmployeeNumber { get; set; }

    [DataMember(Name = "type")]
    [System.Xml.Serialization.XmlElementAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Type { get; set; }

    [DataMember(Name = "department")]
    [System.Xml.Serialization.XmlElementAttribute("department", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Department { get; set; }

    [DataMember(Name = "division")]
    [System.Xml.Serialization.XmlElementAttribute("division", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Division { get; set; }

    [DataMember(Name = "address")]
    [System.Xml.Serialization.XmlElementAttribute("address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Address { get; set; }

    [DataMember(Name = "city")]
    [System.Xml.Serialization.XmlElementAttribute("city", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? City { get; set; }

    [DataMember(Name = "state")]
    [System.Xml.Serialization.XmlElementAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? State { get; set; }

    [DataMember(Name = "country")]
    [System.Xml.Serialization.XmlElementAttribute("country", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Country { get; set; }

    [DataMember(Name = "zip")]
    [System.Xml.Serialization.XmlElementAttribute("zip", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Zip { get; set; }

    [DataMember(Name = "timeZone")]
    [System.Xml.Serialization.XmlElementAttribute("timeZone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? TimeZone { get; set; }

    [DataMember(Name = "language")]
    [System.Xml.Serialization.XmlElementAttribute("language", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Language { get; set; }

    [DataMember(Name = "phone")]
    [System.Xml.Serialization.XmlElementAttribute("phone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Phone { get; set; }

    [DataMember(Name = "mobile")]
    [System.Xml.Serialization.XmlElementAttribute("mobile", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Mobile { get; set; }

    [DataMember(Name = "fax")]
    [System.Xml.Serialization.XmlElementAttribute("fax", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string? Fax { get; set; }
}
