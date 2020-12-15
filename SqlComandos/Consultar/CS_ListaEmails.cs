using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmailMKT2.SqlComandos.Consultar
{
    class CS_ListaEmails
    {
        public List<string> NOME = new List<string>();
        public List<string> EMAIL = new List<string>();
        public void ConsultandoListaEmails()
        {
            Classes.Conexão con = new Classes.Conexão();
            string strConsultar = "SELECT NOME, EMAIL FROM ListaEmails";
            SqlCommand objComando;

            try
            {
                con.AbrirConexão();
                objComando = new SqlCommand(strConsultar, con.sqlConnection);
                SqlDataReader leitor = objComando.ExecuteReader();

                while(leitor.Read())
                {
                    NOME.Add(leitor["NOME"].ToString());
                    EMAIL.Add(leitor["EMAIL"].ToString());
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao consultar - SqlComandos/Consultar/ConsultandoListaEmails()." + erro);
            }
            finally
            {
                con.FecharConexão();
            }
        }
    }
}
