using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PotPatch
{
    class PotHelper
    {
        public static string[] Combine(string translatedPath, string untranslatedPath)
        {
            Dictionary<string, string> translations = GetTranslations(File.ReadAllLines(translatedPath, Encoding.UTF8));
            string[] combinedLines = Translate(File.ReadAllLines(untranslatedPath, Encoding.UTF8), translations);
            return combinedLines;
        }

        private static Dictionary<string, string> GetTranslations(string [] translatedPotLines)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string key = null;

            // read all lines matching msgid and msgstr
            foreach (string val in translatedPotLines)
            {
                if (val.Length > 7)
                {
                    switch (val.Substring(0, 6))
                    {
                        case "msgid ":
                            // save the msgid for the next loop iteration
                            key = val;
                            break;

                        case "msgstr":
                            // having in mind that these two come one after another as soon as 
                            // you find msgstr, combine the two and add them to the dictionary
                            dictionary.Add(key, val);
                            break;
                    }
                }
            }

            return dictionary;
        }

        private static string[] Translate(string[] untranslatedPotLines, Dictionary<string, string> translations)
        {
            string key = null;
            string [] translatedLines = new string [untranslatedPotLines.Length];
            int index = 0;

            // read all untranslated lines
            foreach (string val in untranslatedPotLines)
            {
                string line = val;

                if (val.Length > 7)
                {
                    switch (val.Substring(0, 6))
                    {
                        case "msgid ":
                            // save the msgid for the next loop iteration
                            key = val;
                            break;

                        case "msgstr":
                            // having in mind that these two come one after another as soon as 
                            // you find msgstr, transltate it
                            if (translations.ContainsKey(key))
                            {
                                line = translations[key];
                            }
                            break;
                    }
                }

                // copy line (translated or not) to output array
                translatedLines[index++] = line;
            }

            return translatedLines;
        }

    }
}
