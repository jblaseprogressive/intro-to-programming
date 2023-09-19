namespace CSharpNotes.Types;
public class DeclaringLocalVariables
{
    [Fact]
    public void ExplicitlyTypedLocalVariable()
    {
        // Type identifier [= value]
        int a = 0;
        int b = 2;

        string dogName = "Rover";

        Assert.Equal("Rover", dogName);

        Assert.Equal(0, a);
        Assert.Equal(2, b);

    }

    [Fact]
    public void ImplicitlyTypedLocalVariablesWithVar()
    {
        var a = 0;
        var b = 1.0;
        var c = "Cat";
        var d = 'A';
        var e = true;
        var salary = 80123.23M; //adding M makes it decimal!

        var rover = new Dog();
    }

    [Fact]
    public void ImplicitlyTypedlocalVariablesWithNew()
    {
        // .NET 5
        Dog rover = new();
    }
}

public class Dog { }