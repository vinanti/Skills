using System;

namespace Coding
{
    class Q0065
    {
        static void Main01()
        {
            IsNumber("3.");
        }
        public static bool IsNumber(string s)
        {
            if (s.IndexOf(".") != s.LastIndexOf(".")) return false;
            s = s.ToLower();
            string[] sArray = s.Split("e");
            if (sArray.Length > 2) return false;
            string validNumber = "0123456789";
            
            string beforeExp = sArray[0];
            if (beforeExp.Length == 0) return false;
            if (beforeExp.LastIndexOf("+") > 0) return false;
            if (beforeExp.LastIndexOf("-") > 0) return false;
            if (!validNumber.Contains(beforeExp[0]) && beforeExp[0] != '+' && beforeExp[0] != '-' && beforeExp[0] != '.') return false;
            if ((beforeExp[0] == '+' || beforeExp[0] == '-' || beforeExp[0] == '.') && beforeExp.Length==1) return false;
            for (int i = 1; i < beforeExp.Length-1; i++)
                if (!validNumber.Contains(beforeExp[i])) return false;
            if (!validNumber.Contains(beforeExp[beforeExp.Length-1]) && beforeExp[beforeExp.Length - 1] != '.') return false;

            if (sArray.Length > 1)
            {
                string afterExp = sArray[1];
                if (afterExp.Length == 0) return false;
                if (afterExp.Contains(".")) return false;
                if (afterExp.LastIndexOf("+") > 0) return false;
                if (afterExp.LastIndexOf("-") > 0) return false;
                if (!validNumber.Contains(afterExp[0]) && afterExp[0] != '+' && afterExp[0] != '-') return false;
                if ((afterExp[0] == '+' || afterExp[0] == '-') && afterExp.Length == 1) return false;
                for (int i = 1; i < afterExp.Length; i++)
                    if (!validNumber.Contains(afterExp[i])) return false;
            }
            
            return true;
        }
    }
}
