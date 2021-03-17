using System;

public class MoodAnalyser1
{
    private string message;
    public MoodAnalyser1(string message)
    {
        this.message = message;
    }
    public MoodAnalyser1()
    {
    }
    public string analyseMoodLive1()
    {
        try
        {
            if (this.message.Equals(string.Empty))
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
            }
            if (this.message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
        catch (NullReferenceException)
        {
            throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
        }
    }
}

