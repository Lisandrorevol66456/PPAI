using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    
    public class Sede
    {
        AccesoBD _BD = new AccesoBD();
        public int idSede = 1;
        public long Cupo = 500;
        public long visitantes { get; set; }
    
        public bool CheckearCupo(long entradasIngresadas)
        {
            return Cupo - (entradasIngresadas+ visitantes) >= 0 ? true : false;
        }
        public long CalcularVisitantes(long entradasIngresadas) => visitantes += entradasIngresadas;

        public void CalcularDuracionResumidaObra(int idSede)
        {
            string sqlTxt = $"SELECT * from Exposiciones where sede = {idSede}";
            var expos = _BD.Consulta(sqlTxt).Rows;

            foreach (DataRow exp in expos)
            {
                if (exp.HasErrors)
                    continue;
                var fila = new string[]
                {
                    exp.ItemArray[0].ToString()
                };

                
            }


        }

    }
}
