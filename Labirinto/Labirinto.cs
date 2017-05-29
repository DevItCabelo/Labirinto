using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class Labirinto
    {

        public void montaGrafo(){
            
        }

        public void labirintoDoArquivo()
        {
            LerDoArquivo labirintoStr = new LerDoArquivo();
            string[] labirinto = labirintoStr.getTexto();
            for (int i = 0; i < labirinto.Length; i++) Console.WriteLine(labirinto[i]);

            Console.WriteLine(labirinto[2][4]);
        }
    }
}
