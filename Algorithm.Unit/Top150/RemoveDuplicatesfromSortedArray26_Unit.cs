namespace Algorithm.Unit;

[TestFixture]
public class RemoveDuplicatesfromSortedArray26_Unit
{
    private RemoveDuplicatesfromSortedArray26 myTestee;

    [SetUp]
    public void SetUp()
    {
        myTestee = new RemoveDuplicatesfromSortedArray26();
    }

    [Test]
    public void RemoveDuplicates_Act_Condition1()
    {
        var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var res = myTestee.RemoveDuplicates(nums);

        Assert.That(res, Is.EqualTo(5));

    }

    [Test]
    public void RemoveDuplicates_Act_Condition2()
    {
        var nums = new int[] { 1, 1, 2 };
        var res = myTestee.RemoveDuplicates(nums);

        Assert.That(res, Is.EqualTo(2));

    }
}
