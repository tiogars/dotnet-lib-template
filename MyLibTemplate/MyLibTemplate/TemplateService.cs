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
        return $"Hello {person?.Name ?? string.Empty} from the template service !";
    }
}
