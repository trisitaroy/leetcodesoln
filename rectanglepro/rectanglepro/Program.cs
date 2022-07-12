using System;
using System.Collections;
using System.Collections.Generic;

namespace rectanglepro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(minParentheses());
            // Console.WriteLine(findLongestConseqSubseq()); 


            Revstring();

        }
        static void Revstring()
        {
            char[] s = { 'h', 'e','l','l','o' };
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                st.Push(s[i]);
            }

            for (int i = 0; i < s.Length ; i++)
            {
                s[i] = st.Pop();
            }

        }
            static void printMissingElements()
        {
            int[] arr = { 1, 2, 4, 5, 6, 9, 10 };
            int cnt = 0;
            for (int i = arr[0]; i <= arr[arr.Length - 1]; i++)
            {

                // Check if number is equal to the first element in
                // given array if array element match skip it increment for next element
                if (arr[cnt] == i)
                {

                    // Increment the count to check next element
                    cnt++;
                }
                else
                {

                    // Print missing number
                    Console.Write(i + " ");
                }
            }
            //Dictionary<int, bool> map = new Dictionary<int, bool>();
            //int start = arr[0];
            //int last = arr[arr.Length-1];
            //int[] op;
            //while(start <= last)
            //{
            //    map.Add(start, false);
            //    start++;
            //}
            //for(int i=0; i< arr.Length; i++)
            //{
            //    if (map.ContainsKey(arr[i]))
            //    {
            //        map[arr[i]] = true;
            //    }
            //}


        }
            static void  countSetBits()
        {
            int n = 9;
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
        }
        public static void SubarraySum()
        {
            int[] nums = {1,1,1 };
            int k = 2;
            int count = 0;
            for (int start = 0; start < nums.Length; start++)
            {
                int sum = 0;
                for (int end = start; end < nums.Length; end++)
                {
                    sum += nums[end];
                    if (sum == k)
                    {
                        Console.WriteLine($"Subarray found from Index {start} to {end}");
                        count++;

                    }
                }
            }
        }
        static int longestUniqueSubsttr()
        {
            string s = Console.ReadLine();

            // Creating a set to store the last positions of occurrence
            Dictionary<char, int> seen = new Dictionary<char, int>();
            int maximum_length = 0;

            // starting the initial point of window to index 0
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                // Checking if we have already seen the element or not
                if (seen.ContainsKey(s[end]))
                {
                    // If we have seen the number, move the start pointer
                    // to position after the last occurrence
                    start = Math.Max(start, seen[s[end]] + 1);
                }

                // Updating the last seen value of the character
                seen[s[end]] = end;
                maximum_length = Math.Max(maximum_length, end - start + 1);
            }
            return maximum_length;
        }

        public static void printSubsequence(string input,
                             string output)
        {
            // Base Case
            // If the input is empty print the output string
          
    if (input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }

            // Output is passed with including
            // the Ist character of
            // Input string
            printSubsequence(input.Substring(1),
                             output + input[0]);

            // Output is passed without
            // including the Ist character
            // of Input string
            printSubsequence(input.Substring(1),
                             output);
        }
        public static void IsStrobogrammatic()
        {
            string s = Console.ReadLine();
            bool flag = true;
            Dictionary<char, char> dc = new Dictionary<char, char>();
            dc.Add('0', '0');
            dc.Add('1', '1');
            dc.Add('8', '8');
            dc.Add('9', '6');
            dc.Add('6', '9');
           
            int start = 0, end = s.Length - 1;
            char map;
           while (start<=end)
                {
                //69
                dc.TryGetValue(s[start], out map);
                
                if (!(s[end] == map))
                {
                    flag = false;
                    break;

                }
                start++;
                end--;               
            }
            Console.WriteLine(flag);

        }
        public static int findLongestConseqSubseq()
        {
            int[] arr = { 2, 6, 1, 9, 4, 5, 3 };
            int n = 7;
            int count = 0;
            Array.Sort(arr);
            int i = 0;
            while (i+1 < n)
            {
                if (arr[i + 1] - arr[i] == 1)
                    count++;
                i++;
            }

            return count;
        }
        public static void nonrepeatingCharacter()
        {
            string s = "gghhee";
            char nonr;
            nonr = ' ';
            char[] c = s.ToCharArray();
            char uniq ;
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach(char i in c)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;                  
                }
                else
                {                           
                    d.Add(i, 1);
                }
            }

            foreach (KeyValuePair<char, int> dx in d)
            {
                if (dx.Value == 1)
                {
                    nonr= dx.Key;
                    break;
                }
                
            }
            nonr= nonr == 'c' ? '$' : nonr;
            Console.WriteLine(nonr);
        }

        public static void  reverseWords()
        {
            string actual = "i.like.this.program.very.much";
            string after = "";
            Stack<string> stack = new Stack<string>();
            foreach (string x in actual.Split('.'))
            {
                stack.Push(x);
            }

            foreach(string p in stack)
            {
                after = after + '.' + p;
            }
            string final =after.Remove(0,1);
            Console.WriteLine(final);

        }

        public static int isValidIP(string s)
        {

            string[] sp = s.Split('.');
            if (sp.Length != 4)
                return 0;
            else
            {
                foreach( string x in sp)
                {

                    if (x.Length == 0 || x.Length>3 || int.Parse(x) < 0 || int.Parse(x) > 255)

                        return 0;                  

                }
            }
            return 1;

            // code here
        }
        public static bool isbalancepar(string s)
        {
            Stack<char> st = new Stack<char>();
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {

                if (ch[i] == '(' || ch[i] == '{' || ch[i] == '[')
                    st.Push(ch[i]);
               
                if (ch[i] == ')' || ch[i] == '}' || ch[i] == ']')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    else if (!isMatching(ch[i], st.Pop()))
                        return false;
                    }                  

            }
            if (st.Count == 0)
                return true;
            else
                return false;
        }
        public static bool isMatching(char ch1,char ch2)
        {
            if (ch1 == ')' && ch2 == '(')
                return true;
            else if (ch1 == '}' && ch2 == '{')
                return true;
            else if (ch1 == ']' && ch2 == '[')
                return true;
            return false;

        }
        public static bool areAnagram()
        {
            string str1 = "silent";
            string str2 = "listeen";
            // Get lengths of both strings
            int n1 = str1.Length;
            int n2 = str2.Length;
            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2); 
            // If length of both strings is not
            // same, then they cannot be anagram
            if (n1 != n2)
            {
                return false;
            }
            // Compare sorted strings
            for (int i = 0; i < n1; i++)
            {
                if (c1[i] != c2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static int minParentheses()
        {
            string p = ")())";
            // maintain balance of string
            int bal = 0;
            int ans = 0;

            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i] == '(')
                    bal++;
                else
                    bal--;
              
                
            }
            if (bal <0)
            {

                bal = bal * -1;
            }

            return bal ;
        }

        static int No_of_rectangles(int L, int B,
                            int l, int b)
        {

            // If the dimension of the smaller
            // rectangle is greater than the
            // bigger one
            if ((l > L) || (b > B))
            {
                return -1;
            }
            else
            {

                // Return the number of smaller
                // rectangles possible
                return (L - l + 1) * (B - b + 1);
            }
        }
    }
}
