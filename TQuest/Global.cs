﻿using System;
using System.IO;

namespace TQuest
{
    class Global
    {
        public static string title = "[ TQuest ]";
        public static string textv = "═";
        public static string texth = "║";
        public static string spath = Directory.GetCurrentDirectory() + "\\common\\saves.ini";
        public static string settingspath = Directory.GetCurrentDirectory() + "\\common\\settings.ini";
    }
}
