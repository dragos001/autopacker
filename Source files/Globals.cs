using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
    class Globals
    {
        public static string ServerURL = "http://autopatcher.metin2rising.ro/patch/";
        public static string PatchlistName  = "patchlist.txt";
        public static string Arguments      = "--4Hby^^Z5R321##!nXe9H6&GFyDDMG*!#";
        public static string BinaryName     = "Metin2Rising.exe";
		
		
        public static pForm pForm;

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long fullSize;
        public static long completeSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}
