using System;
namespace ChainOfResponsibility.Models.Abstracts;

public interface ICheckerBuilder
{
    public BaseChecker EmailChecker { get; set; }

    public BaseChecker UsernameChecker { get; set; }

    public BaseChecker PasswordChecker { get; set; }
}

