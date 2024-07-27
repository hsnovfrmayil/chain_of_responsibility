using System;
namespace ChainOfResponsibility.Models.Abstracts;

public abstract class BaseChecker : IChecker
{
    public IChecker? Next { get; set; }

    public abstract void Check(object? request);
}

