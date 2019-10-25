using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_Stats.FUT_Champions
{
    public class CargaDatos
    {
        private TextWriter archivoSemana(int numero)
        {
            TextWriter tw = new StreamWriter("Semanas/" + numero + ".txt");
            return tw;
        }

        public void cargarDatos(Semana semana)
        {
            TextWriter tw = archivoSemana(semana.Numero);
            calcularDatos(semana);
            tw.WriteLine(semana.Numero + "*" + semana.Fecha + "*" + semana.Rango + "*" + semana.Ganados + "*" + semana.Perdidos + "*" + semana.Jugados);
            if (semana.Partidos != null)
            {
                foreach (Partido partido in semana.Partidos)
                {
                    tw.WriteLine(partido.Numero + "*" + partido.NombreRival + "*" + partido.Resultado + "*" + partido.GolesFavor + "*" + partido.GolesContra + "*" + partido.PenalesFavor + "*" + partido.PenalesContra + "*" + partido.Localia);
                }
            }
            tw.Close();
        }

        public void guardarCantidadSemanas(List<Semana> listaSemanas)
        {
            TextWriter tw = new StreamWriter("Semanas.txt");
            string cant = Convert.ToString(listaSemanas.Count);
            tw.WriteLine(cant);
            tw.Close();
        }

        public void calcularDatos(Semana semana)
        {
            semana.Rango = "Por determinar";
            semana.Ganados = 0;
            semana.Perdidos = 0;
            semana.Jugados = 0;

            foreach (Partido partido in semana.Partidos)
            {
                if (partido.Resultado == "Victoria")
                {
                    semana.Ganados++;
                }
                else
                {
                    semana.Perdidos++;
                }
                semana.Jugados++;
            }

            if (semana.Jugados >= 5)
            {
                if (semana.Ganados < 2)
                {
                    semana.Rango = "Bronce 3";
                }
                else
                {
                    if (semana.Ganados <= 3)
                    {
                        semana.Rango = "Bronce 2";
                    }
                    else
                    {
                        if (semana.Ganados <= 5)
                        {
                            semana.Rango = "Bronce 1";
                        }
                        else
                        {
                            if (semana.Ganados <= 7)
                            {
                                semana.Rango = "Plata 3";
                            }
                            else
                            {
                                if (semana.Ganados <= 10)
                                {
                                    semana.Rango = "Plata 2";
                                }
                                else
                                {
                                    if (semana.Ganados <= 13)
                                    {
                                        semana.Rango = "Plata 1";
                                    }
                                    else
                                    {
                                        if (semana.Ganados <= 16)
                                        {
                                            semana.Rango = "Oro 3";
                                        }
                                        else
                                        {
                                            if (semana.Ganados <= 19)
                                            {
                                                semana.Rango = "Oro 2";
                                            }
                                            else
                                            {
                                                if (semana.Ganados <= 22)
                                                {
                                                    semana.Rango = "Oro 1";
                                                }
                                                else
                                                {
                                                    if (semana.Ganados <= 24)
                                                    {
                                                        semana.Rango = "Elite 3";
                                                    }
                                                    else
                                                    {
                                                        if (semana.Ganados <= 26)
                                                        {
                                                            semana.Rango = "Elite 2";
                                                        }
                                                        else
                                                        {
                                                            semana.Rango = "Elite 1";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
