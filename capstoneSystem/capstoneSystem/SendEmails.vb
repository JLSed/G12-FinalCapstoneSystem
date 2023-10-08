Imports System.Net.Mail
Imports System.Net
Module SendEmails
    Sub SendEmailMessage(ByVal ToSubject As String, ByVal Subject As String, ByVal BodySubject As String)
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("attendancesystemforyasc@gmail.com", "gyzwjhacfcdbntqi")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"
        Smtp_Server.DeliveryMethod = SmtpDeliveryMethod.Network

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("attendancesystemforyasc@gmail.com")
        e_mail.To.Add(ToSubject)
        e_mail.Subject = Subject
        e_mail.IsBodyHtml = False
        e_mail.Body = BodySubject
        Smtp_Server.Send(e_mail)
       
    End Sub
End Module
