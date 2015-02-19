﻿namespace CoC.Bot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
using CoC.Bot.PluginMngr;

    public static class GlobalVariables
    {
		public enum OutputStates { Normal, Information, Verified, Warning, Error }

        #region Properties

        internal static string AppPath
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        /// <summary>
        /// Gets the LogWriter.
        /// Note: All the messages in the Output are already logged.
        /// Use this if you need to only write to the log file skipping the Output.
        /// </summary>
        /// <value>The LogWriter.</value>
        internal static Tools.LogWriter Log
        {
            get { return Tools.LogWriter.Instance; }
        }

        internal static string LogPath
        {
            get { return Path.Combine(AppPath, "Logs"); }
        }

        internal static string ScreenshotZombieAttacked
        {
            get { return Path.Combine(AppPath, @"Screenshots\Zombies Attacked"); }
        }

        internal static string ScreenshotZombieSkipped
        {
            get { return Path.Combine(AppPath, @"Screenshots\Zombies Skipped"); }
        }

		internal static bool IsDebug { get; set; }

        #endregion

		//public static Bitmap hBitmap;
		//public static Bitmap hHBitmap;

		//public static IntPtr HWnD;

        //public static int hLogFileHandle;
        public static bool restart = false;
        public static bool runState = false;
        public static bool backgroundMode = true;

        public static bool fullArmy = false;

		public static PluginLoader PluginLoader { get; set; }
    }
}
