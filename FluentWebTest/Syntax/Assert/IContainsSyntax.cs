using System;
using FluentWebTest.Model;

namespace FluentWebTest.Syntax.Assert
{
    public interface IContainsSyntax : IAndSyntax
    {
        IAndSyntax WithValue(dynamic value);
        IAndSyntax ThatMeets(Func<Element, bool> predicate);

    }
}