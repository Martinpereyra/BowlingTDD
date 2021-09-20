using System;
using System.Collections.Generic;

namespace Libreria
{
    public class Game
    {
        public int[] puntos = new int[28];
        public int turno = 0;
        public void Tirar(int tirada)
        {
            puntos[turno] = tirada;
            if (tirada == 10 && (turno % 2 == 0))
            {
                puntos[turno+1] = 0;
                turno += 2;              
            }
            else
            {
                turno++;
            }
              
        }

        public int Score()
        {
            int cont = 0;
            for(int i=0; i<21; i++)
            {
                cont += puntos[i];

                if ((i % 2 != 0) && (puntos[i] + puntos[i - 1] == 10) && (puntos[i]!=0))
                {
                    cont += puntos[i+1];
                }


                if ((i % 2 == 0) && (puntos[i] == 10) && (i != 18))
                {
                    if(puntos[i+2] == 10)
                    {
                        cont += puntos[i + 2] + puntos[i + 4];
                    }
                    else
                    {
                        cont += puntos[i + 2] + puntos[i + 3];
                    }
                }
                   
            }
            return cont;
        }

    }
}
