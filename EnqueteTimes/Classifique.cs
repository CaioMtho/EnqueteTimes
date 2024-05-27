using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace EnqueteTimes
{
    internal class Classifique
    {
        // os 4 indices da lista representam respectivamente Corinthians, São Paulo, Palmeiras e Santos
        List<int> nTorcedores = [0, 0, 0, 0];

        public void Acrescente(string time)
        {
            switch(time)
            {
                case "cor":
                    nTorcedores[0]++;
                    break;
                case "sao":
                    nTorcedores[1]++;
                    break;
                case "pal":
                    nTorcedores[2]++;
                    break;
                case "san":
                    nTorcedores[3]++;
                    break;
                default : throw new Exception();
            }
        }

        public int Resultado(string time)
        {
            switch (time)
            {
                case "cor":
                    return nTorcedores[0];
                case "sao":
                    return nTorcedores[1];
                case "pal":
                    return nTorcedores[2];
                case "san":
                    return nTorcedores[3];
                default: throw new Exception();
            }
        }

        public void Redefina()
        {
            nTorcedores[0] = 0;
            nTorcedores[1] = 0;
            nTorcedores[2] = 0;
            nTorcedores[3] = 0;
        }

        public int Ganhador() 
        {

            if (nTorcedores[0] > nTorcedores[1] && nTorcedores[0] > nTorcedores[2] && nTorcedores[0] > nTorcedores[3])
            {
                return 0;
            }

            if (nTorcedores[1] > nTorcedores[2] && nTorcedores[1] > nTorcedores[0] && nTorcedores[1] > nTorcedores[3])
            {
                return 1;
            }

            if ((nTorcedores[2] > nTorcedores[0] && nTorcedores[2]  > nTorcedores[1] && nTorcedores[2] > nTorcedores[3]))
            {
                return 2;
            }

            if (nTorcedores[3] > nTorcedores[0] && nTorcedores[3] > nTorcedores[1] && nTorcedores[3] > nTorcedores[2])
            {
                return 3;
            }

            return 4;
        }
    }
}
