using Intrepion.HelloWorld.ConsoleProject;

namespace Intrepion.HelloWorld.ConsoleProject.UnitTests;

public class GreetingService_GreetingShould
{
    [Test]
    [Arguments("Alice")]
    public async Task BeHelloAlice_GivenAlice(string alice)
    {
        // Arrange
        var expected = "Hello, Alice!";
        var writer = new StringWriter();
        Console.SetOut(writer);
        var textReader = new StringReader(alice);
        Console.SetIn(textReader);

        // Act
        Greeter.GetName();
        var stringBuilder = writer.GetStringBuilder();
        var lines = stringBuilder.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

        // Assert
        await Assert.That(lines[1]).IsEqualTo(expected);
    }
}
