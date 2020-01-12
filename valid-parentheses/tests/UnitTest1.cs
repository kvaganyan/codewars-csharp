using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        string a = "(())((()())())";
        //
        Assert.AreEqual(true, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test2()
    {
        string a = "((())())";
        //
        Assert.AreEqual(true, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test3()
    {
        string a = "))()(";
        //))(
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test4()
    {
        string a = "()";
        //
        Assert.AreEqual(true, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test5()
    {
        string a = ")(()(((()";
        //)((((
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test6()
    {
        string a = "((())";
        //(
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test7()
    {
        string a = "()())";
        //)
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test8()
    {
        string a = "()))((";
        //))((
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test9()
    {
        string a = "(";
        //(
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test10()
    {
        string a = ")((()";
        //)((
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test11()
    {
        string a = "((2=2))(((1 = 1)('a' = 'c'))(8 7 8))";
        //
        Assert.AreEqual(true, Parentheses.ValidParentheses(a));
    }

    [Test]
    public void Test12()
    {
        string a = ")))(((";
        //)))(((
        Assert.AreEqual(false, Parentheses.ValidParentheses(a));
    }
}