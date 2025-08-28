// File: MyLibTemplate/MyLibTemplate/TemplateServiceTest.cs
using Xunit;

using MyLibTemplate; // Add this if TemplateService is in MyLibTemplate namespace

namespace MyLibTemplate.Tests
{
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
            Assert.Equal("Hello from the template service !", result);
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
            Assert.Equal("Hello from the template service !", result);
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
            Assert.Equal("Hello from the template service !", result);
        }
    }
}