// File: MyLibTemplate/MyLibTemplate/TemplateServiceTest.cs
using Xunit;

namespace MyLibTemplate.Tests
{
    // Minimal Person class for testing
    public class Person
    {
        public string Name { get; set; } = string.Empty;
    }

    public class TemplateServiceTest
    {
        [Fact]
        public void SayHello_WithValidPerson_ReturnsGreetingWithName()
        {
            // Arrange
            var service = new TemplateService();
            var person = new Person { Name = "Alice" };

            // Act
            var result = service.SayHello(person);

            // Assert
            Assert.Equal("Hello Alice from the template service !", result);
        }

        [Fact]
        public void SayHello_WithNullPerson_ReturnsGreetingWithEmptyName()
        {
            // Arrange
            var service = new TemplateService();

            // Act
            var result = service.SayHello(null);

            // Assert
            Assert.Equal("Hello  from the template service !", result);
        }

        [Fact]
        public void SayHello_WithEmptyName_ReturnsGreetingWithEmptyName()
        {
            // Arrange
            var service = new TemplateService();
            var person = new Person { Name = "" };

            // Act
            var result = service.SayHello(person);

            // Assert
            Assert.Equal("Hello  from the template service !", result);
        }

        [Fact]
        public void SayHello_WithWhitespaceName_ReturnsGreetingWithWhitespace()
        {
            // Arrange
            var service = new TemplateService();
            var person = new Person { Name = "   " };

            // Act
            var result = service.SayHello(person);

            // Assert
            Assert.Equal("Hello    from the template service !", result);
        }
    }
}