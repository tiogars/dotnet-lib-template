using MyLibTemplate;

var person = new Person { Name = "Alice" };
var templateService = new TemplateService();
Console.WriteLine(templateService.SayHello(person));
