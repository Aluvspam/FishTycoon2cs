using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishTycoon2cs
{
    class FileReader
    {

        String[,] content = null;
        StreamReader reader = null;

        public FileReader()
        {
            content = new String[22, 22];
            //Console.WriteLine(Path.GetDirectoryName(Application.ExecutablePath));
            reader = new StreamReader(@"..\..\FishTycoon2Charts\Fin Breed Price.csv");

        }



    }
}
