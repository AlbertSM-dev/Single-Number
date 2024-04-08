public class Solution {
    public int SingleNumber(int[] nums) {
        List<int> newList = new List<int>();

        for(int i = 0; i < nums.Count(); i++)
        {
            if(newList.Contains(nums[i]))
            {
                newList.Remove(nums[i]);
            }
            else
            {
                newList.Add(nums[i]);
            }          
        }
        return newList[0];
    }
}
