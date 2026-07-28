public class Solution {
    HashSet<int> dedupHash = new();
    public bool hasDuplicate(int[] nums) {
        foreach(var item in nums){
            if (dedupHash.Contains(item)){
                return true;
            }
            dedupHash.Add(item);
        }
        return false;
    }
}