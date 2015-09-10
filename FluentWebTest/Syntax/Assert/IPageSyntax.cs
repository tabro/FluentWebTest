namespace FluentWebTest.Syntax.Assert
{
    public interface IPageSyntax
    {
        IContainsSyntax Contains(string selector);
        IContainsSyntax Contains(int count, string selector);
        IContainsNoSyntax ContainsNo(string selector);
    }
}