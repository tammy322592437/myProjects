using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dal;
namespace BL
{
    public class UserBL
    {
        public static bool CreateUser(DTO.UserDTO user)
        {
            return Dal.Actions.User.CreateUser(Converters.UserConverters.GetUser(user));


        }

        public static bool ForgetPassword(int organizationKod, int typeUser, string mail)
        {
            string passwordChange = GenerateString(8);
            var result = Dal.Actions.User.ForgetPassword(organizationKod, typeUser, mail, passwordChange);
     if(result)
            {
                string to = mail;
                string subject = "שינוי סיסמא";
                string body = "הסיסמה שונתה ל : " + passwordChange + " <br>" +
                    "כדי לשנות את הסיסמא יש להכנס למערכת ולבחור שינוי פרטים אישיים" +
                    "<br>" +
                    "<a href='http://localhost:4200/'>כניסה למערכת</a>";
                SendMessage s = new SendMessage();
                s.SendMail(to, body, subject);
                return true;
            }
            return false;
                }
        public static string GenerateString(int size)
        {
            Random rand = new Random();

            string Alphabet =
          "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            return new string(chars);
        }
    }
}
