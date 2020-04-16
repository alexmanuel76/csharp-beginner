using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace MiPrimeraConexionConSqlserver
{
    public class SQL
    {
        private static SqlConnection conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

        /*
         * Ejecutar un SP simple y llenar un DataGridView
         * */
        public static void listarConsultaSql(string consultaSQL, DataGridView grillaDeDatos,Boolean esSP)
        {
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            try
            {
                comandoSQL.Connection.Open();
                
            }
            catch(SqlException ex)
            {
                string mensaje = "Error al Conectarse al Servidor de BD, SQL_ERROR: " + ex.Number + " "+ ex.Server;
                VentanaMensaje(mensaje);
                Environment.Exit(0);
            }
            if (esSP == true)
            {
                comandoSQL.CommandType = CommandType.StoredProcedure;
            }
            
            DataTable tabla = new DataTable();

            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tabla);

            grillaDeDatos.DataSource = tabla;
            comandoSQL.Connection.Close();

        }

        /*
         * Ejecutar un SP con un parametro simple y llenar un DataGridView
         * */
        public static void ejeutarSpParametros(string consultaSQL, DataGridView grillaDeDatos, string parametro, string valor)
        {
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.AddWithValue(parametro, valor);

            DataTable tabla = new DataTable();

            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tabla);

            grillaDeDatos.DataSource = tabla;
        }

        public static DataTable ejecutarSPConsulta(string consultaSQL, string parametro, string valor)
        {
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.AddWithValue(parametro, valor);

            DataTable tabla = new DataTable();

            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tabla);

            return tabla;
        }

        /**
         * ejecutar un SP base a parametros y un HashSet (una mierda)
         * */
        public static void ejeutarSpParametros(string consultaSQL, DataGridView grillaDeDatos, HashSet<Object> parametros)
        {
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            comandoSQL.CommandType = CommandType.StoredProcedure;
            foreach (Object[] param in parametros)
            {
                string variable = (string)param[0];
                comandoSQL.Parameters.AddWithValue(variable, param[1]);
            }

            DataTable tabla = new DataTable();

            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tabla);

            grillaDeDatos.DataSource = tabla;
        }

        /*
         * Para ejecutar un SP enviando sus parametros y valores
         * devuelve el resultado
         * */
        public static int EjeutarSp(string consultaSQL, ArrayList parametros, ArrayList valores)
        {
            int resultado = 0;
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            comandoSQL.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parametros.Count; i++)
            {
                comandoSQL.Parameters.AddWithValue((string)parametros[i], valores[i]);
            }

            comandoSQL.Connection.Open();
            resultado = comandoSQL.ExecuteNonQuery();
            comandoSQL.Connection.Close();

            return resultado;
        }

        /*
         * Metodo para llentar un DataTable con una consulta simple
         * 
         * */
        public static void listarConsultaSql(string consultaSQL, DataTable tablaDatos, Boolean esSP)
        {
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            if (esSP == true)
            {
                comandoSQL.CommandType = CommandType.StoredProcedure;
            }

            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tablaDatos);

        }

        /*
         * Metodo para llentar un ComboBox con una consulta simple
         * 
         * */
        public static void listarConsultaSql(string consultaSQL, ComboBox combobox, Boolean esSP, string campoId, string campoValores, bool primerValor=false)
        {
            DataTable tablaDeDatos= new DataTable();
            SqlCommand comandoSQL = new SqlCommand(consultaSQL, conexion);
            if (esSP == true)
            {
                comandoSQL.CommandType = CommandType.StoredProcedure;
            }
            
            SqlDataAdapter resultset = new SqlDataAdapter(comandoSQL);
            resultset.Fill(tablaDeDatos);
            if (primerValor == false)
            {
                DataRow fila = tablaDeDatos.NewRow();
                fila[0] = 0;
                fila[1] = " - - Seleccione - - ";
                tablaDeDatos.Rows.InsertAt(fila, 0);
            }
            combobox.DataSource = tablaDeDatos;
            combobox.ValueMember = campoId;
            combobox.DisplayMember = campoValores;
        }

        /**
         * Metodo para validaciones basicas de los controles
         * 
         * */
        public static bool validarRequeridos(Control.ControlCollection controles, ErrorProvider controlDeError)
        {
            bool exito = true;
            foreach(Control control in controles)
            {
                if (control is TextBox)
                {
                    if (control.Tag != null && control.Tag.Equals("O"))
                    {
                        if (((TextBox)control).Text.Equals(""))
                        {
                            controlDeError.SetError(control, "Ingresar valor");
                            exito = false;
                        }
                        else
                        {
                            controlDeError.SetError(control, "");
                        }
                    }
                }else if(control is NumericUpDown)
                {
                    if (control.Tag != null && control.Tag.Equals("O"))
                    {
                        if (((NumericUpDown)control).Value.Equals(0))
                        {
                            controlDeError.SetError(control, "Ingresar valor mayor a 0");
                            exito = false;
                        }
                        else
                        {
                            controlDeError.SetError(control, "");
                        }
                    }
                }
                else if (control is ComboBox)
                {
                    if (control.Tag != null && control.Tag.Equals("O"))
                    {
                        if (((ComboBox)control).SelectedIndex.ToString().Equals("0"))
                        {
                            controlDeError.SetError(control, "Seleccione Valor");
                            exito = false;
                        }
                        else
                        {
                            controlDeError.SetError(control, "");
                        }
                    }
                }
            }

            return exito;
        }

        public static void VentanaMensaje(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
    
}
