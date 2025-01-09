using Intrepion.HelloWorld.ConsoleProject;

namespace Intrepion.HelloWorld.ConsoleProject.UnitTests;

public class GreetingService_GreetingShould
{
    private const string ConsoleTest = "ConsoleTest";

    [Test]
    [NotInParallel(ConsoleTest)]
    [Arguments("Alice")]
    [Arguments("     Alice       ")]
    [Arguments("  Alice \n ")]
    [Arguments("    Alice \r  ")]
    [Arguments("\t\t\tAlice\t\t\t")]
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

    [Test]
    [NotInParallel(ConsoleTest)]
    [Arguments("Bob")]
    [Arguments("     Bob       ")]
    [Arguments("  Bob \n ")]
    [Arguments("    Bob \r  ")]
    [Arguments("\t\t\tBob\t\t\t")]
    public async Task BeHelloBob_GivenBob(string bob)
    {
        // Arrange
        var expected = "Hello, Bob!";
        var writer = new StringWriter();
        Console.SetOut(writer);
        var textReader = new StringReader(bob);
        Console.SetIn(textReader);

        // Act
        Greeter.GetName();
        var stringBuilder = writer.GetStringBuilder();
        var lines = stringBuilder.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

        // Assert
        await Assert.That(lines[1]).IsEqualTo(expected);
    }
}
