
namespace Lectia4;

public abstract class Being
{
    private static int _count = 0;
    private int _id;

    public int Id {  get { return _id; } }

    public Being()
    {
        _count++;
        _id = _count;
    }

    public abstract int GetMovementSpeed();
}
