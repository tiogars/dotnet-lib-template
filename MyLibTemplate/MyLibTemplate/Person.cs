using System.Diagnostics.CodeAnalysis;

namespace MyLibTemplate;

public class Person
{
    [NotNull]
    public string? Name { get; set; }
}