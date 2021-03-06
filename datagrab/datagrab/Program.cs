using Microsoft.Xna.Framework;
using System;
using System.IO;
using System.Reflection;

namespace datagrab
{
#if WINDOWS || XBOX
    static class Program
    {
        public static string WORKING_FOLDER;
        public static string CONTENT_PATH;
        public static string VERSION_NUMBER;
        public static int REVISION_NUMBER;
        public static int PROJECT_NUMBER;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">
        ///     <string>WORKING_FOLDER</string>
        ///     <string>VERSION_NUMBER</string>
        ///     <string>PROJECT_NUMBER</string>
        ///     <string>REVISION_NUMBER</string>
        /// </param>
        static void Main(string[] args)
        {
            WORKING_FOLDER = args[0];
            VERSION_NUMBER = args[1];
            PROJECT_NUMBER = int.Parse(args[2]);
            REVISION_NUMBER = int.Parse(args[3]);
            CONTENT_PATH = WORKING_FOLDER + @"\Content";
            Directory.SetCurrentDirectory(WORKING_FOLDER);
            var terraGrab = Assembly.GetExecutingAssembly().GetType("datagrab.Hook", true, true);
            ((Game)Activator.CreateInstance(terraGrab)).Run();
        }
    }
#endif
}

