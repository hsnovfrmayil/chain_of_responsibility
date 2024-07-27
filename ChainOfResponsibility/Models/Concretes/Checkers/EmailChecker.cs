using System;
using ChainOfResponsibility.Models.Abstracts;

namespace ChainOfResponsibility.Models.Concretes.Checkers;

public class EmailChecker : BaseChecker
{
    public override void Check(object? request)
    {
        if (request is Person person)
        {
            if (!string.IsNullOrWhiteSpace(person.Email) && person.Email.Contains("@"))
            {
                Console.WriteLine("Email is correct...");
                Next?.Check(request);
            }
            else
            {
                Console.WriteLine("Email is INVALID... !!!");
            }
        }
    }
}

