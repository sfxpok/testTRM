using System;
//using Android.OS;
using SQLite;
using System.IO;

public class Constants
{
    public static readonly string DbFilePath =
        Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "trm.db"
        );
}