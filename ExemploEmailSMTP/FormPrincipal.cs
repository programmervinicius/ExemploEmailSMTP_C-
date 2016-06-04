using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemploEmailSMTP
{
    public partial class FormTesteEnvioEmail : Form
    {
        public FormTesteEnvioEmail()
        {
            InitializeComponent();
        }

        private void enviarEmailTesteSincrono()
        {
            string sHost = "smtp.gmail.com", sEmail = "exemploemailsmtp@gmail.com", sSenha = "senha001#";
            try
            {
                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                {
                    using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                    {
                        smtp.Host = sHost;
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(sEmail, sSenha);

                        mail.From = new System.Net.Mail.MailAddress(sEmail);
                        mail.To.Add(new System.Net.Mail.MailAddress(sEmail));
                        //mail.CC.Add(new System.Net.Mail.MailAddress(sEmail));
                        //mail.Bcc.Add(new System.Net.Mail.MailAddress(sEmail));
                        mail.Subject = "Assunto do e-mail de teste.";
                        mail.Body = "Corpo da mensagem do e-mail de teste.";

                        // Anexar arquivos                        
                        //using (OpenFileDialog dialog = new OpenFileDialog())
                        //{
                        //    dialog.Multiselect = true;
                        //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        foreach (var file in dialog.FileNames)
                        //        {
                        //            listBoxAttachments.Items.Add(file);
                        //        }
                        //    }
                        //}                                        
                        //foreach (string file in listBoxAttachments.Items)
                        //{
                        //    mail.Attachments.Add(new System.Net.Mail.Attachment(file));
                        //}
                      
                        // Formatação do texto para HTML
                        //mail.IsBodyHtml = true;
                        //mail.Body = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(richTextBoxCorpo.Rtf); 
                        
                        smtp.Send(mail);
                        Informacao("E-mail de teste enviado com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                Erro("Erro ao enviar e-mail de teste.", ex);
            }
        }

        public static void Erro(string Msg, Exception ex)
        {
            MessageBox.Show(Msg + "\n" + ex.Message + "\n" + ex.InnerException, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        public static void Informacao(string Msg)
        {
            MessageBox.Show(Msg + "\n", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        // Envia um e-mail de teste assíncrono. Atenção: Válido apenas usando o Visual Studio 2012 
        // para a área de trabalho do Windows, ou .NET Framework 4.5 instalado no seu computador.
        /*
        private async void enviarEmailTesteAssincrono()
        {
            string sHost = "smtp.gmail.com", sEmail = "exemploemailsmtp@gmail.com", sSenha = "senha001#";
            try
            {
                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                {
                    using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                    {
                        smtp.Host = sHost;
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(sEmail, sSenha);

                        mail.From = new System.Net.Mail.MailAddress(sEmail);
                        mail.To.Add(new System.Net.Mail.MailAddress(sEmail));
                        //mail.CC.Add(new System.Net.Mail.MailAddress(sEmail));
                        //mail.Bcc.Add(new System.Net.Mail.MailAddress(sEmail));
                        mail.Subject = "Assunto do e-mail de teste.";
                        mail.Body = "Corpo da mensagem do e-mail de teste.";

                        // Anexar arquivos                        
                        //using (OpenFileDialog dialog = new OpenFileDialog())
                        //{
                        //    dialog.Multiselect = true;
                        //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        //    {
                        //        foreach (var file in dialog.FileNames)
                        //        {
                        //            listBoxAttachments.Items.Add(file);
                        //        }
                        //    }
                        //}                                        
                        //foreach (string file in listBoxAttachments.Items)
                        //{
                        //    mail.Attachments.Add(new System.Net.Mail.Attachment(file));
                        //}
                      
                        // Formatação do texto para HTML
                        //mail.IsBodyHtml = true;
                        //mail.Body = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(richTextBoxCorpo.Rtf); 
                        
                        await smtp.SendMailAsync(mail);
                        Informacao("E-mail de teste enviado com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                Erro("Erro ao enviar e-mail de teste.", ex);
            }           
        }
        */

        private void btnEnviarEmailTesteSincrono_Click(object sender, EventArgs e)
        {
            enviarEmailTesteSincrono();
        }
    }
}
