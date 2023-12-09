
namespace Lectia4;

public class Person : Being, ITalkable
{
    public enum Emotion
    {
        Happy,
        Sad,
        Angry,
        Scared,
        Panic
    }

    public int Age { get; set; }

    public void Talk()
    {
        Console.WriteLine("I am alive");
    }

    public override int GetMovementSpeed()
    {
        return 6;
    }

    //private string GetMovementSpeed() // Overloading does not care about return type, or access modifier
    //{
    //    return "6";
    //}

    public string GetMovementSpeed(Emotion emotion)
    {
        switch (emotion)
        {
            case Emotion.Happy:
            case Emotion.Sad:
                return GetMovementSpeed().ToString();
            case Emotion.Angry:
                return 10.ToString();
            case Emotion.Scared:
                return 13.ToString();
        }

        switch (emotion)
        {
            case Emotion.Happy:
            {
                int i = 1; // Only works inside curly brackets
                Console.WriteLine("Happy");
                break;
            }
            case Emotion.Sad:
            {
                int i = 2;// Only works inside curly brackets
                break;
            }
            case Emotion.Angry:
                break;
            case Emotion.Scared:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(emotion));
        }

        return 0.ToString();
    }

    public int GetMovementSpeed(int first, string second)
    {
        return GetMovementSpeed();
    }
    public int GetMovementSpeed(string first, int second)
    {
        return GetMovementSpeed();
    }

}