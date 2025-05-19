
using DalApi;
using DalXml;
using DO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{
    string filePath = @"..\xml\sales.xml";
    public int Create(Sale item)
    {
        XElement xElement=XElement.Load(filePath);
        XElement sale = new XElement("sale");
        int id = Config.SaleCode;
        item = item with { Id = id };
        FieldInfo[] fields = item.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
        foreach (FieldInfo field in fields)
        {
            string fieldName = field.Name;
            if (fieldName.StartsWith("<") && fieldName.Contains(">"))
            {
                int startIndex = fieldName.IndexOf('<') + 1;
                int endIndex = fieldName.IndexOf('>');
                fieldName = fieldName.Substring(startIndex, endIndex - startIndex);
            }

            Console.WriteLine(fieldName); // הדפס את שם השדה
            if (field.GetValue(item) != null)
                sale.Add(new XElement(fieldName, field.GetValue(item)));
        }
          
        xElement.Add(sale);
        xElement.Save(filePath);
        return id;
    }

    public void Delete(int id)
    {
        XElement xElement = new XElement("ArrayOfSale");
        xElement.Elements().FirstOrDefault(s=>int.Parse(s.Element("Id").Value) == id).Remove();
        xElement.Save(filePath);
    }

    public Sale? Read(int id)
    {
        XElement xElement = new XElement("ArrayOfSale");
        XElement sale = xElement.Elements().FirstOrDefault(s => int.Parse(s.Element("Id").Value) == id);
        return new Sale()
        {
            Id = int.Parse(sale.Element("Id").Value),
            Begin = DateOnly.Parse(sale.Element("Begin").Value),
            End = DateOnly.Parse(sale.Element("End").Value),
            IsForClub = bool.Parse(sale.Element("IsForClub").Value),
            ProductId = int.Parse(sale.Element("IsForClub").Value),
            MinAmount = int.Parse(sale.Element("MinAmount").Value),
            SalePrice = double.Parse(sale.Element("SalePrice").Value)
        };
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        XElement xElement = new XElement("ArrayOfSale");
        return ReadAll(filter).First();
    }
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        XElement xElement = new XElement("ArrayOfSale");
        List<Sale> list = new List<Sale>();
        list = xElement.Elements().Select(x=>new Sale()
        {
            Id = int.Parse(x.Element("Id").Value),
            Begin = DateOnly.Parse(x.Element("Begin").Value),
            End = DateOnly.Parse(x.Element("End").Value),
            IsForClub = bool.Parse(x.Element("IsForClub").Value),
            ProductId = int.Parse(x.Element("IsForClub").Value),
            MinAmount = int.Parse(x.Element("MinAmount").Value),
            SalePrice = double.Parse(x.Element("SalePrice").Value)
        }).Where(filter).ToList();
        return list;
    }
    public void Update(Sale item)
    {
        Delete(item.Id);
        XElement xElement = new XElement("ArrayOfSale");
        XElement sale = new XElement("sale");
        FieldInfo[] fields = item.GetType().GetFields();
        foreach (FieldInfo field in fields)
            sale.Add(new XElement(field.Name, field.GetValue(item)));
        xElement.Add(sale);
        xElement.Save(filePath);
    }
}
