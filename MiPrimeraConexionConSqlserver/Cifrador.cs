using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraConexionConSqlserver
{
    public class Cifrador
    {
        public static string CifrarClaves(string password)
        {
            string claveCifrada = "";
            SHA256Managed sha256 = new SHA256Managed();
            byte[] noCifrada = Encoding.Default.GetBytes(password);
            byte[] cifrada = sha256.ComputeHash(noCifrada);
            
            claveCifrada = BitConverter.ToString(cifrada).Replace("-", "");
            return claveCifrada;
        }
    }
}
