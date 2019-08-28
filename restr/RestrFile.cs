using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Re_str.restr.obj;
using Re_str.restr.token;

namespace Re_str.restr
{
    public class RestrFile
    {
        public const string EXTENSION = ".rs";
        public bool Reading { get; set; }

        public RestrFile()
        {
            if (!Token.Initialized)
            {
                Token.Setup();
            }
        }

        public void Save(string fileName)
        {
            List<string> writeList = new List<string>();
            writeList.Add("&>");


            foreach (var restrObject in RestrObjects)
            {
                writeList.Add(restrObject.Key + "(");
                const string TAB = "   ";
                foreach (var alias in restrObject.Value.Aliases)
                {
                    writeList.Add(TAB + alias.Key + ": \"" + alias.Value + "\"");
                }
                writeList.Add(")");
                writeList.Add("");
            }
            
            writeList.Add("<");
            
            File.WriteAllLines(fileName, writeList);
        }

        /// <summary>
        /// Do not use!
        /// </summary>
        public RestrObject _CompalingObject { get; set; }

        public Dictionary<string, RestrObject> RestrObjects { get; set; } = new Dictionary<string, RestrObject>();

        public static RestrFile LoadFromUrl(string url)
        {
            string[] read = new WebClient().DownloadString(url)
                .Split(new string[] {"\r\n", "\n", Environment.NewLine}, StringSplitOptions.None);

            return Load(read);
        }
        
        public static RestrFile LoadFromFile(string filePath)
        {
            return Load(File.ReadAllLines(filePath));
        }

        public static RestrFile Load(string[] read)
        {
            RestrFile restrFile = new RestrFile();

            for (int lineIndex = 0; lineIndex < read.Length; lineIndex++)
            {
                string line = read[lineIndex].Replace("\t", " ");
                while (line.IndexOf("  ") >= 0)
                {
                    line = line.Replace("  ", " ");
                }

                string currentLine = string.Empty; 
                Token token = Token.GetToken(line);
                token?.Compile(line, restrFile);
            }

            return restrFile;
        }

    }
}