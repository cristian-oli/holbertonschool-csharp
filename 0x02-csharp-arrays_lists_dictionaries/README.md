# 0x02. C# - Data Structures: Arrays, Lists, Dictionaries
## Details
      By Carrie Ybay, Software Engineer at Holberton School          Weight: 1                Ongoing project - started Apr 13, 2022 , must end by Apr 14, 2022           - you're done with 0% of tasks.              Checker will be released at Apr 13, 2022 12:00 PM        An auto review will be launched at the deadline      ## Resources
Read or watch :
* [Arrays (C# Programming Guide)](https://intranet.hbtn.io/rltoken/uXSaKWP1rKx8CTa1yTbfOg) 

* [How to program in C# - Arrays](https://intranet.hbtn.io/rltoken/5JIbb4FQZtDLZvJCBFURtQ) 

* [Collections](https://intranet.hbtn.io/rltoken/WxJCUhqAtv27bVa1I3C7dA) 
 (Skip “Using LINQ to Access a Collection” and “Defining a Custom Collection”)
* [C# Lists](https://intranet.hbtn.io/rltoken/apeOsI9mzY9istDJtmUGtw) 

* [Array vs. List: When to use which?](https://intranet.hbtn.io/rltoken/RQD0ox18G7DBYpmi9kwOiA) 

* [C# Dictionaries](https://intranet.hbtn.io/rltoken/7MunOUGerX5Knwtz61tAQg) 

* [Working with Hashtable and Dictionary in C#](https://intranet.hbtn.io/rltoken/WT7MYYVoHX_YM09QL_M24A) 

* [foreach, in](https://intranet.hbtn.io/rltoken/nSCKoDh6CEHgyDbzqUhqFw) 

* [List Class](https://intranet.hbtn.io/rltoken/-Q8d36ceETAAAtwW7TfI_A) 

* [Dictionary Class](https://intranet.hbtn.io/rltoken/f57r8JSqjDTXfIGS9QVd8A) 

* [C# Language Reference](https://intranet.hbtn.io/rltoken/InKS0eQW4PRgDcUdXtjcow) 

* [C# Coding Conventions](https://intranet.hbtn.io/rltoken/TTij1ck0Bv52D3nwVqZcew) 

## Learning Objectives
At the end of this project, you are expected to be able to  [explain to anyone](https://intranet.hbtn.io/rltoken/UA62iWHy-QWIo7U5J99Zrg) 
 ,  without the help of Google :
### General
* How to create and use arrays
* What are Collections in C#
* How to create and use lists
* What is the difference between arrays and lists in C#
* When would you use an array vs a list
* How to create and use dictionaries
* What is the difference between dictionary and hashtables in C#
* When would you use a dictionary vs a hashtable
* How to use  ` foreach ` 
## Requirements
### C# Tasks
* Allowed editors:  ` Visual Studio Code ` 
* All files will be compiled on Ubuntu 14.04 LTS using  ` dotnet ` 
* A  ` README.md `  file, at the root of the folder of the project, is mandatory
* All default C# files named  ` Program.cs `  should be renamed to the name given in each task
* You do not need to know about namespaces yet. Namespaces should be omitted in this project
* Each C# task requires its own folder and  ` .csproj `  file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your  ` obj/ `  or  ` bin/ `  folders
* In the following examples, the  ` main.cs `  files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own  ` main.cs `  files at compilation. Our  ` main.cs `  files might be different from the one shown in the examples
## Quiz questions
Great!          You've completed the quiz successfully! Keep going!          (Show quiz)#### 
        
        Question #0
    
 Quiz question Body What is a collection?
 Quiz question Answers * a class

* a data type

* a group of related objects

 Quiz question Tips #### 
        
        Question #1
    
 Quiz question Body The following are generic collections:
 Quiz question Answers *  ` List<T> ` 

*  ` Hashtable ` 

*  ` SortedList<TKey,TValue> ` 

*  ` Dictionary<TKey,TValue> ` 

*  ` ArrayList ` 

 Quiz question Tips #### 
        
        Question #2
    
 Quiz question Body An array’s number of dimensions and length of each dimension can be changed during the lifetime of that array’s instance.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #3
    
 Quiz question Body What is the default value of a numeric array’s elements?
 Quiz question Answers * null

* 0

* 1

 Quiz question Tips #### 
        
        Question #4
    
 Quiz question Body The   ` List<T> `   class in C#:
 Quiz question Answers * does not allow duplicate elements

* starts indexes at 0

* is automatically sorted

 Quiz question Tips #### 
        
        Question #5
    
 Quiz question Body The   ` Dictionary `   class in C# is implemented as a hash table.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #6
    
 Quiz question Body If items need to be added or removed from a collection in a loop, which of the following should be used?
 Quiz question Answers *  ` for ` 

*  ` foreach ` 

 Quiz question Tips ## Tasks
### 0. Print an array of integers
          mandatory         Progress vs Score  Task Body Write a method that creates and prints an array of integers of a given size.
* Class Name:  ` Array ` 
* Prototype:  ` public static int[] CreatePrint(int size) ` 
* Returns the new array
* The integers in the array should start with  ` 0 `  and increment by one until the given size is met (see output below)
* If  ` size `  is  ` 0 ` , print a blank line
* If  ` size `  is less than  ` 0 ` , print  ` Size cannot be negative `  and return  ` null ` 
```bash
carrie@ubuntu:~/0x02/0-print_array$ cat 0-main.cs 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);
    }
}

```
```bash
carrie@ubuntu:~/0x02/0-print_array$ ls
0-main.cs  0-print_array.cs  0-print_array.csproj  bin  obj
carrie@ubuntu:~/0x02/0-print_array$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
Array Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
Array Length: 16$
----------------$
$
Array Length: 0$
----------------$
Size cannot be negative
carrie@ubuntu:~/0x02/0-print_array$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 0-print_array/, 0-print_array/0-print_array.csproj, 0-print_array/0-print_array.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 1. Access an element in an array
          mandatory         Progress vs Score  Task Body Write a method that retrieves an element from an array.
* Class Name:  ` Array ` 
* Prototype:  ` public static int elementAt(int[] array, int index) ` 
* Returns the element at the given index
* If  ` index `  is out of range, print  ` Index out of range `  and return  ` -1 ` 
```bash
carrie@ubuntu:~/0x02/1-element_at$ cat 1-main.cs 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {10, 17, -8, 4, -12, 7, 0, 1, -1, -9};

        Console.WriteLine("Element at index {0} is {1}", 4, Array.elementAt(array, 4));
        Console.WriteLine("Element at index {0} is {1}", 9, Array.elementAt(array, 9));
        Console.WriteLine("Element at index {0} is {1}", 0, Array.elementAt(array, 0));
        Array.elementAt(array, -7);
    }
}

```
```bash
carrie@ubuntu:~/0x02/1-element_at$ dotnet run
Element at index 4 is -12
Element at index 9 is -9
Element at index 0 is 10
Index out of range
carrie@ubuntu:~/0x02/1-element_at$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 1-element_at/, 1-element_at/1-element_at.csproj, 1-element_at/1-element_at.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 2. Replace element
          mandatory         Progress vs Score  Task Body Write a method that replaces an element of an array at a given index.
* Class Name:  ` Array ` 
* Prototype:  ` public static int[] ReplaceElement(int[] array, int index, int n) ` 
* Returns the updated array
* If  ` index `  is out of range, print  ` Index out of range `  and return the unchanged array
```bash
carrie@ubuntu:~/0x02/2-replace_element$ cat 2-main.cs 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6};

        PrintArray(array);
        Array.ReplaceElement(array, 1, 98);
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}
carrie@ubuntu:~/0x02/2-replace_element$ 

```
```bash
carrie@ubuntu:~/0x02/2-replace_element$ ls
2-main.cs             2-replace_element.csproj  obj
2-replace_element.cs  bin
carrie@ubuntu:~/0x02/2-replace_element$ dotnet run
0 1 2 3 4 5 6
0 98 2 3 4 5 6
carrie@ubuntu:~/0x02/2-replace_element$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File: ```bash
2-replace_element/, 2-replace_element/2-replace_element.csproj, 2-replace_element/2-replace_element.cs
```

 Self-paced manual review  Panel footer - Controls 
### 3. Print an array of integers... in reverse!
          mandatory         Progress vs Score  Task Body Write a method that prints all integers of an array, in reverse order.
* Class Name:  ` Array ` 
* Prototype:  ` public static void Reverse(int[] array) ` 
```bash
carrie@ubuntu:~/0x02/3-print_array_reverse$ cat 3-main.cs 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        Array.Reverse(array1);
        Array.Reverse(array2);
        Array.Reverse(array3);
        Array.Reverse(array4);
    }
}
carrie@ubuntu:~/0x02/3-print_array_reverse$

```
```bash
carrie@ubuntu:~/0x02/3-print_array_reverse$ ls
3-main.cs                 3-print_array_reverse.csproj  obj
3-print_array_reverse.cs  bin
carrie@ubuntu:~/0x02/3-print_array_reverse$ dotnet run | cat -e
9 8 7 6 5 4 3 2 1 0$
$
$
-42 972 0 -10 98$
carrie@ubuntu:~/0x02/3-print_array_reverse$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File: ```bash
3-print_array_reverse/, 3-print_array_reverse/3-print_array_reverse.csproj, 3-print_array_reverse/3-print_array_reverse.cs
```

 Self-paced manual review  Panel footer - Controls 
### 4. Print a list of integers
          mandatory         Progress vs Score  Task Body Write a method that creates and prints a list of integers of a given size.
* Class Name:  ` List ` 
* Prototype:  ` public static List<int> CreatePrint(int size) ` 
* The integers in the list should start with  ` 0 `  and increment by one until the given  ` size `  is met (see output below)
* Returns the newly created list
* If size is less than  ` 0 ` , print  ` Size cannot be negative `  and return  ` null ` 
```bash
carrie@ubuntu:~/0x02/4-print_list$ cat 4-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);        
    }
}
carrie@ubuntu:~/0x02/4-print_list$

```
```bash
carrie@ubuntu:~/0x02/4-print_list$ ls
4-main.cs  4-print_list.cs  4-print_list.csproj  bin  obj
carrie@ubuntu:~/0x02/4-print_list$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
List Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
List Length: 16$
----------------$
$
List Length: 0$
----------------$
0$
List Length: 1$
carrie@ubuntu:~/0x02/4-print_list$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 4-print_list/, 4-print_list/4-print_list.csproj, 4-print_list/4-print_list.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 5. Find the max
          mandatory         Progress vs Score  Task Body Write a method that finds the biggest integer of a list.
* Class Name:  ` List ` 
* Prototype:  ` public static int MaxInteger(List<int> myList) ` 
* Returns the largest element in a given list
* If list is empty, print  ` List is empty `  and return  ` -1 ` 
* You are not allowed to use LINQ or  ` .Max() ` 
```bash
carrie@ubuntu:~/0x02/5-max_integer$ cat 5-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
        List<int> myList2 = new List<int>() {98, 972, 971, -32, 972, 972, -727};

        Console.WriteLine("Max: " + List.MaxInteger(myList1));
        Console.WriteLine("Max: " + List.MaxInteger(myList2));
    }
}
carrie@ubuntu:~/0x02/5-max_integer$ 

```
```bash
carrie@ubuntu:~/0x02/5-max_integer$ ls
5-main.cs  5-max_integer.cs  5-max_integer.csproj  bin  obj
carrie@ubuntu:~/0x02/5-max_integer$ dotnet run
Max: 1024
Max: 972
carrie@ubuntu:~/0x02/5-max_integer$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 5-max_integer/, 5-max_integer/5-max_integer.csproj, 5-max_integer/5-max_integer.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 6. Only by 2
          mandatory         Progress vs Score  Task Body Write a method that finds all multiples of 2 in a list.
* Class Name:  ` List ` 
* Prototype:  ` public static List<bool> DivisibleBy2(List<int> myList) ` 
* Returns a new list containing  ` true `  or  ` false ` , depending on whether the integer at the same position in the original list is a multiple of 2
* The new list should have the same size as the original list
```bash
carrie@ubuntu:~/0x02/6-divisible_by_2$ cat 6-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5, 6};
        List<bool> result = new List<bool>();
        int i;

        result = List.DivisibleBy2(myList);

        for (i = 0; i < myList.Count; i++)
        {
            if (result[i] == true)
                Console.WriteLine(myList[i] + " is divisible by 2");
            else
                Console.WriteLine(myList[i] + " is not divisible by 2");
        }
    }
}
carrie@ubuntu:~/0x02/6-divisible_by_2$ 

```
```bash
carrie@ubuntu:~/0x02/6-divisible_by_2$ dotnet run
1 is not divisible by 2
2 is divisible by 2
3 is not divisible by 2
4 is divisible by 2
5 is not divisible by 2
6 is divisible by 2
carrie@ubuntu:~/0x02/6-divisible_by_2$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 6-divisible_by_2/, 6-divisible_by_2/6-divisible_by_2.csproj, 6-divisible_by_2/6-divisible_by_2.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 7. Delete at
          mandatory         Progress vs Score  Task Body Write a method that deletes the item at a specific position in a list.
* Class Name:  ` List ` 
* Prototype:  ` public static List<int> DeleteAt(List<int> myList, int index) ` 
* Returns the updated list
* If  ` index `  is out of range, print  ` Index is out of range `  and return the unchanged list
* You are not allowed to use  ` .RemoveAt() ` 
```bash
carrie@ubuntu:~/0x02/7-delete_at$ cat 7-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        List.DeleteAt(myList, 2);

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}
carrie@ubuntu:~/0x02/7-delete_at$

```
```bash
carrie@ubuntu:~/0x02/7-delete_at$ ls
7-delete_at.cs  7-delete_at.csproj  7-main.cs  bin  obj
carrie@ubuntu:~/0x02/7-delete_at$ dotnet run
1
2
3
4
5
----------
1
2
4
5
carrie@ubuntu:~/0x02/7-delete_at$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 7-delete_at/, 7-delete_at/7-delete_at.csproj, 7-delete_at/7-delete_at.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 8. Number of keys
          mandatory         Progress vs Score  Task Body Write a method that returns the number of keys in a dictionary.
* Class Name:  ` Dictionary ` 
* Prototype:  ` public static int NumberOfKeys(Dictionary<string, string> myDict) ` 
* Returns the number of keys in a dictionary
* You are not allowed to use  ` .Count() ` 
```bash
carrie@ubuntu:~/0x02/8-number_keys$ cat 8-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
    }
}
carrie@ubuntu:~/0x02/8-number_keys$ 

```
```bash
carrie@ubuntu:~/0x02/8-number_keys$ ls
8-main.cs  8-number_keys.cs  8-number_keys.csproj  bin  obj
carrie@ubuntu:~/0x02/8-number_keys$ dotnet run
Number of keys: 3
carrie@ubuntu:~/0x02/8-number_keys$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 8-number_keys/, 8-number_keys/8-number_keys.csproj, 8-number_keys/8-number_keys.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 9. Update dictionary
          mandatory         Progress vs Score  Task Body Write a method that adds a key and value to a dictionary.
* Class Name:  ` Dictionary ` 
* Prototype: ```bash
public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
```

* If a key exists in the dictionary, the value will be replaced
* If a key doesn’t exist in the dictionary, it will be created
* Returns the updated dictionary
```bash
carrie@ubuntu:~/0x02/9-add_key_value$ cat 9-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        string key;
        string value;

        key = "school";
        value = "Holberton";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("------------------");

        key = "city";
        value = "San Francisco";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
carrie@ubuntu:~/0x02/9-add_key_value$ 

```
```bash
carrie@ubuntu:~/0x02/9-add_key_value$ ls
9-add_key_value.cs  9-add_key_value.csproj  9-main.cs  bin  obj
carrie@ubuntu:~/0x02/9-add_key_value$ dotnet run
school: Holberton
------------------
school: Holberton
city: San Francisco
carrie@ubuntu:~/0x02/9-add_key_value$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 9-add_key_value/, 9-add_key_value/9-add_key_value.csproj, 9-add_key_value/9-add_key_value.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 10. Delete from dictionary
          mandatory         Progress vs Score  Task Body Write a method that deletes a key in a dictionary
* Class Name:  ` Dictionary ` 
* Prototype: ```bash
public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
```

* Returns the updated dictionary
```bash
carrie@ubuntu:~/0x02/10-delete_key_value$ cat 10-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("----------------");

        newDict = Dictionary.DeleteKeyValue(myDict, "track");

        foreach (KeyValuePair<string, string> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("-----");

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
carrie@ubuntu:~/0x02/10-delete_key_value$

```
```bash
carrie@ubuntu:~/0x02/10-delete_key_value$ ls
10-delete_key_value.cs  10-delete_key_value.csproj  10-main.cs  bin  obj
carrie@ubuntu:~/0x02/10-delete_key_value$ dotnet run
language: C
track: low level
school: Holberton
address: 972 Mission St.
city: San Francisco
----------------
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
-----
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
carrie@ubuntu:~/0x02/10-delete_key_value$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File: ```bash
10-delete_key_value/, 10-delete_key_value/10-delete_key_value.csproj, 10-delete_key_value/10-delete_key_value.cs
```

 Self-paced manual review  Panel footer - Controls 
### 11. Multiply by 2
          mandatory         Progress vs Score  Task Body Write a method that returns a new dictionary with all values multiplied by 2.
* Class Name:  ` Dictionary ` 
* Prototype:  ` public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict) ` 
* Returns the new dictionary
```bash
carrie@ubuntu:~/0x02/11-multiply_by_2$ cat 11-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Mary", 14);
        myDict.Add("Molly", 16);

        newDict = Dictionary.MultiplyBy2(myDict);

        foreach (KeyValuePair<string, int> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("--------------------");

        foreach (KeyValuePair<string, int> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
carrie@ubuntu:~/0x02/11-multiply_by_2$

```
```bash
carrie@ubuntu:~/0x02/11-multiply_by_2$ ls
11-main.cs           11-multiply_by_2.csproj  obj
11-multiply_by_2.cs  bin
carrie@ubuntu:~/0x02/11-multiply_by_2$ dotnet run
John: 12
Alex: 8
Bob: 14
Mary: 14
Molly: 16
--------------------
John: 24
Alex: 16
Bob: 28
Mary: 28
Molly: 32
carrie@ubuntu:~/0x02/11-multiply_by_2$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 11-multiply_by_2/, 11-multiply_by_2/11-multiply_by_2.csproj, 11-multiply_by_2/11-multiply_by_2.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 12. Print sorted dictionary
          mandatory         Progress vs Score  Task Body Write a method that prints a dictionary by ordered keys. 
* Class Name:  ` Dictionary ` 
* Prototype:  ` public static void PrintSorted(Dictionary<string, string> myDict) ` 
* You are not allowed to use  ` SortedDictionary ` 
* Output should be formatted as in the example below
```bash
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ cat 12-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$

```
```bash
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ ls
12-main.cs                         bin
12-print_sorted_dictionary.cs      obj
12-print_sorted_dictionary.csproj
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ dotnet run
address: 972 Mission St.
city: San Francisco
language: C
school: Holberton
track: low level
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File: ```bash
12-print_sorted_dictionary/, 12-print_sorted_dictionary/12-print_sorted_dictionary.csproj, 12-print_sorted_dictionary/12-print_sorted_dictionary.cs
```

 Self-paced manual review  Panel footer - Controls 
### 13. Best score
          mandatory         Progress vs Score  Task Body Write a method that returns the key with the biggest integer value in a given dictionary.
* Class Name:  ` Dictionary ` 
* Prototype:  ` public static string BestScore(Dictionary<string, int> myList) ` 
* Returns the key with the biggest integer value
* You can assume that all values are non-negative integers
* You can assume that all students have a different score
* If no scores are found, return “None”
```bash
carrie@ubuntu:~/0x02/13-best_score$ cat 13-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Molly", 16);
        myDict.Add("Mary", 14);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}
carrie@ubuntu:~/0x02/13-best_score$ 

```
```bash
carrie@ubuntu:~/0x02/13-best_score$ ls
13-best_score.cs  13-best_score.csproj  13-main.cs  bin  obj
carrie@ubuntu:~/0x02/13-best_score$ dotnet run
Best Score: Molly
carrie@ubuntu:~/0x02/13-best_score$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 13-best_score/, 13-best_score/13-best_score.csproj, 13-best_score/13-best_score.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 14. Rectangular array
          mandatory         Progress vs Score  Task Body Write a program that creates and prints a 5 by 5 two-dimensional array and initialize index   ` [2,2] `   to   ` 1 `   and all other indices to   ` 0 `  .
```bash
carrie@ubuntu:~/0x02/14-rectangular_array$ ls
14-rectangular_array.cs  14-rectangular_array.csproj  bin  obj
carrie@ubuntu:~/0x02/14-rectangular_array$ dotnet run | cat -e
0 0 0 0 0$
0 0 0 0 0$
0 0 1 0 0$
0 0 0 0 0$
0 0 0 0 0$
carrie@ubuntu:~/0x02/14-rectangular_array$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File: ```bash
14-rectangular_array/, 14-rectangular_array/14-rectangular_array.csproj, 14-rectangular_array/14-rectangular_array.cs
```

 Self-paced manual review  Panel footer - Controls 
### 15. Matrix squared
          mandatory         Progress vs Score  Task Body Write a method that computes the square value of all integers of a matrix.
* Class Name:  ` Matrix ` 
* Prototype:  ` public static int[,] Square(int[,] myMatrix) ` 
* Returns a new matrix containing the square value of all integers of the original matrix
```bash
carrie@ubuntu:~/0x02/15-square_matrix$ cat 15-main.cs 
using System;
class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] squareMatrix;
        int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        squareMatrix = Matrix.Square(myMatrix);

        for (i = 0; i < squareMatrix.GetLength(0); i++)
        {
            for (j = 0; j < squareMatrix.GetLength(1); j++)
            {
                Console.Write(squareMatrix[i, j]);
                if (j != squareMatrix.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
carrie@ubuntu:~/0x02/15-square_matrix$ 

```
```bash
carrie@ubuntu:~/0x02/15-square_matrix$ ls
15-main.cs           15-square_matrix.csproj  obj
15-square_matrix.cs  bin
carrie@ubuntu:~/0x02/15-square_matrix$ dotnet run
0 1 4
9 16 25
36 49 64
carrie@ubuntu:~/0x02/15-square_matrix$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x02-csharp-arrays_lists_dictionaries ` 
* File:  ` 15-square_matrix/, 15-square_matrix/15-square_matrix.csproj, 15-square_matrix/15-square_matrix.cs ` 
 Self-paced manual review  Panel footer - Controls 
[Done with the mandatory tasks? Unlock 1 advanced task now!](https://intranet.hbtn.io/projects/391/unlock_optionals) 
