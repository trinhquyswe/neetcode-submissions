public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        ValueTuple<int, int>[] sortValueTupleArr = new ValueTuple<int, int>[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            sortValueTupleArr[i] = new ValueTuple<int, int>(nums[i], i);
        }
        sortValueTupleArr = sortValueTupleArr.OrderBy(x => x.Item1).ToArray();
        int left = 0;
        int right = sortValueTupleArr.Length - 1;
        while (left < right)
        {
            int sum = sortValueTupleArr[left].Item1 + sortValueTupleArr[right].Item1;
            if (sum == target)
            { 
                return new int[] {
                    Math.Min(sortValueTupleArr[left].Item2, sortValueTupleArr[right].Item2),
                    Math.Max(sortValueTupleArr[left].Item2, sortValueTupleArr[right].Item2) };
            }
            else if (sum < target)
            { 
                left++;
            }
            else
            { 
                right--;
            }
        }
        return new int[] { -1, -1 }; // Return an invalid result if no solution is found
    }
}
