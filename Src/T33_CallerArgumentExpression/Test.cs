using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace CSharpNewFeatures.T33_CallerArgumentExpression;

internal class Test
{
    record User(string FirstName, string LastName);
    record Provider(string Domain);

    public static void ValidateEmail(string email, [CallerArgumentExpression("email")] string? argumentExpr = null)
    {
        if (!email.Contains("@") && !email.Contains("(at)"))
        {
            throw new InvalidOperationException($"Invalid email <{argumentExpr}> with value <{email}>");
        }

        Console.WriteLine($"Valid email <{argumentExpr}> with value <{email}>");
    }

    public static void Run()
    {
        try
        {
            string myEmail1 = "Bill.Gates@microsoft.com";
            string myEmail2 = "Tomas.Frankl(at)tietoevry.com";
            string myEmail3 = "NeplatnyEmail.gmail.com";

            ValidateEmail(myEmail1);
            ValidateEmail(myEmail2);
            ValidateEmail(myEmail3);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        User user = new("Bill", "Gates");
        Provider provider = new("microsoft.com");
        ValidateEmail($"{user.FirstName}.{user.LastName}@{provider.Domain}");
    }
}
