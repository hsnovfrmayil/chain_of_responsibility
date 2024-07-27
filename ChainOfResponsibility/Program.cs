using ChainOfResponsibility.Models.Abstracts;
using ChainOfResponsibility.Models.Concretes;

Console.WriteLine("Hello, World!");



Person person = new User("HasanZade","hesen@gmail.com","12345678");

CheckerDirector checkerDirector = new CheckerDirector();

checkerDirector.MakePersonCheck(person);

