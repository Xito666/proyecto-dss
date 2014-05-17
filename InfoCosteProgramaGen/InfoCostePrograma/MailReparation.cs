using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace InfoCostePrograma
{
    class MailReparation
    {

        public void EnviarAviso(String nombre, String mail)
        {
            MailMessage _Correo = new MailMessage();
            _Correo.From = new MailAddress("satInfoApp@gmail.com");
            _Correo.To.Add(mail.ToString());
            _Correo.Subject = "Reparacion Realizada";
            _Correo.Body = "Ya puede venir a recoger su articulo reparado";
            _Correo.IsBodyHtml = false;
            _Correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("satInfoApp@gmail.com", "pajarraco02");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(_Correo);
                System.Windows.Forms.MessageBox.Show("Aviso Enviado");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("ERROR: No se ha podido enviar el Aviso");
            }
            _Correo.Dispose();
        }
    }
}