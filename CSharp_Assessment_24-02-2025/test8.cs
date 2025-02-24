using System;
public interface IPlayable
{
    void Play();
}

public class MusicPlayer : Iplayable
{
       public void Play()
    {
        Console.WriteLine("Playing music");
    }
}

public class VideoPlayer : Iplayable
{
    public void Play()
    {
        Console.WriteLine("Playing video");
    }
}

public class MainClass
{
    public static void Main()
    {
        MusicPlayer mp = new MusicPlayer();
        VideoPlayer vp = new VideoPlayer();
        mp.Play();
        vp.Play();
    }
}