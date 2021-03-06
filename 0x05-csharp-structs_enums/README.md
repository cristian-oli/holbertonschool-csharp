# 0x05. C# - Structs, Enumerations
## Details
      By Carrie Ybay, Software Engineer at Holberton School          Weight: 1                Ongoing project - started Apr 25, 2022 , must end by Apr 26, 2022           - you're done with 100% of tasks.              Checker will be released at Apr 25, 2022 12:00 PM        An auto review will be launched at the deadline      ## Resources
Read or watch :
* [Classes and Structs](https://intranet.hbtn.io/rltoken/intrd30cFD8bZnkhMtBKEg) 

* [Using Structs](https://intranet.hbtn.io/rltoken/X4zrzeNakjelRNj5teH1Pw) 

* [Enumeration types](https://intranet.hbtn.io/rltoken/7pBdsPzJfXMlEkNklpC3jA) 

* [.toString() method](https://intranet.hbtn.io/rltoken/fwQp-D7JRiEVWeaNLIq2PA) 

* [How to Override the .ToString() method](https://intranet.hbtn.io/rltoken/RWAAmeQo4hQBXaQBHvaINw) 

* [struct (C# Reference)](https://intranet.hbtn.io/rltoken/X4zrzeNakjelRNj5teH1Pw) 

## Learning Objectives
At the end of this project, you are expected to be able to  [explain to anyone](https://intranet.hbtn.io/rltoken/pPt2_9OwShbxLW5FQZA5yA) 
 ,  without the help of Google :
### General
* What is a struct
* What is a constructor
* What is a field
* What is a property
* What is an enumeration and when to use them
* What does  ` toString `  do and how to override it
## Requirements
### General
* Allowed editors:  ` Visual Studio Code ` 
* All files will be compiled on Ubuntu 14.04 LTS using  ` dotnet ` 
* A  ` README.md `  file, at the root of the folder of the project, is mandatory
* All default C# files named  ` Program.cs `  should be renamed to the name given in each task
* Each C# task requires its own folder and  ` .csproj `  file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your  ` obj/ `  or  ` bin/ `  folders
* In the following examples, the  ` main.cs `  files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own  ` main.cs `  files at compilation. Our  ` main.cs `  files might be different from the one shown in the examples
## Quiz questions
Great!          You've completed the quiz successfully! Keep going!          (Show quiz)#### 
        
        Question #0
    
 Quiz question Body What is a struct?
 Quiz question Answers * A value type

* A blueprint for a data type

* A reference type

 Quiz question Tips #### 
        
        Question #1
    
 Quiz question Body Structs can be instantiated without a   ` new `   operator, which makes allocation more efficient.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #2
    
 Quiz question Body An instance of a struct is an object.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #3
    
 Quiz question Body A struct can inherit from another struct.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #4
    
 Quiz question Body Structs are stored on the:
 Quiz question Answers * Stack

* Heap

 Quiz question Tips #### 
        
        Question #5
    
 Quiz question Body In the following enumeration, what is the value of   ` West `  ?
 ` enum Directions { North, East, South, West };
 `  Quiz question Answers * “West”

* 3

* 4

 Quiz question Tips #### 
        
        Question #6
    
 Quiz question Body In the following code, what will print to the console?
```bash
using System;

struct Student 
{
    public string name; 
    public int id;
}

class Program
{
    static void Main(string[] args)
    {
        Student betty;

        betty = new Student();

        Console.WriteLine(betty.id);
    }
}

```
 Quiz question Answers *  ` null ` 

* 0

* Exception: Unassigned local variable

 Quiz question Tips #### 
        
        Question #7
    
 Quiz question Body In the following code, what will print to the console?
```bash
using System;

struct Employee
{
    public string name;
    public int yearStarted;
}

class Program
{
    static void Main(string[] args)
    {
        Employee emily;
        Employee william;

        emily = new Employee("Emily", 2016);

        william = emily;

        william.name = "William";

        Console.WriteLine(emily.name);
    }
}

```
 Quiz question Answers * “Emily”

* “William”

*  ` null ` 

 Quiz question Tips ## Tasks
### 0. They're good dogs
          mandatory         Progress vs Score  Task Body Define a new enum   ` Rating `   with the values   ` Good `  ,   ` Great `  ,   ` Excellent `  .
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$

```
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ ls
bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ dotnet run
Score: Great
Score: 1
carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x05-csharp-structs_enums ` 
* File:  ` 0-dog/, 0-dog/0-dog.csproj, 0-dog/0-dog.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 1. Chief Puppy Officer
          mandatory         Progress vs Score  Task Body Based on   ` 0-dog `  , define a new struct   ` Dog `   with the following members:
*  ` name ` , type:  ` public string ` 
*  ` age ` , type:  ` public float ` 
*  ` owner ` , type:  ` public string ` 
*  ` rating ` , type  ` public Rating ` 
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy.name = "Poppy";
        poppy.age = 0.7f;
        poppy.owner = "Kris";
        poppy.rating = Rating.Excellent;

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$

```
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ ls
bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x05-csharp-structs_enums ` 
* File:  ` 1-dog/, 1-dog/1-dog.csproj, 1-dog/1-dog.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 2. A dog is the only thing on earth that loves you more than you love yourself
          mandatory         Progress vs Score  Task Body Based on   ` 1-dog `  , add a constructor to struct   ` Dog `   that takes parameters.
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ cat 2-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$

```
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ ls
bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x05-csharp-structs_enums ` 
* File:  ` 2-dog/, 2-dog/2-dog.csproj, 2-dog/2-dog.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad
          mandatory         Progress vs Score  Task Body Based on   ` 2-dog `  , override the   ` .ToString() `   method to print the Dog object’s attributes to stdout.
Format: 
 ` Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>
 ` ```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine(poppy.ToString());
    }
}
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$

```
```bash
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ ls
bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ dotnet run
Dog Name: Poppy
Age: 0.7
Owner: Kris
Rating: Excellent
carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x05-csharp-structs_enums ` 
* File:  ` 3-dog/, 3-dog/3-dog.csproj, 3-dog/3-dog.cs ` 
 Self-paced manual review  Panel footer - Controls 
