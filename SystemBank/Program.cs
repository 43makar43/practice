using System.Net;
using System.ComponentModel.Design;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Scripts
{
    public class BaseScript
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Bank bank = new Bank();

            // отправка сообщения клиенту на почту
            if (!CheckedCredit(person, bank))
                Console.WriteLine($"Уважаемый, {person.SecondName} {person.FirstName} {person.MiddleName} Вы должны нам целую кучу денюжек, а именно разница по кредиту составляет: {CreditCalculation(person.Money, bank.MaxCredit)}");
        }

        private static bool CheckedCredit(Person person, Bank bank)
        {
            double creditPerson = person.Money;
            double maxCredit = bank.MaxCredit;

            if (creditPerson > maxCredit)
                return false;

            return true;
        }

        private static double CreditCalculation(double creditPerson, double maxCredit)
        {
            
                return maxCredit - creditPerson;
        }

        public static void SendMessage(string emailUser, string subMessage, string bodyMessage)
        {
            // подключаемся к сервису smtp 
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("developmnet@mail.ru", "n6uQHZ1x8sMkxfgN2zVC");

            // генерируем новое сообщение 
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("developmnet@mail.ru");

            // кому, тема, сообщение 
            Message.To.Add(new MailAddress(emailUser));
            Message.Subject = subMessage;
            Message.Body = bodyMessage;

            try
            {
                Smtp.Send(Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}