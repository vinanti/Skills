//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Coding
//{
//    class Q0015
//    {
//        static void Main1()
//        {
//            ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
//        }
//        public static IList<IList<int>> ThreeSum(int[] nums)
//        {
//            Array.Sort(nums);
//            List<IList<int>> result = new List<IList<int>>();
//            for (int i = 0; i < nums.Length; i++)
//                for (int j = i + 1; j < nums.Length; j++)
//                    for (int k = j + 1; k < nums.Length; k++)
//                        if (nums[i] + nums[j] + nums[k] == 0)
//                        {
//                            if (result.Count == 0)
//                                result.Add(new List<int> { nums[i], nums[j], nums[k] });
//                            else if (result[result.Count - 1][0] != nums[i] || result[result.Count - 1][1] != nums[j] |\ result[result.Count - 1][2] != nums[k])
//                                result.Add(new List<int> { nums[i], nums[j], nums[k] });
//                        }
//            return result;
//        }
//    }
//}
