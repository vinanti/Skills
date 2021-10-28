using System;
using System.Collections.Generic;

namespace Coding
{
    public class Interval
    {
        public int start;
        public int end;

        public Interval() { }
        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;
        }
    }
    class Q0759
    {
        static void Main759()
        {
            List<Interval> result = (List<Interval>)EmployeeFreeTime(new List<IList<Interval>>() {
                new List<Interval>(){ new Interval(1, 3), new Interval(6, 7) },
                new List<Interval>(){ new Interval(2, 4) },
                new List<Interval>(){ new Interval(2, 5), new Interval(9, 12) }
            });

            //List<Interval> result = (List<Interval>)EmployeeFreeTime(new List<IList<Interval>>() {
            //    new List<Interval>(){ new Interval(7, 24), new Interval(29, 33), new Interval(45, 57), new Interval(66, 69), new Interval(94, 99) },
            //    new List<Interval>(){ new Interval(6, 24), new Interval(43, 49), new Interval(56, 59), new Interval(61, 75), new Interval(80, 81) },
            //    new List<Interval>(){ new Interval(5, 16), new Interval(18, 26), new Interval(33, 36), new Interval(39, 57), new Interval(65, 74) },
            //    new List<Interval>(){ new Interval(9, 16), new Interval(27, 35), new Interval(40, 55), new Interval(68, 71), new Interval(78, 81) },
            //    new List<Interval>(){ new Interval(0, 25), new Interval(29, 31), new Interval(40, 47), new Interval(57, 87), new Interval(91, 94) }
            //});
        }

        public static IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule)
        {
            List<Interval> blockedTime = new List<Interval>();
            foreach (List<Interval> intervalList in schedule)
                blockedTime.AddRange(intervalList);

            int start = int.MaxValue, end = int.MinValue;
            for (int i = 0; i < blockedTime.Count; i++)
            {
                if (blockedTime[i].start != -1 && blockedTime[i].end != -1)
                {
                    for (int j = i + 1; j < blockedTime.Count; j++)
                    {
                        if (blockedTime[j].start != -1 && blockedTime[j].end != -1)
                            if ((blockedTime[j].start >= blockedTime[i].start && blockedTime[j].start <= blockedTime[i].end)
                            || (blockedTime[j].end >= blockedTime[i].start && blockedTime[j].end <= blockedTime[i].end)
                            || (blockedTime[i].start >= blockedTime[j].start && blockedTime[i].start <= blockedTime[j].end)
                            || (blockedTime[i].end >= blockedTime[j].start && blockedTime[i].end <= blockedTime[j].end))
                            {
                                blockedTime[i].start = blockedTime[i].start < blockedTime[j].start ? blockedTime[i].start : blockedTime[j].start;
                                blockedTime[i].end = blockedTime[i].end > blockedTime[j].end ? blockedTime[i].end : blockedTime[j].end;
                                blockedTime[j].start = -1;
                                blockedTime[j].end = -1;
                            }
                    }
                    start = Math.Min(start, blockedTime[i].start);
                    end = Math.Max(end, blockedTime[i].end);
                }
            }

            int[] time = new int[end + 1];
            for (int i = 0; i <= end; i++)
                if (i >= start) time[i] = i;
                else time[i] = -1;

            List<Interval> result = new List<Interval>();
            for (int i = 0; i < blockedTime.Count - 1; i++)
            {
                if (blockedTime[i].start != -1 && blockedTime[i].end != -1)
                {
                    for (int j = blockedTime[i].start+1; j < blockedTime[i].end; j++)
                        time[j] = -1;
                }
            }

            int currStart = -1;
            for (int i = start; i < end-1; i++)
            {
                if (time[i] != -1 && time[i + 1] != -1 && currStart == -1) currStart = time[i];
                else if (time[i] != -1 && time[i+1] == -1 && currStart != -1) 
                {
                    result.Add(new Interval(currStart, time[i]));
                    currStart = -1;
                }
            }
            return result;
        }
    }
}
