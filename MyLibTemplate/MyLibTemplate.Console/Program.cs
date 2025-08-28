using MyLibTemplate;

var templateService = new TemplateService();

string name = args.Length > 0 ? args[0] : string.Empty;

var service = new TemplateService();

var person = new Person { Name = name };

var greeting = service.SayHello(person);

Console.WriteLine(greeting);
