using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        static public int a;
        public string MysteryFunc(string str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ("0123456789".Contains(str[i]))
                {
                    for (int x = 0; x < int.Parse(str[i].ToString()); x++) 
                    { 
                        s += str[(i - 1)]; 
                    }
                }
            }
            return s;
        }
    }
    
}
