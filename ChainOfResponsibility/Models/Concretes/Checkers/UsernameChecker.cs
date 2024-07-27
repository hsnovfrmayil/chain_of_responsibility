using System;
using ChainOfResponsibility.Models.Abstracts;

namespace ChainOfResponsibility.Models.Concretes.Checkers;

public class UsernameChecker : BaseChecker
{
    public override void Check(object? request)
    {
        if(request is Person person)
        {
            if(!string.IsNullOrWhiteSpace(person.Username) && person.Username.Length>6)
            {
                Console.WriteLine("Username is correct...");
                Next?.Check(request);
            }
            else
            {
                Console.WriteLine("Username is INVALID... !!!");
            }
        }
    }
}

