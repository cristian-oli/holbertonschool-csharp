# 0x04. C# - Exceptions
## Details
      By Carrie Ybay, Software Engineer at Holberton School          Weight: 1                Ongoing project - started Apr 25, 2022 , must end by Apr 26, 2022           - you're done with 0% of tasks.              Checker will be released at Apr 25, 2022 12:00 PM        An auto review will be launched at the deadline      ## Resources
Read or watch :
* [Exceptions and Exception Handling](https://intranet.hbtn.io/rltoken/jQxbt1-nvfiW9hFI62N3qw) 

* [C# Exception Handling Best Practices](https://intranet.hbtn.io/rltoken/kB05mvDnHFksbHveUBBIaA) 

* [Creating and Throwing Exceptions](https://intranet.hbtn.io/rltoken/faRAv9C8J_kK_nZZzJVO3Q) 

* [How to Execute Cleanup Code Using finally](https://intranet.hbtn.io/rltoken/VQFMod6xKOTDdEliy_ffkw) 

## Learning Objectives
At the end of this project, you are expected to be able to  [explain to anyone](https://intranet.hbtn.io/rltoken/a33f2GeqotvUw-cWSkB-dA) 
 ,  without the help of Google :
### General
* What are exceptions and when to use them
* What is the purpose of catching exceptions
* How to handle exceptions
* How to use  ` try ` ,  ` catch ` ,  ` finally ` 
* How to raise built-in exceptions
* When to implement clean-up actions after exceptions
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
    
 Quiz question Body What is an exception?
 Quiz question Answers * a special if/else case

* a method of circumventing C# style conventions

* a response to a circumstance that occurs while a program is running

 Quiz question Tips #### 
        
        Question #1
    
 Quiz question Body A   ` try `   statement cannot contain more than one   ` catch `   block.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #2
    
 Quiz question Body A   ` finally `   statement is not required for handling exceptions.
 Quiz question Answers * True

* False

 Quiz question Tips ## Tasks
### 0. Safe list printing
          mandatory         Progress vs Score  Task Body Write a method that prints n elements of a list.
* Class Name:  ` List ` 
* Prototype:  ` public static int SafePrint(List<int> myList, int n) ` 
*  ` n `  represents the number of elements to print
*  ` n `  can be bigger than the length of  ` myList ` 
* Returns number of elements actually printed
* You have to use  ` try `  /  ` catch ` 
```bash
carrie@ubuntu:~/0x04/0-safe_list_print$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}
carrie@ubuntu:~/0x04/0-safe_list_print$

```
```bash
carrie@ubuntu:~/0x04/0-safe_list_print$ ls
0-main.cs  0-safe_list_print.cs  0-safe_list_print.csproj  bin  obj
carrie@ubuntu:~/0x04/0-safe_list_print$ dotnet run
1
2
3
4
5
Number of integers printed: 5

1
2
3
Number of integers printed: 3

1
2
3
4
5
Number of integers printed: 5
carrie@ubuntu:~/0x04/0-safe_list_print$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x04-csharp-exceptions ` 
* File: ```bash
0-safe_list_print/, 0-safe_list_print/0-safe_list_print.csproj, 0-safe_list_print/0-safe_list_print.cs
```

 Self-paced manual review  Panel footer - Controls 
### 1. Integer division
          mandatory         Progress vs Score  Task Body Write a function that divides 2 integers and prints the result.
* Class Name:  ` Int ` 
* Prototype:  ` public static void divide(int a, int b) ` 
* You can assume that  ` a `  and  ` b `  are integers
* You have to use  ` try `  /  ` catch `  /  ` finally ` 
* The result of the division should print in the  ` finally `  section in the format shown in the example
```bash
carrie@ubuntu:~/0x04/1-divide_print$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        a = 4;
        b = 3;
        Int.divide(a, b);
        Console.WriteLine();

        a = 9;
        b = 0;
        Int.divide(a, b);
    }
}
carrie@ubuntu:~/0x04/1-divide_print$

```
```bash
carrie@ubuntu:~/0x04/1-divide_print$ ls
1-main.cs  1-divide_print.cs  1-divide_print.csproj  bin  obj
carrie@ubuntu:~/0x04/1-divide_print$ dotnet run
4 / 3 = 1

Cannot divide by zero
9 / 0 = 0
carrie@ubuntu:~/0x04/1-divide_print$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x04-csharp-exceptions ` 
* File:  ` 1-divide_print/, 1-divide_print/1-divide_print.csproj, 1-divide_print/1-divide_print.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 2. Divide lists
          mandatory         Progress vs Score  Task Body Write a function that divides element by element 2 lists.
* Class Name:  ` List ` 
* Prototype:  ` public static List<int> Divide(List<int> list1, List<int> list2, int listLength) ` 
*  ` length `  can be bigger than the length of either list
* Returns a new list of all division results
* If 2 elements can’t be divided, the division result should be equal to  ` 0 ` 
* If the division can’t be done (dividing by 0):* print  ` Cannot divide by zero ` 

* If either list is too short:* print  ` Out of range ` 

* You have to use  ` try `  /  ` catch ` 
```bash
carrie@ubuntu:~/0x04/2-divide_lists$ cat 2-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
        List<int> list2 = new List<int>() {1, 0, 2, 3};
        List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
carrie@ubuntu:~/0x04/2-divide_lists$

```
```bash
carrie@ubuntu:~/0x04/2-divide_lists$ ls
2-main.cs  2-divide_lists.cs  2-divide_lists.csproj  bin  obj
carrie@ubuntu:~/0x04/2-divide_lists$ dotnet run
Cannot divide by zero
Out of range
1
0
8
5
carrie@ubuntu:~/0x04/2-divide_lists$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x04-csharp-exceptions ` 
* File:  ` 2-divide_lists/, 2-divide_lists/2-divide_lists.csproj, 2-divide_lists/2-divide_lists.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 3. Throw exception
          mandatory         Progress vs Score  Task Body Write a function that throws an   ` Exception `  .
* Class Name:  ` Except ` 
* Prototype:  ` public static void Throw() ` 
```bash
carrie@ubuntu:~/0x04/3-throw_exception$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception raised");
        }
    }
}
carrie@ubuntu:~/0x04/3-throw_exception$

```
```bash
carrie@ubuntu:~/0x04/3-throw_exception$ ls
3-main.cs  3-throw_exception.cs  3-throw_exception.csproj  bin  obj
carrie@ubuntu:~/0x04/3-throw_exception$ dotnet run
Exception raised
carrie@ubuntu:~/0x04/3-throw_exception$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x04-csharp-exceptions ` 
* File: ```bash
3-throw_exception/, 3-throw_exception/3-throw_exception.csproj, 3-throw_exception/3-throw_exception.cs
```

 Self-paced manual review  Panel footer - Controls 
### 4. Throw exception with message
          mandatory         Progress vs Score  Task Body Write a method that throws an   ` Exception `   with a message.
* Class Name:  ` Except ` 
* Prototype:  ` public static void ThrowMsg(string msg) ` 
```bash
carrie@ubuntu:~/0x04/4-throw_exception_msg$ cat 4-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.ThrowMsg("C is fun");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x04/4-throw_exception_msg$

```
```bash
carrie@ubuntu:~/0x04/4-throw_exception_msg$ ls
4-main.cs  4-throw_exception_msg.cs  4-throw_exception_msg.csproj  bin  obj
carrie@ubuntu:~/0x04/4-throw_exception_msg$ dotnet run
C is fun
carrie@ubuntu:~/0x04/4-throw_exception_msg$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x04-csharp-exceptions ` 
* File: ```bash
4-throw_exception_msg/, 4-throw_exception_msg/4-throw_exception_msg.csproj, 4-throw_exception_msg/4-throw_exception_msg.cs
```

 Self-paced manual review  Panel footer - Controls 
