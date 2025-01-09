using Intrepion.HelloWorld.ConsoleProject;

namespace Intrepion.HelloWorld.ConsoleProject.UnitTests;

public class GreetingService_GreetingShould
{
    [Test]
    public async Task BeHelloAlice_GivenAlice()
    {
        // Arrange
        var expected = "Hello, Alice!";
        var writer = new StringWriter();
        Console.SetOut(writer);
        var textReader = new StringReader("Alice");
        Console.SetIn(textReader);

        // Act
        Greeter.GetName();
        var stringBuilder = writer.GetStringBuilder();
        var lines = stringBuilder.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

        // Assert
        await Assert.That(lines[1]).IsEqualTo(expected);
    }
}
