﻿namespace NowwaitingSpotCrawler.Helpers;

/// <summary>
/// 
/// </summary>
public static class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} {message}");
    }
}
