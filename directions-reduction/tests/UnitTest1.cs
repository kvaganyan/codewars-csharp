using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }
    [Test]
    public void Test2()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test3()
    {
        string[] a = new string[] { "WEST", "SOUTH", "WEST" };
        string[] b = new string[] { "WEST", "SOUTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test4()
    {
        string[] a = new string[] { "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test5()
    {
        string[] a = new string[] { "WEST", "WEST", "WEST", "SOUTH", "NORTH", "WEST" };
        string[] b = new string[] { "WEST", "WEST", "WEST", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test6()
    {
        string[] a = new string[] { "SOUTH", "SOUTH", "SOUTH" };
        string[] b = new string[] { "SOUTH", "SOUTH", "SOUTH" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test7()
    {
        string[] a = new string[] { "SOUTH", "NORTH" };
        string[] b = new string[] { };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test8()
    {
        string[] a = new string[] { "WEST", "NORTH", "WEST", "NORTH" };
        string[] b = new string[] { "WEST", "NORTH", "WEST", "NORTH" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test9()
    {
        string[] a = new string[] { "WEST", "WEST" };
        string[] b = new string[] { "WEST", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test10()
    {
        string[] a = new string[] { "WEST", "WEST", "NORTH", "SOUTH", "SOUTH", "SOUTH", "WEST", "SOUTH", "WEST" };
        string[] b = new string[] { "WEST", "WEST", "SOUTH", "SOUTH", "WEST", "SOUTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test11()
    {
        string[] a = new string[] { "SOUTH", "WEST", "SOUTH", "NORTH" };
        string[] b = new string[] { "SOUTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test12()
    {
        string[] a = new string[] { "WEST", "NORTH", "WEST", "SOUTH", "NORTH" };
        string[] b = new string[] { "WEST", "NORTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }

    [Test]
    public void Test13()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "WEST" };
        string[] b = new string[] { "SOUTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }


    [Test]
    public void Test14()
    {
        string[] a = new string[] { "WEST", "SOUTH", "NORTH", "WEST", "EAST" };
        string[] b = new string[] { "WEST"};
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }


    [Test]
    public void Test15()
    {
        string[] a = new string[] { "SOUTH", "SOUTH", "WEST", "WEST", "EAST", "SOUTH", "WEST" };
        string[] b = new string[] { "SOUTH", "SOUTH", "WEST", "SOUTH", "WEST" };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }


    [Test]
    public void Test16()
    {
        string[] a = new string[] { "WEST", "SOUTH", "NORTH", "EAST" };
        string[] b = new string[] { };
        Assert.AreEqual(b, DirReduction.dirReduc(a));
    }
}