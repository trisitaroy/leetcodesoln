using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace googlearray
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAnagram();


        }

        public static void Convertstring()
        {
            string s = "this is 'a string' and 'not int' hello trisita how 'are you' kemon";
            int start = 0;
            int len = 0;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                len++;
                if (ch[i].Equals(' '))
                {
                    Console.WriteLine(s.Substring(start, len));
                    start = i+1;
                    len = 0;

                }
                else if (ch[i].Equals('\''))
                {
                    string s1 = "";
                    i++;
                    while (!ch[i].Equals('\''))
                    {
                       
                        s1 = s1 + ch[i];
                        i++;
                    }
                    Console.WriteLine(s1);
                    i++;
                    start = i + 1;
                    len = 0;

                }



            }
        }
        public static void ToLowerCase()
        {
            string s = "Hello";

            string x = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] <= 90 && (int)s[i] >= 65)
                {
                    int asc = (int)s[i] + 32;

                    x = x + (char)asc;
                }
                else
                    x = x + s[i];

            }
        }
        public static void ThreeSum()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 10 }; // -4 -1 -1 0 1 2
            int target = 18;

            IList<IList<int>> list = new List<IList<int>>();

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {

                    int start = j + 1;
                    int end = nums.Length - 1;

                    while (start < end)
                    {
                        if (nums[i] + nums[j] + nums[start] + nums[end] == target)
                        {
                            IList<int> temp = new List<int>();
                            temp.Add(nums[i]);
                            temp.Add(nums[j]);
                            temp.Add(nums[start]);
                            temp.Add(nums[end]);

                            list.Add(temp);
                            break;

                        }
                        else if (nums[i] + nums[j] + nums[start] + nums[end] < target)
                            start++;

                        else // A[i] + A[l] + A[r] > sum
                            end--;
                    }
                }
            }


        }
        public static void TwoSumpointer()
        {
            int[] op;
            int[] nums = { 2, 1, 4, 7 };//1 2 4 7
            int target = 3;//6
            Array.Sort(nums);
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                if (nums[start] + nums[end] == target)
                {
                    op = new int[] { nums[start], nums[end] };

                }
                else if (nums[start] + nums[end] < target)
                    start++;

                else
                    end--;


            }


        }
        public static void TwoSum()
        {
            int[] arr = { 1, 2, 10, 7 };
            int sum = 11;
            int[] op = new int[2];
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];

                // checking for condition
                if (s.Contains(temp))
                {
                    op[0] = arr[i];
                    op[1] = sum - arr[i];
                }
                s.Add(arr[i]);
            }

        }
        public static void RemoveDuplicatesUsinghas()
        {
            int[] nums = { 1, 1, 2, 2, 3, 4, 5, 5 };
            HashSet<int> map = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i]);

            }
            map.CopyTo(nums);

        }
        public static void RemoveDuplicates() // this approach only for sorted array
        {
            int[] nums = { 1, 1, 2, 5, 5, 11, 11 };
            //int[] temp = new int[nums.Length];
            int j = 0;


            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j] = nums[i];
                    j++;

                }
            }
            nums[j] = nums[nums.Length - 1];

        }
        // easy way to do using map bt o(n) space
        //this soln will work only if the input array is in range of 0 to n
        public static void RemoveDuplicatesUnSorted()
        {
            int[] nums = { 4, 3, 4,2,1,3 };
            ArrayList result = new ArrayList();
            foreach (int x in nums)
            { 
                //n = Math.Abs(n);
                int n = Math.Abs(x);
                if (nums[n - 1] > 0) 
                    nums[n - 1] *= -1;
                else 
                    result.Add(n);
            }
        }
        public static void RemoveElement()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2, 7 };
            int val = 2;
            //int[] temp = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            // nums[j] = nums[nums.Length - 1];

        }
        public static int SearchInsert() //o(n)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;

            for (int i = 0; i < nums.Length; i++)
            {
                 if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                    return i;

            }
            // If all elements are smaller
            // than K
            return nums.Length;


        }
        // if n is power of 2 then binary number of n and n-1 is 0
        // n=4 => 100
        //n-1=3 => 011
        // 100 & 011 = 000
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & n - 1) == 0;
        }
        //O(log N)
        public static void SearchInsertOPT() //binarysearch
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            int x;
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    x = mid;
                    break;
                }
                   
                else if (nums[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            //low ans insert position if not found
       }
        static void MaxSubArraySum()
        {
            int[] nums = { 1,2,-5,4 ,8};
            int max = 0;
            int cur = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                cur = cur + nums[i];
                max = Math.Max(max, cur);
                if (cur < 0)
                    cur = 0;
            }

        }
        static int SubArrayTarget()
        {
            
            int[] arr = { 1,2,5,4 };
            int sum = 1;
            int curr_sum = arr[0],
            start = 0;
            int countofarr = 0;
            for (int  i = 1; i <= arr.Length; i++)
            {
                while (Math.Abs(curr_sum) > sum && start < i - 1)
                {
                    curr_sum = curr_sum - arr[start];
                    start++;
                }
                if (curr_sum == sum)
                {
                    countofarr++;
                    int p = i - 1;
                    Console.WriteLine("Sum found between indexes " + start + " and " + p);
                   
                }
                // Add this element to curr_sum
                if (i < arr.Length)
                    curr_sum = curr_sum + arr[i];
            }
            Console.WriteLine("No subarray found");
            return countofarr;
        }
        public static void GetConcatenation()
        {
            int[] nums = { 1, 2, 1 };
            int[] temp = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                temp[i] = nums[i];
                temp[i + nums.Length] = nums[i];
            }

        }
        //o(n+m)
        public static void Merge()
        {
            int[] n1 = { 1, 2, 3 };
            int[] n2 = { 2, 5, 6 };
            int[] temp = new int[n1.Length + n2.Length];
            int i = 0, j = 0, k = 0;
            // Traverse both array
            while (i < n1.Length && j < n2.Length)
            {
                if (n1[i] < n2[j])
                {
                    temp[k++] = n1[i];
                    i++;
                }

                else
                {
                    temp[k++] = n2[j];
                    j++;
                }
            }
            while (i < n1.Length)
            {
                temp[k++] = n1[i];
                i++;
            }
            while (j < n2.Length)
            {
                temp[k++] = n2[j];
                j++;
            }
            //Array.Copy(temp,n1,6);           


        }

        public static void FindMedianSortedArrays()
        {
            int[] n1 = { 1, 3};
            int[] n2 = { 2};
            int[] temp = new int[n1.Length + n2.Length];
            int j = 0;
            int p = 0;
            int q = 0;
            while (p<n1.Length && q < n2.Length)
            {
                if (n1[p] < n2[q])
                {
                    temp[j++] = n1[p];
                    p++;
                }
                else
                {
                    temp[j++] = n2[q];
                   q++;

                }
            }
            if(q < n2.Length)
            {
                while (q < n2.Length)
                {
                    
                        temp[j++] = n2[q];
                        q++;
                }
            }
            if (p < n1.Length)
            {
                while (p < n1.Length)
                {

                    temp[j++] = n1[p];
                    p++;
                }
            }
            double median = 0;
            if (temp.Length % 2 == 0)
            {
                int x =temp.Length / 2;

                median = (double)((temp[x - 1] + temp[x])) / 2;


            }
            else
            {
                median = temp[(temp.Length - 1) / 2];

            }
           

        }
        //brute force tc on2
        public static void MaxProfit()
        {
            int sum = 0;
            int[] prices = { 7, 1, 2, 2, 6, 4 };
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    sum += prices[i + 1] - prices[i];
                }
            }
            //
        
        }
        //on       
        public static void SingleNumber()
        {
            int[] nums = { 1, 1, 2, 4, 2 };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int single = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = dic[nums[i]] + 1;


                }
                else
                {
                    dic.Add(nums[i], 1);
                }

            }

            foreach (KeyValuePair<int, int> d in dic)
            {
                if (d.Value == 1)
                {
                    single = d.Key;
                    break;

                }


            }



        }

        public static int singleNumberxor() // a^b 2^2 =0
        {
            int[] nums = { 1, 1, 2, 4, 2 };
            int ans = 0;
            foreach (int x in nums)
            {
                ans = ans ^ x;
            }

            return ans;
        }
        public static int[] PlusOne()
        {
            int[] digits = {8,9};
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++; 
                    return digits;
                }
            }

            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;
            return newNumber;

        }
        //
        public static void MoveZeroestoRight()
        {
            int[] arr = { 1,0,1 }; // 1 0 0 3 12
            int count = 0;

           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                arr[count++] = arr[i];

            }
            while (count < arr.Length)
                arr[count++] = 0;

        }
        public static void MoveZeroesToLeft()
        {
            int[] arr = { 2, 0, 3, 0, 1 }; // 0 0 2 3 1
            int count = 0;
            int i = arr.Length - 1;
            int j = i;

            while (j >= 0)
            {
                if (arr[j] != 0)
                {
                    int t = arr[i];

                    arr[i] = arr[j];

                    arr[j] = t;
                    i--;
                }

                j--;

            }
        }
        //on2
        public static void MissingNumber()
        {
            int[] nums = { 1, 2, 3, 6 };
            List<int> lt = new List<int>();
            //4 5
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] != 1)
                {
                    int dif = nums[i + 1] - nums[i] - 1;
                    while (dif > 0)
                    {
                        lt.Add(nums[i] + dif);
                        dif--;

                    }

                }

            }
        }

        public static void MissingNumberopt()
        {
            int[] nums = { 10,11,13,15 };
            List<int> lt = new List<int>();
            //4 5
            //Array.Sort(nums);
            int c = 0;
            for (int i = nums[0]; i <= nums[nums.Length - 1]; i++)
            {
                if (nums[c] != i)
                {
                    lt.Add(i);

                }
                else
                    c++;

            }
        }

        public static void MajorityElement()
        {
            int[] nums = { 1, 2, 2, 3, 4, 5, 5, 5 };
           // int ocr = nums.Length / 2;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = dic[nums[i]] + 1;

                }
                else
                    dic.Add(nums[i], 1);

            }


        }
        public static void MajorityElementopt()
        {
            int[] nums = { 1, 2, 2, 3,4,4 };
            int ocr = nums.Length / 2; //rule
            int count = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                    count = 1;

                if (count > ocr)
                {

                }
            }

        }
        public static void InsertionArry()
        {

            int[] nums1 = { 4, 5, 9 }, nums2 = { 4, 4, 5, 9, 9 };
            Array.Sort(nums2);
            Array.Sort(nums1);
            HashSet<int> hs = new HashSet<int>();
            int i = 0, j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                    j++;
                else if (nums1[i] < nums2[j])
                    i++;
                else
                {
                    hs.Add(nums1[i]);
                    i++;
                    j++;
                }

            }
            int[] res = new int[hs.Count];
            hs.CopyTo(res);

        }

        public static void NumIdenticalPairs()
        {
            int[] nums = { 1, 2, 3, 1, 3 }; // 111233
            int c = 0;
            Dictionary<int, int> hs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (hs.ContainsKey(nums[i]))
                {
                    c = c + hs[nums[i]];
                    hs[nums[i]] = hs[nums[i]] + 1;

                }
                else
                {
                    hs.Add(nums[i], 1);
                }

            }


            //   int x = (4 * (4 - 1) / 2);

        }
        public static void FindDisappearedNumbers()
        {
            IList<int> lt = new List<int>();
            HashSet<int> hs = new HashSet<int>();
            int[] nums = { 4, 3, 2, 1, 10 }; // 1 2 3 4 7 8 10
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                hs.Add(nums[i]);

            }

            for (int i = nums[0]; i <= nums[nums.Length - 1]; i++)
            {
                if (!hs.Contains(i))
                    lt.Add(i);

            }

            //return list;


        }
        public static string RestoreString()
        {
            string s = "codeleet";
            string x = "";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            

            
            char[] ret = new char[s.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                ret[indices[i]] = s[i];
            }

            return new string(ret);

        }
        public static double FindMaxAverage()
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            double max = 0;
            double cur = 0;
            int cou = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                cur = (cur + nums[i]) / k;
                max = Math.Max(max, cur);
                if (cur < 0 || cou > k)
                {
                    cur = 0;
                    cou = 0;
                }

                cou++;
            }
            return max;
        }
        public static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }

        public static int[] Shuffle()
        {
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            int x = 0;
            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = nums[x];
                    x++;
                }
                else
                {
                    result[i] = nums[n];
                    n++;
                }
            }
            return result;
        }
        //sc:on
        public void ReverseString(char[] s)
        {

            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                st.Push(s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = st.Pop();
            }

        }
        public static void ReverseStringOPt()
        {
            char[] s = { 't', 'r','a', 'i', 's' };

            int st = 0;
            int end = s.Length - 1;

            while (st < end)
            {
                char tem = s[end];
                s[end] = s[st];
                s[st] = tem;
                st++;
                end--;
            }

        }
        public static void Reverse()
        {
            int x = 321;
         //   if (x > int.MaxValue || x< int.MinValue)
             
            int res = 0;
            while (x != 0)
            {
                res = res*10 + ( x % 10);
                x = x / 10;
            }

        }
        public static bool IsAnagram()
        {
            String s = "bbaa";
            String t = "aabb";

            int[] count = new int[256];
           
            int i;

            
            for (i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }
            for (i = 0; i < 256; i++)
                if (count[i] != 0)
                {
                    return false;
                }


            return true;
        }
        public static void IsPalindromeString()
        {
            string s = "0P";

             s = s.ToLower();
            int start = 0;
            int end = s.Length-1;

            while (start < end)
            {
                if (!char.IsLetterOrDigit(s[start]))
                    start++;
                else if (!char.IsLetterOrDigit(s[end]))
                    end--;
                else if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                    break;

            }

        }
        public static int MyAtoi()
        {
            string str = "2.14";
            int sign = 1, Base = 0, i = 0;

            // if whitespaces then ignore.
            str = str.TrimStart();
 
        // sign of number
        if (str[0] == '-') {
            sign = -1;
        }
 
        // checking for valid input
        while (
            i < str.Length
            && str[i] >= '0'
            && str[i] <= '9') {
 
            // handling overflow test case
            if (Base > int.MaxValue / 10 || (Base == int.MaxValue / 10 && str[i] - '0' > 7)) {
                if (sign == 1)
                    return int.MaxValue;
                else
                    return int.MinValue;
            }
            Base = 10 * Base + (str[i++] - '0');
        }
        return Base * sign;
    }
        public static void Rotate()
        {
            int[] nums = { 1, 2, 4, 8 };
            int k = 2;
            //rotate by k
            for (int j = 0; j < k; j++)
            {
                int temp = nums[0];
                // rotate by 1
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = temp;

            }
        }
        public static void RotateUsingSpace()
        {
            int[] nums = { 1, 2, 3, 4, 8 };//34812 
            int k = 2;
            int[] result = new int[k];
            result[0] = nums[0];
            result[1] = nums[1];
            for (int i = 0; i <= nums.Length - 1 - k; i++)
            {
                nums[i] = nums[i + k];
            }

            nums[nums.Length - 2] = result[0];
            nums[nums.Length - 1] = result[1];

        }
        //tc:on sc :o 1
        // rev(0 to k-1) // 2 1 3 4 8 9
        // rev(k to n-1) // 2 1 9 8 4 3
        // rev all // 3 4 8 9 1 2
        //left rotate
        public static void RotateOPT()
        {
            int[] nums = {1, 2 };//348912 
            int k = 3;
            k = k % nums.Length;
            reversearray(nums, 0, k - 1);
            reversearray(nums, k, nums.Length - 1);
            reversearray(nums, 0, nums.Length - 1);

        }
        public static void reversearray(int[] nums,int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }

        }
            public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] tem = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && (j != i))
                    {
                        tem[i] += 1;
                    }
                }
            }

            return tem;
        }
        public static void SmallerNumbersThanCurrentopt()
        {
            int[] nums = { 8, 1, 2, 2, 3 }; // 4 0 1 1 3
            int[] temp = (int[])nums.Clone();
            Array.Sort(nums);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //sort 1 2 2 3 8
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);


            }

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = dic[temp[i]];
            }

        }
        public static void productExceptSelf()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = new int[nums.Length];
            int initial = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = initial;//1 1 2
                initial *= nums[i];//1 2 6
            }
            initial = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= initial;
                initial *= nums[i];
            }
        }
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (dc.ContainsKey(magazine[i]))
                {
                    dc[magazine[i]] = dc[magazine[i]] + 1;
                }
                else
                    dc.Add(magazine[i], 1);
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!dc.ContainsKey(ransomNote[i]))
                    return false;
                else
                {
                    dc[ransomNote[i]] = dc[ransomNote[i]] - 1;
                }
                if (dc[ransomNote[i]] < 0)
                    return false;

            }
            return true;
        }

        public static void IsValidParent()
        {
            string s = "{[]}";
            Stack<char> p = new Stack<char>();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    p.Push(s[i]);
                else
                {
                    if (s[i] == ')' && p.Peek() == '(')
                        p.Pop();
                    if (s[i] == '}' && p.Peek() == '{')
                        p.Pop();
                    if (s[i] == ']' && p.Peek() == '[')
                        p.Pop();
                }
            }


        }
        // no adjacent house can be robbed
        public static int Rob()
        {
            int[] nums = { 2,1,1,2};
            int even = 0;
            int odd = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (i % 2 == 0)
                {
                    even += nums[i];
                    even = even > odd ? even : odd;
                }
                else
                {
                    odd += nums[i];
                    odd = even > odd ? even : odd;
                }
            }
            return even > odd ? even : odd;

        }

        static string longestCommonPrefix()
        {
            string ans = "";
            String[] a = { "flower", "flow", "flo"};
            int size = a.Length;

            /* if size is 0, return empty string */
            if (size == 0)
                return "";

            if (size == 1)
                return a[0];

            /* sort the array of strings */
            Array.Sort(a);

            string s1 = a[0];
            string s2 = a[a.Length - 1];
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                    ans += s1[i];
                else break;
            }
            return ans;
        }

        static string longestCommonPrefixOPT()
        {
            string ans = "";
            String[] a = { "flower", "flow", "flight", "flo" };
            ans = a[0];
            for(int i = 1; i < a.Length; i++)
            {
                while (a[i].IndexOf(ans) != 0)
                {
                    ans = ans.Substring(0, ans.Length - 1);

                }
            }

            return ans;

        }

        public static string LongestPalindrome()
        {
            string s= "abba";

            if (s.Length <= 1) 
                return s;
            int max_len = 1;
            int n = s.Length;
            int st = 0, end = 0;

            // Odd length
            if (s.Length % 2 != 0)
            {
                for (int i = 1; i < n - 1; ++i)
                {
                    int l = i, r = i;
                    while (l >= 0 && r < n)
                    {
                        if (s[l] == s[r])
                        {
                            l--; r++;
                        }
                        else
                            break;
                    }
                    int len = r - l - 1;
                    if (len > max_len)
                    {
                        max_len = len;
                        st = l + 1;
                        end = r - 1;
                    }
                }

            }
            else
            {
                // Even length abba
                for (int i = 0; i < n - 1; ++i)
                {
                    int l = i, r = i + 1;
                    while (l >= 0 && r < n)
                    {
                        if (s[l] == s[r])
                        {
                            l--; r++;
                        }
                        else
                            break;
                    }
                    int len = r - l - 1;
                    if (len > max_len)
                    {
                        max_len = len;
                        st = l + 1;
                        end = r - 1;
                    }
                }
            }
            

            return s.Substring(st, max_len);
        }

        public static string ReverseOnlyLetters()
        {
            string s = "a-bC-dEf-ghIj";
            int st = 0;
            char[] ch = new char[s.Length];
            ch = s.ToCharArray();
            int end = s.Length - 1;
            while (st < end)
            {
                if (s[st] == '-')
                    st++;
                else if (s[end] == '-')
                    end--;
                else
                {
                    char tem = ch[st];
                    ch[st] = ch[end];
                    ch[end] = tem;
                    st++;
                    end--;
                }

            }
            string d = new string(ch);
            return d;
        }
        static void MaxSubArrayProd()
        {
            int[] nums = {-3,-1,-1};
            int max = 0;
            int cur = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                cur = Math.Max(nums[i], cur * nums[i]); ;
                max = Math.Max(max, cur);
                //if (cur < 0)
                //    cur = 1;

            }
        }
        public static void MergeInterval()
        {
            int[][] intervals = { new int[]{ 1, 4 },new int[]{ 4, 5 } , new int[] { 6, 7 } };//{{1,5},{6,7}

            int[][] x = new int[intervals.Length][];
            x[0] = new int[2];
            x[1] = new int[2];
            
            int index = 0; //
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[index][1] >= intervals[i][0])
                {
                    x[index][0] = intervals[index][0];
                    x[index][1] = intervals[i][1];
                }
                else
                {

                    index++;                    
                     x[index] = intervals[i];

                }

            }
            

            }

        public static int FirstUniqChar()
        {
            string s = "dddccdbba";
            Dictionary<char, int> dx = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dx.ContainsKey(s[i]))
                {
                    dx[s[i]] = dx[s[i]] + 1;

                }
                else
                {
                    dx.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dx[s[i]] == 1)
                {

                    return i;
                    break;
                }
            }
            return -1;
        }

        public static void LengthOfLongestSubstring()
        {
            string s = "bbab";
            int i = 0, j = 0;
            int max = 0;

            HashSet<char> set = new HashSet<char>();

            while (j < s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    ++j;
                    max = Math.Max(set.Count, max);
                }
                else
                {
                    set.Remove(s[i]);
                    ++i;
                }
            }

           // return max;
        }
        public static void lengthOfLongestSubstringOPT()
        {
            string s = "bbabcddbc";

            HashSet<char> hs = new HashSet<char>();
            int left = 0;
            int right = 0;
            int max = 0;

            while(right<s.Length)
            {
                if (hs.Contains(s[right]))
                {
                    hs.Remove(s[left]);
                    left++;

                }
                else{
                     hs.Add(s[right]);
                     max = Math.Max(max, right - left + 1);
                     right++;

                }
            }

        }

        public static bool IsPalindrome()
        {
            int x = 121;
            Stack<int> st = new Stack<int>();
            String s = x.ToString();
            String r = "";
            for (int i = 0; i < s.Length; i++)
            {
                st.Push(s[i]-48);
            }

            for (int i = 0; i < s.Length; i++)
            {

                r = r + st.Pop();
            }
            Console.WriteLine(r);
            if (r == s)
                return true;
            else
                return false;

        }

        public static void Intersect()
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = {2,2 };
           
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int j = 0 ,i=0,k=0;
            int size = len1 > len2 ? len1 : len2;
            int[] res = new int[0];
            
            while(i<len1 && j< len2)
            {
                if (len1 > len2 && nums1[i] != nums2[j])
                {
                    i++;

                }
                else if (len1 < len2 && nums1[i] != nums2[j])
                {
                    j++;

                }
                else if (nums1[i] == nums2[j])
                {
                    res[k++] = nums1[i];

                    i++;
                    j++;

                }
                else
                {
                    i++;
                    j++;

                }
            }

        }
        public static void IntersectOPT()
        {
            int[] nums1 = { 1, 2, 1, 2 };
            int[] nums2 = { 2, 2 };

            Dictionary<int, int> dc = new Dictionary<int, int>();
            foreach(int x in nums1)
            {
                if (dc.ContainsKey(x))
                    dc[x] = dc[x] + 1;
                else
                    dc.Add(x, 1);
            }
            List<int> l = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dc.ContainsKey(nums2[i]) && dc[nums2[i]] > 0)
                {
                    l.Add(nums2[i]);
                    dc[nums2[i]]--;

                }
            }


            int[] result = new int[l.Count];
            for (int i = 0; i < l.Count; i++)
            {
                result[i] = l[i];
            }

        }

        // box = (row/3)*3 + col/3
        public static void IsValidSudoku()
        {
            char[][] board =   { new char[]{'5','3','.','.','5','.','.','.','.'},
                                 new char[]{'6','.','.','1','9','5','.','.','.'},
                                 new char[]{'.','9','8','.','.','.','.','6','.'},
                                 new char[]{'8','.','.','.','6','.','.','.','3'},
                                 new char[]{'4','.','.','8','.','3','.','.','1'},
                                 new char[]{'7','.','.','.','2','.','.','.','6'},
                                 new char[]{'.','6','.','.','.','.','2','8','.'},
                                 new char[]{'.','.','.','4','1','9','.','.','5'},
                                 new char[]{'.','.','.','.','8','.','.','7','9'} };
            HashSet<string> set = new HashSet<string>();
            bool x = true;

            for (int i=0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(board[i][j]!= '.')
                    {
                        int boxval = (i / 3) * 3 + j / 3;
                        string row = string.Concat("row", i.ToString(), board[i][j].ToString());
                        string col = string.Concat("col", j.ToString(), board[i][j].ToString());
                        string box = string.Concat("box", boxval.ToString(), board[i][j].ToString());
                        if (set.Contains(row))
                            x = false;
                        if (set.Contains(col))
                            x = false;
                        if (set.Contains(box))
                            x = false;
                        set.Add(row);
                        set.Add(col);
                        set.Add(box);

                    }
                    

                }

            }


        }
        // first transpose then rev
        public static void RotateMatrix()
        {
            int[][] matrix = { new int[] { 5, 1, 9, 11 },
                               new int[]{ 2, 4, 8, 10 },
                               new int[]{ 13, 3, 6, 7 },
                               new int[]{ 15, 14, 12, 16}
            };
            //transpose
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = i; j < matrix[0].Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j]= matrix[j][i];
                    matrix[j][i] = temp;

                }
            }
            //rev
            for (int i = 0; i < matrix.Length; i++)
            {
                int start = 0;
                int end = matrix[i].Length-1;
                while (start < end)
                {
                    int temp = matrix[i][start];
                    matrix[i][start]= matrix[i][end];
                    matrix[i][end] = temp;
                    start++;
                    end--;
                }
            }

            }

        public static void StrStr()
        {
            string haystack = "hello", needle = "lnl";

            for (int i = 0; i < haystack.Length; i++)
            {
                if ((haystack[i] == needle[0]) && (haystack.Substring(i, needle.Length) == needle))
                    i = 99;
                  //  return i;
            }


        }

    }

    }


