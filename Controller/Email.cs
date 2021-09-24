using System;
using System.IO;
using System.Net.Mail;
using GM.Model;

namespace GM.Controller {
	public class Email {
		
		public String assunto {get; set;}
		public String email {get; set;}
		public String anexo {get; set;}
		
		public String usuario = "lucasmatheusg4@outlook.com";
		public String senha = "bilokara13";
		
		public Email(String assunto, String email, String anexo) {
			this.assunto = assunto;
			this.email = email;
			this.anexo = anexo;
		}
		
		 public Resultado SendMail(string recipient, string subject, string anexo) {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
  
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials =  new System.Net.NetworkCredential(this.usuario, this.senha);
            client.EnableSsl = true;
            client.Credentials = credentials;
            try {
                var mail = new MailMessage(this.usuario, recipient.Trim());
                mail.Subject = subject;
                mail.Body = "GML Sistemas - Relatório entregue !";
            	mail.BodyEncoding = System.Text.Encoding.UTF8;
            	FileStream fl = new FileStream(anexo, FileMode.Open);
            	mail.Attachments.Add(new Attachment(fl, "relatorio.pdf"));
            	client.Send(mail);
            	fl.Close();
            	return new Resultado(true, "OK");
            } catch (Exception ex) {
            	return new Resultado(false, ex.ToString());
            }
        }
	}
}
