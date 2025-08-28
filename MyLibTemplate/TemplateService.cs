namespace MyLibTemplate;

/// <summary>
/// Provides template-related services.
/// </summary>
public class TemplateService
{
    /// <summary>
    /// Returns a greeting message for the specified person.
    /// </summary>
    /// <param name="person">The person to greet. If null, an empty name is used.</param>
    /// <returns>A greeting message including the person's name.</returns>
    public string SayHello(Person? person)
    {
        string personName = string.Empty;
        if (person != null && !string.IsNullOrWhiteSpace(person.Name))
        {
            personName = person.Name.Trim() + " ";
        }
        return $"Hello {personName}from the template service !";
    }
}
