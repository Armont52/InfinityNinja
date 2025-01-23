using UnityEngine;
using System;

public class Timer
{
    private DateTime endTime;
    public bool isPaused;
    private TimeSpan remainingAtPause;
    
    public void Set(int minutes, int seconds)
    {
        isPaused = false;
        endTime = DateTime.Now.AddMinutes(minutes).AddSeconds(seconds);
    }

    public void Pause()
    {
        if (!isPaused)
        {
            isPaused = true;
            remainingAtPause = endTime - DateTime.Now;
        }
    }

    public void Resume()
    {
        if (isPaused)
        {
            isPaused = false;
            endTime = DateTime.Now.Add(remainingAtPause);
        }
    }

    public string GetTime()
    {
        TimeSpan remaining;
        if (isPaused)
        {
            remaining = remainingAtPause;
        }
        else
        {
            remaining = endTime - DateTime.Now;
        }

        return string.Format("{0:00}:{1:00}:{2:000}", 
            remaining.Minutes, 
            remaining.Seconds, 
            remaining.Milliseconds);
    }

    public bool IsFinished()
    {
        return DateTime.Now > endTime;
    }
}