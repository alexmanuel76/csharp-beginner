using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexionConSqlserver
{
    public class Impresora
    {
        private static int contador;
        private static DataGridView tablaDeDatos;
        private static List<int> indiceColumnas;

        /*
         * Metodo que Imprime cuando le pasas los Indices
         * */
        public static void Imprimir(PrintDocument documento, DataGridView tabla, List<int> indices = null)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = documento;
            documento.BeginPrint += new PrintEventHandler(Inicializar);
            documento.PrintPage += new PrintPageEventHandler(ImprimirDocumento);
            tablaDeDatos = tabla;
            indiceColumnas = indices;
            printPreviewDialog.ShowDialog();
            
        }

        /*
         * Metodo para imprimir todas las columnas de la tabla
         * */
        public static void Imprimir(PrintDocument documento, DataGridView tabla)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = documento;
            documento.BeginPrint += new PrintEventHandler(Inicializar);
            documento.PrintPage += new PrintPageEventHandler(ImprimirDocumento);
            tablaDeDatos = tabla;
            indiceColumnas = new List<int>();
            for (int i = 0; i < tablaDeDatos.Columns.Count;i++)
            {
                indiceColumnas.Add(i);
            }
            printPreviewDialog.ShowDialog();

        }

        private static void ImprimirDocumento(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 10);
            int espaciado = 10;
            int altoLinea = (int)fuente.GetHeight() + espaciado;
            int totalLineasPaginas = e.MarginBounds.Height / altoLinea;

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            int numeroColumnas = tablaDeDatos.Columns.Count;
            for (int j = 0; j < numeroColumnas; j++)
            {
                if (indiceColumnas.Contains(j))
                {
                    e.Graphics.DrawString(tablaDeDatos.Columns[j].Name, fuente, Brushes.Blue, x, y);
                    x += 150;
                }
                
            }

            x = e.MarginBounds.Left;
            y += altoLinea;
            e.Graphics.DrawLine(Pens.BurlyWood, x, y, x + 600, y);
            for (int i = 0; i < totalLineasPaginas; i++)
            {
                if (contador < tablaDeDatos.Rows.Count)
                {
                    x = e.MarginBounds.Left;
                    for (int j = 0; j < numeroColumnas; j++)
                    {
                        if (indiceColumnas.Contains(j))
                        {
                            e.Graphics.DrawString(tablaDeDatos.Rows[contador].Cells[j].Value.ToString(), fuente, Brushes.Black, x, y);
                            x += 150;
                        }
                        
                    }
                    contador++;
                    y += altoLinea;
                }

            }
            e.HasMorePages = contador < tablaDeDatos.Rows.Count;
        }

        private static void Inicializar(object sender, PrintEventArgs e)
        {
            contador = 0;
        }
    }
}
