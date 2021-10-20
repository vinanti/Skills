using System;
using System.Collections.Generic;
namespace Coding
{
    class Q0722
    {
        static void Main722()
        {

            RemoveComments(new string[] { "main() { ", "  int a = 1; /* Its comments here ", "", "  ", "  */ return 0;", "} " });
        }
        public static IList<string> RemoveComments(string[] source)
        {
            List<string> code = new List<string>();
            bool multiLineComment = false;
            bool AfterBeforeComment = false;
            string codeAfterBeforeComment = string.Empty;
            for (int i = 0; i < source.Length; i++)
            {
                string current = source[i];
                if (current.StartsWith("/*"))
                {
                    if (!current.EndsWith("*/"))
                    {
                        multiLineComment = true;
                        current = "  ";
                    }
                    else
                    {
                        current = string.Empty;
                    }
                }
                else if (current.Contains("/*"))
                {
                    if (!current.Contains("*/"))
                    {
                        multiLineComment = true;
                        AfterBeforeComment = true;
                        codeAfterBeforeComment = current.Substring(0, current.IndexOf("/*"));
                    }
                    else if (current.Contains("*/"))
                    {
                        codeAfterBeforeComment = current.Substring(0, current.IndexOf("/*")) + current.Substring(current.IndexOf("*/") + 2, current.Length - current.IndexOf("*/") - 2);
                    }
                }
                if (current.EndsWith("*/"))
                {
                    current = string.Empty;
                    multiLineComment = false;
                }
                if (current.Contains("*/"))
                {
                    codeAfterBeforeComment += current.Substring(current.IndexOf("*/") + 2, current.Length - current.IndexOf("*/") - 2);
                    multiLineComment = false;
                    AfterBeforeComment = false;
                }

                if (current.Trim().StartsWith("//")) current = "  ";

                if (!AfterBeforeComment && codeAfterBeforeComment.Length > 0) {
                    code.Add(codeAfterBeforeComment);
                    codeAfterBeforeComment = string.Empty;
                } 
                else if (!multiLineComment && current.Length > 0) code.Add(current);
            }
            return code;
        }
    }
}
