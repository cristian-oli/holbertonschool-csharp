# 0x06. C# - Classes and Namespaces
## Details
      By Carrie Ybay, Software Engineer at Holberton School          Weight: 1                Ongoing project - started Apr 26, 2022 , must end by Apr 27, 2022           - you're done with 0% of tasks.              Checker will be released at Apr 26, 2022 12:00 PM        An auto review will be launched at the deadline      ## Resources
Read or watch :
* [Object-Oriented Programming](https://intranet.hbtn.io/rltoken/1d5Lm5enndZlrmRHiwni7g) 

* [Classes and Structs](https://intranet.hbtn.io/rltoken/3bicS_1jqVHkVF4l_B8zzw) 

* [Choosing Between Class and Struct](https://intranet.hbtn.io/rltoken/GPsFElPiuiXStSXBY9EO5Q) 

* [C# Classes & OOP](https://intranet.hbtn.io/rltoken/eUAkvjmiu-M2P_hkxNvgkw) 
 (Start at 4:57)
* [Properties vs. Fields](https://intranet.hbtn.io/rltoken/b7gHNoNXuV7JFC9RXRoPNA) 

* [.toString() method](https://intranet.hbtn.io/rltoken/vNUlhvzQSOMgumX-gIQNfg) 

* [How to Override the .ToString() method](https://intranet.hbtn.io/rltoken/d3Oj37ZVB25L9ezOkQraDg) 

* [Classes](https://intranet.hbtn.io/rltoken/b6GwLcNiKZVoZ2Xpm7-B6g) 

* [Objects](https://intranet.hbtn.io/rltoken/aFmEJEkAAFRfhRvJAlsBWw) 

* [Constructors](https://intranet.hbtn.io/rltoken/uBE9YYLQFMk5kSC7a--khw) 

* [Namespaces](https://intranet.hbtn.io/rltoken/EzszekECZcIUwv4NSZG-6Q) 

* [Using Properties](https://intranet.hbtn.io/rltoken/WUXxdZvGMWghtzY9Fu5FqQ) 

* [this keyword](https://intranet.hbtn.io/rltoken/4HgW1uUAaMUNX8id4ZYCFQ) 

* [.NET Stack and Heap](https://intranet.hbtn.io/rltoken/kveWshS_owpZOfOGDrg9VQ) 

* [Fundamentals of garbage collection](https://intranet.hbtn.io/rltoken/roTP-fYsJzjLAtHQhDnWlQ) 

## Learning Objectives
At the end of this project, you are expected to be able to  [explain to anyone](https://intranet.hbtn.io/rltoken/9QpPHsOsmN4inXJKS-Gdvw) 
 ,  without the help of Google :
### General
* How to document C# code with XML comments
* What is object-oriented programming?
* What is a namespace
* What is a class
* What are objects and instances
* What is the difference between a class and an object or instance
* What is a field
* What is a constructor
* What is a property
* How to use  ` get `  and  ` set ` 
* When to use a constructor and when to use a property
* What is  ` this `  and when to use it
* What is a method
* What are access modifiers
* What is a static class
* What is a static member
* What is encapsulation
* What is polymorphism
* What is abstraction
* What does  ` toString `  do and how to override it
* What is the difference between a class and a struct
* When to use a class and when to use a struct
* What is garbage collection in C#
## Requirements
### General
* Allowed editors:  ` Visual Studio Code ` 
* All files will be compiled on Ubuntu 14.04 LTS using  ` dotnet ` 
* A  ` README.md `  file, at the root of the folder of the project, is mandatory
* All default C# files named  ` Program.cs `  should be renamed to the name given in each task
* Each C# task requires its own folder and  ` .csproj `  file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your  ` obj/ `  or  ` bin/ `  folders
* In the following examples, the  ` main.cs `  files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own  ` main.cs `  files at compilation. Our  ` main.cs `  files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
## More Info
From this project forward, documenting your code is  required !
* Use [XML documentation comments](https://intranet.hbtn.io/rltoken/FV2VB75Led1vN1Nm3o37rQ) 

* [XML Documentation Best Practices](https://intranet.hbtn.io/rltoken/IRfCQMt9PU8n1FjYdD0L1g) 

* All public types / classes and their members should be documented with  ` <summary> `  tags
* Private members should be documented but without XML comments
* To enable XML documentation in your project, you must add this line to the  ` PropertyGroup `  in your  ` .csproj `  file:*  ` <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> ` 

* Compiling your project with  ` /doc `  will create an XML file in the directory specified above. With the  ` .xml `  in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.
## Quiz questions
Great!          You've completed the quiz successfully! Keep going!          (Show quiz)#### 
        
        Question #0
    
 Quiz question Body What are namespaces used for?
 Quiz question Answers * Organizing classes

* Controlling the scope of class and method names within large projects

* For exporting comments in a hierarchical format

 Quiz question Tips #### 
        
        Question #1
    
 Quiz question Body What is a class?
 Quiz question Answers * An object

* A reference type

* A blueprint for a data type

* A value type

 Quiz question Tips #### 
        
        Question #2
    
 Quiz question Body An instance of a class is an object.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #3
    
 Quiz question Body A constructor uses   ` get `   and   ` set `  .
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #4
    
 Quiz question Body What is a field?
 Quiz question Answers * An empty class

* A variable declared in a class

* An access modifier

 Quiz question Tips #### 
        
        Question #5
    
 Quiz question Body A   ` private `   modifier allows access to a field from outside the class.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #6
    
 Quiz question Body What does   ` .ToString() `   return by default?
 Quiz question Answers * The fully qualified name of the type of the object

* A count of characters in the object’s string representation

* A string representation of the object

 Quiz question Tips #### 
        
        Question #7
    
 Quiz question Body What is encapsulation?
 Quiz question Answers * The ability of an object to perform in a wide variety of ways

* When a group of related methods, properties, and other members are treated as a single object

* Providing functionality while hiding background details in order to simplify and increase efficiency

 Quiz question Tips #### 
        
        Question #8
    
 Quiz question Body What is polymorphism?
 Quiz question Answers * The ability of an object to perform in a wide variety of ways

* When a group of related methods, properties, and other members are treated as a single object

* Providing functionality while hiding background details in order to simplify and increase efficiency

 Quiz question Tips #### 
        
        Question #9
    
 Quiz question Body What is abstraction?
 Quiz question Answers * The ability of an object to perform in a wide variety of ways

* When a group of related methods, properties, and other members are treated as a single object

* Providing functionality while hiding background details in order to simplify and increase efficiency

 Quiz question Tips #### 
        
        Question #10
    
 Quiz question Body In the following code, what is   ` Dog `  ?
```bash
public class Dog
{
    string name;
    public int age = 2;

    public Dog(string n, int num)
    {
        name = n;
        age = num;
    }
}

```
 Quiz question Answers * A public field

* A public class

* A private field

 Quiz question Tips #### 
        
        Question #11
    
 Quiz question Body In the following code, what is   ` public Dog(string n, int num) `  ?
```bash
public class Dog
{
    string name;
    public int age = 2;

    public Dog(string n, int num)
    {
        name = n;
        age = num;
    }
}

```
 Quiz question Answers * A public field

* A property

* A constructor

 Quiz question Tips #### 
        
        Question #12
    
 Quiz question Body In the following code, what is   ` string name `  ?
```bash
public class Dog
{
    string name;
    public int age = 2;

    public Dog(string n, int num)
    {
        name = n;
        age = num;
    }
}

```
 Quiz question Answers * A private field

* A public field

* A constructor

 Quiz question Tips #### 
        
        Question #13
    
 Quiz question Body What is the fully qualified name of class   ` Daisy `  ?
 ` namespace Plants
{
    class Flowers
    {
        class Daisy
        {
        }
    }
}
 `  Quiz question Answers *  ` Daisy ` 

*  ` Flowers.Daisy ` 

*  ` Plants.Flowers.Daisy ` 

 Quiz question Tips #### 
        
        Question #14
    
 Quiz question Body What is the fully qualified name of class   ` Order `  ?
```bash
namespace Kingdom
{
    class Phylum
    {
        class Class
        {
            class Order
            {
                class Family
                {
                    class Genus
                    {
                        class Species
                        {
                        }
                    }
                }
            }
        }
    }
}

```
 Quiz question Answers *  ` Phylum.Class.Order ` 

*  ` Kingdom.Phylum.Class.Order ` 

* `  ` Kingdom.Phylum.Class.Order/Family.Genus.Species ` 

 Quiz question Tips #### 
        
        Question #15
    
 Quiz question Body Private classes should not be included in XML documentation because it exposes the inner workings of your code that you may not want to be shared.
 Quiz question Answers * True

* False

 Quiz question Tips #### 
        
        Question #16
    
 Quiz question Body Which of the following statements describe a static class?
 Quiz question Answers * Static classes cannot be instantiated.

* Static classes can contain instance constructors.

* Static classes can be used as a container for sets of methods that only need to operate on input and do not need to get or set any properties of their own.

 Quiz question Tips #### 
        
        Question #17
    
 Quiz question Body Which of the following statements describe a static member?
 Quiz question Answers * Multiple copies of a static member can exist.

* Static members are always accessed by the class name, not by an instance name.

* Static members are callable on a class even when no instance of the class has been created.

 Quiz question Tips #### 
        
        Question #18
    
 Quiz question Body ```bash
static void Main()
{
  Dog d;
    d = new Dog();
    d.name = "Poppy";
}

public class Dog
{
    string name;
    public int age = 0;
}

```
In this example, which of the following statements is true?
 Quiz question Answers * The variable   ` d `   and the new instance of Dog occupy the same place in memory in the stack

* The variable   ` d `   and the new instance of Dog have different addresses in memory

 Quiz question Tips #### 
        
        Question #19
    
 Quiz question Body ```bash
static void Main()
{
  Dog d;
    d = new Dog("Poppy", 2);
    d = new Dog("Django", 4);
}

public class Dog
{
    string name;
    public int age = 0;

    public Dog(string n, int num)
    {
        name = n;
        age = num;
    }
}

```
In this example, which of the following statements is true?
 Quiz question Answers *  ` Console.WriteLine(d.name) `   will print   ` Poppy ` 

*  ` Console.WriteLine(d.name) `   will print   ` Django ` 

* The   ` Dog `   instance for   ` Poppy `   is still accessible

* The   ` Dog `   instance for   ` Django `   is still accessible

 Quiz question Tips #### 
        
        Question #20
    
 Quiz question Body All memory management in C# must be initiated with code – it is not done automatically.
 Quiz question Answers * True

* False

 Quiz question Tips ## Tasks
### 0. Braaainsss
          mandatory         Progress vs Score  Task Body Create a new namespace   ` Enemies `  . Create an empty public class   ` Zombie `   within   ` Enemies `   that defines a zombie.
```bash
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ cat 0-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ ls
0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ dotnet run
newObject is of type Enemies.Zombie
String representation: Enemies.Zombie
carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 0-enemy/, 0-enemy/0-enemy.csproj, 0-enemy/0-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 1. Healthy competition
          mandatory         Progress vs Score  Task Body Based on   ` 0-enemy `  , write a public class   ` Zombie `   that defines a zombie by:
* public field  ` health ` 
*  ` health `  should be an int and have no value
* public constructor:  ` public Zombie() ` * sets the value of  ` health `  to  ` 0 ` 

```bash
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ cat 1-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ ls
1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ dotnet run
newObject is of type Enemies.Zombie and has a total of 0 health
carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 1-enemy/, 1-enemy/1-enemy.csproj, 1-enemy/1-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 2. Health validation
          mandatory         Progress vs Score  Task Body Based on   ` 1-enemy `  , write a public class   ` Zombie `   that defines a zombie by:
* public field  ` health ` 
*  ` health `  should be an int and have no value
* public constructor:  ` public Zombie() ` * sets the value of  ` health `  to  ` 0 ` 

* a new public constructor:  ` public Zombie(int value) ` *  ` value `  must be greater than or equal to 0
* if  ` value `  is less than 0, throw an  ` ArgumentException `  with the message  ` Health must be greater than or equal to 0 ` 

```bash
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ cat 2-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ ls
2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
Health must be greater than or equal to 0
carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 2-enemy/, 2-enemy/2-enemy.csproj, 2-enemy/2-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 3. Zombie health
          mandatory         Progress vs Score  Task Body Based on   ` 2-enemy `  , write a public class   ` Zombie `   that defines a zombie by:
* private field  ` health ` 
*  ` health `  should be an int and have no value
* public constructor:  ` public Zombie() ` * sets the value of  ` health `  to  ` 0 ` 

* public constructor:  ` public Zombie(int value) ` *  ` value `  must be greater than or equal to 0

* public method  ` public int GetHealth() `  that returns the value of health of the Zombie object
```bash
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ cat 3-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ ls
3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
newObject2 is of type Enemies.Zombie and has a total of 98 health
carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 3-enemy/, 3-enemy/3-enemy.csproj, 3-enemy/3-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 4. Hello, my name is
          mandatory         Progress vs Score  Task Body Based on   ` 3-enemy `  , write a public class   ` Zombie `   that defines a zombie by:
* private field  ` health ` 
*  ` health `  should be an int and have no value
* public constructor:  ` public Zombie() ` * sets the value of  ` health `  to  ` 0 ` 

* public constructor:  ` public Zombie(int value) ` *  ` value `  must be greater than or equal to 0

* private field  ` name ` 
*  ` name `  should be a string and have a default value of  ` (No name) ` 
* public property  ` Name ` *  ` get ` : retrieve name
*  ` set ` : set name

* public method  ` public int GetHealth() `  that returns the value of health of the Zombie object
```bash
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ cat 4-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ ls
4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ dotnet run
Ed is of type Enemies.Zombie and has a total of 10 health
(No name) is of type Enemies.Zombie and has a total of 98 health
carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 4-enemy/, 4-enemy/4-enemy.csproj, 4-enemy/4-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 5. Printing a zombie
          mandatory         Progress vs Score  Task Body Based on   ` 4-enemy `  , write a public class   ` Zombie `   that defines a zombie by:
* private field  ` health ` 
*  ` health `  should be an int and have no value
* public constructor:  ` public Zombie() ` * sets the value of  ` health `  to  ` 0 ` 

* public constructor:  ` public Zombie(int value) ` *  ` value `  must be greater than or equal to 0

* private field  ` name ` 
*  ` name `  should be a string and have a default value of  ` (No name) ` 
* public property  ` Name ` *  ` get ` : retrieve name
*  ` set ` : set name

* public method  ` public int GetHealth() `  that returns the value of health of the Zombie object
* public  ` .toString() `  override that prints the Zombie object’s attributes to stdout* Format:  ` Zombie Name: <name> / Total Health: <health> `  (see example below)

```bash
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ cat 5-main.cs 
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine(newObject1.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine(newObject2.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ 

```
```bash
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ ls
5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ dotnet run
Zombie Name: Ed / Total Health: 10
Zombie Name: (No name) / Total Health: 98
carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x06-csharp-classes ` 
* File:  ` 5-enemy/, 5-enemy/5-enemy.csproj, 5-enemy/5-enemy.cs ` 
 Self-paced manual review  Panel footer - Controls 
