using System;
using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
    class Texts
    {
        private static Dictionary<string, string> Text = new Dictionary<string, string>
        {
            {"UNKNOWNERROR",                    "O necunoscută, dar o eroare critică a avut loc .. Mesaj de eroare care poate ajuta la rezolvarea problemei: \n{0}"},
            {"MISSINGBINARY",                   "Nu pot porni jocul, nu gasesc {0}."},
            {"ARGUMENTBINARY",                   "ARGUMENT, nu gasesc {0}."},
            {"CANNOTSTART",                     "Nu se poate porni jocul, probabil pentru că, antivirusul dvs., vă rugăm să îl opresti."},
            {"NONETWORK",                       "Nu se poate conecta la server, verificați setările de rețea și încercați din nou."},
            {"CONNECTING",                      "Asteapta, Scanez fisierele noi, poate dura pana la 2 minute scanarea."},
            {"LISTDOWNLOAD",                    "Descarc patchlist..."},
            {"CHECKFILE",                       "{0} Verific fisierele..."},
            {"DOWNLOADFILE",                    "{0} descarc... {1}/ {2}"},
            {"COMPLETEPROGRESS",                "Descarcarea Totala : {0}%"},
            {"CURRENTPROGRESS",                 "Descarc fisiere: {0}%  |  {1} kb/s"},
            {"CHECKCOMPLETE",                   "De fiecare data fisierele sunt scanate apoi descarcate."},
            {"DOWNLOADCOMPLETE",                "Toate fisierele necesare au fost descarcate."},
            {"DOWNLOADSPEED",                   "{0} kb/s"}
        };

        public static string GetText(string Key, params object[] Arguments)
        {
            foreach (var currentItem in Text)
            {
                if(currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments); 
                }
            }

            return null;
        }
    }
}
