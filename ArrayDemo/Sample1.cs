using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier.ArrayDemo
{
    class Sample1
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is ");
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
                sum = sum + ar[i];
            }
            Console.WriteLine($"\naddition is : {sum}");
        }
    }
    class Sample2
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is ");
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
                if (ar[i] % 2 == 0)
                {
                    sum = sum + ar[i];
                }
            }
            Console.WriteLine($"\n even element addition is : {sum}");
        }
    }
    class Sample3
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            int[] ar1 = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                ar1[i] = ar[i];
            }
            Console.WriteLine("Copied Array is ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar1[i] + " ");
            }
        }
    }
    // copied an array
    class sample3
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            int[] ar1 = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                ar1[i] = ar[i];
            }
            Console.WriteLine("Copied Array is ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar1[i] + " ");
            }
        }
    }
    // copied array in reverse
    class sample4
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            int[] ar1 = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0, j = 4; i <= 4; i++, j--)
            {
                ar1[i] = ar[j];
            }
            Console.WriteLine("Copied Array in reverse ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar1[i] + " ");
            }
        }
    }
    // check no. is present in array
    class sample5
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nEnter a no. to check in array");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (ar[i] == n)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{n} is not present in array");
            }
            else
            {
                Console.WriteLine($"{n} is present in array {count} times");
            }
        }
    }
    // replace a elemnt of an array
    class sample6
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nEnter a no. to find");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a no. to replace");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (ar[i] == n)
                {
                    ar[i] = n1;
                }
            }
            Console.WriteLine("Modified Array");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }
    // delete one element in an array
    class sample7
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            Console.WriteLine("Enter 5 element array");
            for (int i = 0; i < 5; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nEnter a no. to delete");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (ar[i] == n)
                {
                    ar[i] = 0;
                }
            }
            Console.WriteLine("Modified Array");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }
    // average of array element
    class sample8
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is ");
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
                sum = sum + ar[i];
            }
            int avg = sum / s;
            Console.WriteLine($"\nAverage is : {avg}");
        }
    }

    // print negative element of an array and count
    class sample9
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative element are : ");
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] < 0)
                {
                    Console.Write(ar[i] + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nTotal negative numbers are : {count}");
        }
    }
    // put even and odd element separate in an array
    class sample10
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int[] even = new int[s];
            int[] odd = new int[s];
            int e, o;
            e = 0;
            o = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[e++] = ar[i];
                }
                else
                {
                    odd[o++] = ar[i];
                }
            }
            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }

    // add alternate element of an array
    class sample11
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int j = 0; j < s; j = j + 2)
            {
                sum = sum + ar[j];
            }
            Console.WriteLine("The sum of Alternate element : " + sum);
        }
    }
    // count the occurance of an element
    class sample12
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("Enter element");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int no, cnt = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
                if (arr[i] == no)
                    cnt++;

            if (cnt == 0)
            {
                Console.WriteLine(no + " Number Is Not Present");
            }
            else
            {
                Console.WriteLine(no + " Present" + cnt + "Times");
            }
        }
    }
    // add element in an array at given position
    class AddElement
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter size of array : = ");
            size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter " + size + " elements in array := ");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int pos, element;
            Console.WriteLine("Enter Position where element is to be inserted := ");
            pos = int.Parse(Console.ReadLine());

            if (pos <= size && pos != 0)
            {
                Console.WriteLine("Enter element to be inserted at position " + pos);
                element = int.Parse(Console.ReadLine());

                arr[pos - 1] = element;

                Console.Write("Revised array is := ");

                for (int i = 0; i < size; i++)

                    Console.Write(arr[i] + " ");
            }

            else
                Console.WriteLine("Invalid Position array index out of range");
        }
    }
    // update element of an array
    class UpdateNo
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("Enter element");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter any number");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter any number to replace");
            int no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                if (arr[i] == no)
                {
                    arr[i] = no1;
                }
            }
            Console.WriteLine("Modified Array is");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }


        }
    }
    // count the occurance of element
    class sample13
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("Enter element");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter any element : ");
            int no = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < s; i++)
            {
                if (arr[i] == no)
                {
                    cnt++;
                }
            }
            Console.WriteLine(no + " is present " + cnt + " times");
        }
    }

    // count the occurance of every element
    class sample14
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("Enter element");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Boolean[] found = new Boolean[s];
            for (int i = 0; i < s; i++)
            {
                found[i] = false;
            }
            for (int i = 0; i < s; i++)
            {
                if (found[i] == true)
                {
                    continue;
                }
                int cnt = 1;
                for (int j = i + 1; j < s; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        found[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine(arr[i] + " is present " + cnt + " times");
            }
        }
    }
    // separate the positive and negative element of an array
    class sample15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int[] posi = new int[s];
            int[] nega = new int[s];
            int p, n;
            p = 0;
            n = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] > 0)
                {
                    posi[p++] = ar[i];
                }
                else
                {
                    nega[n++] = ar[i];
                }
            }

            Console.WriteLine("Positive element array : ");
            for (int i = 0; i < p; i++)
            {
                Console.Write(posi[i] + " ");
            }

            Console.WriteLine("\nNegative element array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nega[i] + " ");
            }
        }
    }
    // search element and display its index
    class sample16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element of an array");
            int ele = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ele)
                {
                    Console.WriteLine($"{ele} is present at index {i}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{ele} is not present in an array");
            }
        }
    }
    // find max and min of an array
    class sample17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int max = ar[0];
            int min = ar[0];
            for (int i = 0; i < s; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
                if (ar[i] < min)
                {
                    min = ar[i];
                }
            }
            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);
        }
    }
    // count negative element of an array
    class sample18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int n;
            n = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] < 0)
                {
                    n++;
                }
            }
            Console.WriteLine("\nNegative element in array : " + n);
        }
    }
    // check prime number in an array
    class sample19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int[] prime = new int[s];
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                bool checkprime = true;
                for (int j = 2; j < ar[i] / 2; j++)
                {
                    if (ar[i] % j == 0)
                    {
                        checkprime = false;
                        break;
                    }
                }
                if (checkprime == true)
                {
                    prime[count++] = ar[i];
                }
            }
            Console.WriteLine("Prime number array");
            for (int i = 0; i < count; i++)
            {
                Console.Write(prime[i] + " ");
            }
        }
    }
    // character array
    class sample20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Char Array:=");
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }
    // check char present in array or not
    class sample21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine($"{ch} is not present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is present in array");
            }
        }
    }

    // separate array in lowercase and uppercase
    class sample22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] upper = new char[s];
            char[] lower = new char[s];
            int u = 0, l = 0;

            for (int i = 0; i < s; i++)
            {
                if (ar[i] > 'a' && ar[i] < 'z')
                {
                    lower[l++] = ar[i];
                }
                else
                {
                    upper[u++] = ar[i];
                }
            }
            Console.WriteLine("Uppercase array:");
            for (int i = 0; i < u; i++)
            {
                Console.Write(upper[i] + " ");
            }
            Console.WriteLine("\nLowercase array:");
            for (int i = 0; i < l; i++)
            {
                Console.Write(lower[i] + " ");
            }
        }
    }
    // find occurace of one element
    class sample23
    {
        static void Main()
        {
            int i = 0;
            int count = 0;
            int item = 0;
            int[] arr1 = new int[5];
            //Read numbers into array
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter item : ");
            item = int.Parse(Console.ReadLine());
            for (i = 0; i < 5; i++)
            {
                if (item == arr1[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Total occurrence of item " + item + " is : " + count);
            Console.WriteLine();
        }
    }

    // comparison of two arrays
    class sample24
    {
        static void Main(string[] args)
        {
            int s1;
            Console.WriteLine("Enter size for both array");
            s1 = int.Parse(Console.ReadLine());
            int[] ar1 = new int[s1];

            Console.WriteLine("Enter element for first array");
            for (int i = 0; i < s1; i++)
                ar1[i] = int.Parse(Console.ReadLine());

            int[] ar2 = new int[s1];
            Console.WriteLine("Enter element for second array");
            for (int i = 0; i < s1; i++)
                ar2[i] = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < s1; i++)
            {
                if (ar1[i] == ar2[i])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            if (cnt == s1)
            {
                Console.WriteLine("Both array are same");
            }
            else
            {
                Console.WriteLine("Both array are not same");
            }

        }
    }
    // compare two array equal or not
    class Equal
    {
        static void Main(string[] args)
        {
            Boolean isArrayEqual = true;
            int[] arr1 = { 1, 2, 2, 4, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 4, 5 };
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] != arr1[i])
                    {
                        isArrayEqual = false;
                        break;
                    }
                }
            }
            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");

            }
            else
            {
                Console.WriteLine("Both arrays are not equals");

            }
        }
    }

    class sample25
    {
        static void Main(string[] args)
        {
            int s1, s2;
            int j, i;
            Console.WriteLine("Enter size for first array");
            s1 = int.Parse(Console.ReadLine());
            int[] ar1 = new int[s1];

            Console.WriteLine("Enter element for first array");
            for (i = 0; i < s1; i++)
                ar1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size for second array");
            s2 = int.Parse(Console.ReadLine());
            int[] ar2 = new int[s2];

            Console.WriteLine("Enter element for second array");
            for (i = 0; i < s2; i++)
                ar2[i] = int.Parse(Console.ReadLine());

            int[] ar3 = new int[s1 + s2];
            for (i = 0, j = 0; i < s1; i++)
            {
                ar3[j++] = ar1[i];
            }
            for (i = 0; i < s2; i++, j++)
            {
                ar3[j] = ar2[i];
            }

            Console.WriteLine("Merge Array");
            for (i = 0; i < s1 + s2; i++)
            {
                Console.Write(ar3[i] + " ");
            }
        }
    }
    // merge two array
    class MergeArr
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter array 1 size:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array 1 elements:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 size:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array 2 elements:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[size1 + size2];
            for (i = 0, j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < size2; i++)
            {
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Elements of array 3 are:");
            for (i = 0; i < size1 + size2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
    // merge second array into first array
    class sample27
    {
        static void Main(string[] args)
        {
            int s1, s2;
            Console.WriteLine("Enter size for first array");
            s1 = int.Parse(Console.ReadLine());
            int[] ar1 = new int[50];

            Console.WriteLine("Enter element for first array");
            for (int i = 0; i < s1; i++)
                ar1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size for second array");
            s2 = int.Parse(Console.ReadLine());
            int[] ar2 = new int[s2];

            Console.WriteLine("Enter element for second array");
            for (int i = 0; i < s2; i++)
                ar2[i] = int.Parse(Console.ReadLine());
            int s3 = 0;

            for (int i = s1, j = 0; j < s2; i++, j++)
            {
                ar1[i] = ar2[j];
                s3 = i;
            }
            Console.WriteLine("Merge Array :");
            for (int i = 0; i <= s3; i++)
            {
                Console.Write(ar1[i] + " ");
            }
        }
    }

    // inplace reverse array
    class sample28
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter array size := ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements to array := ");
            for (int i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0, t, j = size - 1; i < size / 2; i++, j--)
            {
                t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
            Console.WriteLine("In place reverse array is := ");
            for (int i = 0; i < size; i++)
                Console.WriteLine($"{arr[i]}  ");
        }
    }
    // merge alternate elements of two array
    class sample29
    {
        static void Main(string[] args)
        {
            int i, j;
            //Console.WriteLine("Enter array 1 size:");
            int size1 = 5;
            Console.WriteLine("Enter 5 elements of first array:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Enter array 2 size:");
            int size2 = 5;
            Console.WriteLine("Enter 5 elements of second array:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[size1 + size2];
            for (i = j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
                arr3[j++] = arr2[i];
            }

            Console.WriteLine("Alternate Elements of array 3 are:");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
    // concate two array without duplicate element
    class sample30
    {
        static void Main(string[] args)
        {
            int k = 0;
            int cnt;
            Console.WriteLine("Enter array 1 size:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size1} elements of first array:");
            int[] arr1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 size:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size2} elements of second array:");
            int[] arr2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[size1 + size2];
            for (int i = 0; i < arr1.Length; i++)
            {
                cnt = 0;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr1[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                cnt = 0;
                for (int j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr2[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr2[i];
                    k++;
                }
            }
            Console.WriteLine("Concatinated array is :=");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }

    // sort in asceding order
    class arraysort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements of array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int t;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
    // convert the char 
    class sample31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] >= 65 && ar[i] <= 90)
                {
                    ar[i] = (char)(ar[i] + 32);
                }
                else
                {
                    ar[i] = (char)(ar[i] - 32);
                }
            }
            Console.WriteLine("Converted Array");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
        }
    }

    // check char present in array or not
    class sample32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine($"{ch} is not present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is present in array");
            }
        }
    }

    // check char present in array or not
    class sample33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine($"{ch} is present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is not present in array");
            }
        }
    }
    // print sq of left element if element is negative
    class sample34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements of array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Changed Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    // convert half array in ascending and remaining half in descending order
    class sample35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements of array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int t;
            int cnt = 0;
            for (int i = 0; i < (size) / 2; i++)
            {
                for (int j = i + 1; j < size / 2; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                        cnt++;
                    }
                }
            }
            for (int i = cnt; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Array of Ascending and Descending order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    // count negative element and print it
    class sample36
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements of array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] negative = new int[size];
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negative[i] = arr[i];
                    cnt++;
                }
            }
            Console.WriteLine("Negative element array");
            for (int i = 0; i < negative.Length; i++)
            {
                Console.Write(negative[i] + " ");
            }
            Console.WriteLine("Total no. of negative elements : " + cnt);
        }
    }
    // arrange all negative elements before the positive integer element
    class sample37
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} elements of array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] temp = new int[size];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    temp[j++] = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    temp[j++] = arr[i];
            }
            Console.WriteLine("Converted array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }
    }

}

