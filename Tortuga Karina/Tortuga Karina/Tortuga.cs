using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_Karina
{
    class Tortuga
    {
        private string[,] posicion = new string[20, 20];
        private int brujula = 2;
        private bool pluma = true;
        public int cor_x = 0, cor_y = 0;

        public void Avanzar()
        {
            if (brujula == 1) {
                cor_y -= 1;
                Escribir();
            }
            else if(brujula == 2) {
                cor_x += 1;
                Escribir();
            }
            else if(brujula == 3) {
                cor_y += 1;
                Escribir();
            }
            else {
                cor_x -= 1;
                Escribir();
            }
        }

        public void Escribir()
        {
            if (pluma == true)
                posicion[cor_x, cor_y] = "°";
        }

        public void Izquierda()
        {
            if (brujula == 1)
                brujula = 4;
            else
                brujula--;
        }

        public void Derecha()
        {
            if (brujula == 4)
                brujula = 1;
            else
                brujula++;
        }

        public string Mostrar()
        {
            string s = "";
            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 20; j++) {
                    if (posicion[j, i] == "°")
                        s += posicion[j, i] + "  ";
                    else
                        s += ".  ";
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public void subirPluma()
        {
            pluma = false;
        }

        public void bajarPluma()
        {
            pluma = true;
        }

    }
}
