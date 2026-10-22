using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContainsDuplicateII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 }; int k = 3;
            Program program = new Program();
     
            Console.WriteLine(program.ContainsNearbyDuplicate(nums, k));

        
            Console.ReadLine();
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
           
            for(int i=0;i<nums.Length;i++)
            {
                for(int j= 1+i; j< nums.Length; j++ )
                {

                    if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
