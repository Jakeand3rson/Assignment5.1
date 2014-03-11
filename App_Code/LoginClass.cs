using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    CommunityAssistEntities ae = new CommunityAssistEntities();
    string password;
    string username;

    public LoginClass(string pass, string user)
    {
        password = pass;
        username = user;
    }

    public int ValidateLogin()
    {
        //personKey to return, initially 0
        int pk = 0;
        //LINQ to extract personkeyt, passcode, and hashedpassword
        var log = from r in ae.People
                  where r.PersonUsername == username
                  && r.PersonPlainPassword == password
                  select new { r.PersonKey, r.Personpasskey, r.PersonUserPassword };
        int pCode = 0;
        Byte[] pWord;
        int personKey = 0;

        //loop through results and assign values from the var log to our variables
        foreach (var p in log)
        {
            pk = (int)p.PersonKey;
            pCode = (int)p.Personpasskey;
            pWord = (Byte[])p.PersonUserPassword;
        }
        //initial the passWordHash
        PasswordHash ph = new PasswordHash();
        Byte[] newHash = ph.HashIt(password, pCode.ToString());
        // string passString = ConvertBytes(pWord);
        // string newHashString = ConvertBytes(newHash);

        // if (passString.Equals(newHash))
        //   {
        pk = personKey;
        //    }
        return pk;
    }
}