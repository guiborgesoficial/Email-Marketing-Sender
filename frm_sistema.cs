using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EmailMKT2
{
    public partial class frm_sistema : Form
    {
        public List<string> NOMEf = new List<string>();
        public List<string> EMAILf = new List<string>();

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public frm_sistema()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EMAILf.Count; i++)
            {
                try
                {
                    login = new NetworkCredential(textBox_email.Text, textBox_senha.Text);
                    client = new SmtpClient(textBox_SMTP.Text);
                    client.Port = Convert.ToInt32(textBox_porta.Text);
                    client.EnableSsl = true;
                    client.Credentials = login;

                    msg = new MailMessage();
                    msg.To.Add(new MailAddress(EMAILf[i]));
                    msg.From = new MailAddress(textBox_email.Text);
                    msg.Body = textBox_escreverEmail.Text;
                    if (textBox_anexo.Text != "")
                    {
                        msg.Attachments.Add(new Attachment(textBox_anexo.Text));
                    }
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = false;
                    msg.Priority = MailPriority.High;
                    client.Send(msg);
                    
                    if (i == EMAILf.Count)
                        MessageBox.Show("Enviado com sucesso");
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Erro: " + erro);
                }            
            }
        }
  

        private void btn_anexoBuscar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_anexo.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            textBox_para.Text = "example@hotmail.com";
            SqlComandos.Consultar.CS_ListaEmails novo = new SqlComandos.Consultar.CS_ListaEmails();
            novo.ConsultandoListaEmails();
            NOMEf = novo.NOME;
            EMAILf = novo.EMAIL;

            for(int i = 0; i < EMAILf.Count; i++)
            {
                textBox_para.Text += ", "  + "\"" + EMAILf[i].ToString() + "\"";
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            textBox_senha.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox_senha.UseSystemPasswordChar = true;
        }
    }
}
