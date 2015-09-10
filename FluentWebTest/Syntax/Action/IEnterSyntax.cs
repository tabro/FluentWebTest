using FluentWebTest.Model;

namespace FluentWebTest.Syntax.Action
{
    public interface IEnterSyntax
    {
        IActionSyntax InTo(string selector);
        IActionSyntax InTo(Element element);
    }
}