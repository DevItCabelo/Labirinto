using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labirinto
{
    class LerDoArquivo
    {
        StreamReader sr = new StreamReader(@"labirinto.txt");
        string[] labirinto;
        public string[] getTexto()
        {
            string linha;
            labirinto = new string[File.ReadLines(@"labirinto.txt").Count()];
            for (int i = 0; (linha = sr.ReadLine()) != null; i++) labirinto[i] = linha;
            return labirinto;
        }
    }
}
