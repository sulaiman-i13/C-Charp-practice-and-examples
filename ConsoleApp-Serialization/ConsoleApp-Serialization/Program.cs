using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
#region Employee
Employee emp = new Employee
{
	Id = 13,
	Name = "Sulaiman Ibrahem Ismaeel",
	Benefits = new List<string> { "pension", "health insurance" },
};
#endregion

#region toXml
//void objectToXml()
//{
//	var xmlSerializer = new XmlSerializer(typeof(Employee));
//	using(var sw=new StringWriter())
//	{
//		xmlSerializer.Serialize(sw, emp);
//        Console.WriteLine(sw.ToString());
//		File.WriteAllText(Environment.CurrentDirectory + @"\data\my_xml.xml", sw.ToString());

//    }
//}
//objectToXml();
#endregion

#region fromXml
//void employeeFromXml()
//{
//	Employee employee;
//	var xmlSerializer = new XmlSerializer(typeof(Employee));
//	var content = File.ReadAllText(Environment.CurrentDirectory + "\\data\\my_xml.xml");
//	using(var reader=new StringReader(content))
//	{
//		employee = xmlSerializer.Deserialize(reader) as Employee;
//		Console.
//			WriteLine($"{employee.Id}-{employee.Name}-{employee.Benefits[0]}-{employee.Benefits[1]}");
//    }
//}
//employeeFromXml();
#endregion

#region toJson
//File.WriteAllText(	Environment.CurrentDirectory + "\\data\\my_json.json",	JsonSerializer
//	.Serialize<Employee>(emp, new JsonSerializerOptions { WriteIndented = true }));
#endregion

#region fromJson
//var employee =JsonSerializer.Deserialize<Employee>(File.ReadAllText(Environment.CurrentDirectory + "\\data\\my_json.json"));
//Console.WriteLine($"{employee.Id}-{employee.Name}-{employee.Benefits[0]}-{employee.Benefits[1]}");

#endregion

