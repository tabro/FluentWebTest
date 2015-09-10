using FluentWebTest.Syntax;
using NUnit.Framework;

namespace FluentWebTest.Tests
{
    [TestFixture]
    public class Test : UiTest
    {
        [Test]
        public void T()
        {
            I.Open("www.google.com")
                .Enter("something").InTo(".searchField")
                .Click(".searchButton");

            I.Assert.Page.Contains(".someElement")
                .And.Page.Contains(5, "someOtherElement")
                .And.Page.ContainsNo("input").WithValue(42);
        }
    }
}