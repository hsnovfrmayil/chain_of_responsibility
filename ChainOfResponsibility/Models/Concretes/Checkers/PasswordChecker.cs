using System;
using ChainOfResponsibility.Models.Abstracts;

namespace ChainOfResponsibility.Models.Concretes.Checkers;

public class PasswordChecker : BaseChecker
{
    public override void Check(object? request)
    {
        if (request is Person person)
        {
            if (!string.IsNullOrWhiteSpace(person.Password) && person.Password.Length>6)
            {
                Console.WriteLine("Password is correct...");
                Next?.Check(request);
            }
            else
            {
                Console.WriteLine("Password is INVALID... !!!");
            }
        }
    }
}

