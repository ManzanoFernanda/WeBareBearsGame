using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BackEnd
{
    public class ListaDePuntos
    {
        public DataTable lista = new DataTable();
        public ListaDePuntos()
        {

            lista.TableName = "Puntajes";
            lista.Columns.Add("Nombre", typeof(string));
            lista.Columns.Add("Puntos", typeof(int));

            if (!System.IO.File.Exists("Tablas.xml"))
            {
                lista.WriteXml("Tablas.xml");
            }
            lista.ReadXml("Tablas.xml");

        }

        public void GuardarPuntos(string Nombre, int Punto)
        {
            bool ExisteNombre = false;

            for (int i = 0; i < lista.Rows.Count; i++)
            {
                if (Nombre == lista.Rows[i]["Nombre"].ToString()) 
                {
                    int PuntajeActual = Convert.ToInt32(lista.Rows[i]["Puntos"]);
                    lista.Rows[i]["Puntos"] = PuntajeActual + Punto;
                    ExisteNombre = true;
                }

            }
            if (ExisteNombre==false)
            {
                lista.Rows.Add();
                lista.Rows[lista.Rows.Count - 1]["Nombre"] = Nombre;
                lista.Rows[lista.Rows.Count - 1]["Puntos"] = Punto;

            }
            lista.WriteXml("Tablas.xml");
            
        }
    }
}
