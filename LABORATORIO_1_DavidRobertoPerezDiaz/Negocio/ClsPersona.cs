using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using LABORATORIO_1_DavidRobertoPerezDiaz.Entidades;

namespace LABORATORIO_1_DavidRobertoPerezDiaz.Negocio
{

    public class ClsPersona
    {

        public string ObtenerNombrePersona(Persona pers)
        {
            return $"Bienvenid@ {pers.Nombre}";
        }

        public String MayordeEdad(Persona pers)
        {

            if (pers.Edad >= 18)
            {
                return "Usted es mayor de edad";

            }

            return "Usted es menor de edad";

        }

        public String Comprobar_Sex(Persona pers)
        {

            if (pers.Sexo == "Masculino" || pers.Sexo == "Hombre")
            {

                return $"Usted pertenece al sexo Masculino (M)";

            }
            else if (pers.Sexo == "femenino" || pers.Sexo == "Mujer")
                {

                    return $"Usted pertenece al sexo Femenino (F)";

                }
            else
            {
                return "No pertenece a ninguno de los dos sexos";
            }

            
        }
    

        public String Calcular_IMC(Persona pers)
        {


            double Promedio = pers.Peso / Math.Pow(pers.Altura, 2);

            if (Promedio > 25)
            {
                return $"Usted sufre de sobrepeso";

            }
            else if (Promedio < 24)
            {

                return $"Su peso respecto a su altura es ideal";
            }
            else
            {
                return "Su valor esta fuera de los parametros calculables";
            }

        }
    }
}