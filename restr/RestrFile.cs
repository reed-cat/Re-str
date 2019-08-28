using System;
using System.Collections.Generic;
using System.IO;
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
        
        /// <summary>
        /// Do not use!
        /// </summary>
        public RestrObject _CompalingObject { get; set; }

        public Dictionary<string, RestrObject> RestrObjects { get; set; } = new Dictionary<string, RestrObject>();

        public static RestrFile LoadFromFile(string filePath)
        {
            RestrFile restrFile = new RestrFile();
            string[] read = File.ReadAllLines(filePath);


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