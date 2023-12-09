namespace Lectia4;

public sealed class Student : Person
{
    public override int GetMovementSpeed()
    {
        return 7;
    }
}

//public class SmartStudent : Student // Cannot derive from sealed class
//{

//}