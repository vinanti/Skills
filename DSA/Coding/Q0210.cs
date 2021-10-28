using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0210
    {
        static void Main210()
        {
            FindOrder(2, new int[][] { new int[] { 1, 0 } });
        }
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            List<int> result = new List<int>();
            Dictionary<int, List<int>> bucket = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
                if (!bucket.ContainsKey(prerequisites[i][0])) bucket.Add(prerequisites[i][0], new List<int>() { prerequisites[i][1] });
                else bucket[prerequisites[i][0]].Add(prerequisites[i][1]);

            List<int> courses = new List<int>();
            for (int i = 0; i < numCourses; i++)
                courses.Add(i);
            while (bucket.Count > 0)
            {
                List<int> tempCourses = new List<int>(courses);
                for (int i = 0; i < tempCourses.Count; i++)
                {
                    int course = tempCourses[i];
                    if (!bucket.ContainsKey(course))
                    {
                        result.Add(course);
                        courses.Remove(course);
                        Dictionary<int, List<int>> tempBucket = new Dictionary<int, List<int>>(bucket);
                        foreach (KeyValuePair<int, List<int>> pair in tempBucket)
                        {
                            pair.Value.Remove(course);
                            if (pair.Value.Count == 0) bucket.Remove(pair.Key);
                        }
                    }
                }
            }
            return result.ToArray();
        }
    }
}
