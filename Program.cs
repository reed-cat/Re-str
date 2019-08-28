using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Re_str.restr;
using Re_str.restr.obj;

namespace Re_str
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {        
            RestrFile restrFile = RestrFile.LoadFromFile("C:\\Users\\Erik\\Desktop\\anan.rs");

            string version = restrFile.RestrObjects["seawolf"].Aliases["Version"];
        }
    }
}