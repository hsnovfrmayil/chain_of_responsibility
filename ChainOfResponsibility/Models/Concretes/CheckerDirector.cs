using System;
using ChainOfResponsibility.Models.Abstracts;
using ChainOfResponsibility.Models.Concretes.Checkers;

namespace ChainOfResponsibility.Models.Concretes;

public class CheckerDirector
{
	public ICheckerBuilder? CheckerBuilder { get; set; }

	public void MakePersonCheck(Person person)
	{
		UsernameChecker usernameChecker = new UsernameChecker();
		EmailChecker emailChecker = new EmailChecker();
		PasswordChecker passwordChecker = new PasswordChecker();


		usernameChecker.Next = emailChecker;
		emailChecker.Next = passwordChecker;

		usernameChecker.Check(person);

	}
}

