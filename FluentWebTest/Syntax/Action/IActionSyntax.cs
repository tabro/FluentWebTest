using System;
using FluentWebTest.Model;
using FluentWebTest.Syntax.Assert;

namespace FluentWebTest.Syntax.Action
{
    public interface IActionSyntax
    {
        IEnterSyntax Enter(dynamic text);
        IActionSyntax Click(string selector);
        IActionSyntax Click(Element element);
        IActionSyntax Open(string uri);
        IActionSyntax Open(Uri uri);
        IActionSyntax ScrollTo(int x, int y);
        IActionSyntax ScrollTo(string selector);
        IActionSyntax ScrollTo(Element element);
        IAssertSyntax Assert { get; }
    }
}