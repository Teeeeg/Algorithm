namespace Algorithm.Unit;

public class MajorityElement169_UT
{
    private MajorityElement169 myTestee;

    [SetUp]
    public void SetUp()
    {
        myTestee = new MajorityElement169();
    }

    [Test]
    public void MajorityElement_Pass_Condition1()
    {
        var nums = new int[] { 1, 2, 2, 2 };
        var res = myTestee.MajorityElement(nums);

        Assert.That(res, Is.EqualTo(2));
    }


    [Test]
    public void MajorityElement_Pass_Condition2()
    {
        var nums = new int[] { 1, 1, 2, 2, 2 };
        var res = myTestee.MajorityElement(nums);

        Assert.That(res, Is.EqualTo(2));
    }


    [Test]
    public void MajorityElement_Pass_Condition3()
    {
        var nums = new int[] { 1, 2, 2, 2, 3, 3, 3, 3, 3 };
        var res = myTestee.MajorityElement(nums);

        Assert.That(res, Is.EqualTo(3));
    }
}
