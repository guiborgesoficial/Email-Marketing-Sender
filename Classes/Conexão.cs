using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmailMKT2.Classes
{
    class Conexão
    {
        public SqlConnection sqlConnection = new SqlConnection(@"ADICIONAR SUA STRING DE CONEXÃO");
        public void AbrirConexão()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao abrir conexão - Classes/Conexão.cs/AbrirConexão()." + erro);
            }
        }
        public void FecharConexão()
        {
            try
            {
                sqlConnection.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao fechar conexão - Classes/Conexão.cs/FecharConexão()." + erro);
            }
        }
    }
}
