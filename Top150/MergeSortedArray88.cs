using AlgorithmAD.Extension;

namespace AlgorithmAD.Top150;

public class MergeSortedArray88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var index1 = m - 1;
        var index2 = n - 1;
        var index = m + n - 1;

        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] >= nums2[index2])
            {
                nums1[index] = nums1[index1];
                index1 -= 1;
            }
            else
            {
                nums1[index] = nums2[index2];
                index2 -= 1;
            }

            index -= 1;
        }

        SortLast(index1, nums1);
        SortLast(index2, nums2);

        void SortLast(int index1, int[] nums)
        {
            while (index1 >= 0)
            {
                nums1[index] = nums[index1];
                index1 -= 1;
                index -= 1;
            }
        }

    }


    public void Test()
    {
        var nums1 = new int[] { 0 };
        var nums2 = new int[] { 2, 5, 6 };
        var m = 0;
        var n = 1;

        Merge(nums1, m, nums2, n);

        nums1.Print();
    }
}
