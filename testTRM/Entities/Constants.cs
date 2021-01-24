using System;
using System.IO;

public class Constants
{
    public static readonly string db_path =
        Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "trm.db"
        );
}