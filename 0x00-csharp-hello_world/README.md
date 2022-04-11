# 0x00. C# - Hello, World
## Details
      By Carrie Ybay, Software Engineer at Holberton School          Weight: 1                Ongoing project - started Apr 11, 2022 , must end by Apr 12, 2022           - you're done with 200% of tasks.              Checker will be released at Apr 11, 2022 12:00 PM        An auto review will be launched at the deadline      ## Concepts
For this project, students are expected to look at these concepts:
* [Install Visual Studio Code and .NET Core SDK](https://intranet.hbtn.io/concepts/84) 

* [AR/VR Curriculum Track Introduction](https://intranet.hbtn.io/concepts/127) 

## Resources
Read or watch :
* [Install Visual Studio Code and .NET Core SDK](https://intranet.hbtn.io/rltoken/tWsXKwIHV0JWDAyuLOvRGA) 

* [A Tour of C#](https://intranet.hbtn.io/rltoken/dGWk3hjT-5DommnkgLasnQ) 

* [Get started with C# and Visual Studio Code](https://intranet.hbtn.io/rltoken/uTW4-oIGZqXIcpaZYcRieQ) 

* [Getting Started with .NET Core using the CLI](https://intranet.hbtn.io/rltoken/uTW4-oIGZqXIcpaZYcRieQ) 

* [C# Tutorial for Beginners](https://intranet.hbtn.io/rltoken/lOzBhjrf1YJVhd8bM2Wwww) 
 (1:20 - 5:18)
* [Strings (C# Programming Guide)](https://intranet.hbtn.io/rltoken/n13jddnjeKFB7EKCaxDlSw) 

* [C# Language Reference](https://intranet.hbtn.io/rltoken/f3kXAFX3BOio669NbSuviw) 

* [C# Coding Conventions](https://intranet.hbtn.io/rltoken/XQ4f0yILy_H7WKMT4xMy6A) 

* [Console.WriteLine Method](https://intranet.hbtn.io/rltoken/V8-17QNHe2JpVtNLQsKJbQ) 

## Learning Objectives
At the end of this project, you are expected to be able to  [explain to anyone](https://intranet.hbtn.io/rltoken/LiLmGHniekB_QtJMcQxYbg) 
 ,  without the help of Google :
### General
* What is the meaning behind the name C#?
* Who is the lead architect of the development team of C#?
* What is .NET?
* What is the difference between C# and .NET?
* How to use VSCode and the integrated terminal to initialize, build, and run C# projects
* How to print text and variables using  ` Console.Write ` 
## Requirements
### Shell Scripts
* Allowed editors:  ` vi ` ,  ` vim ` ,  ` emacs ` 
* All your scripts will be tested on Ubuntu 14.04 LTS
* All your files should end with a new line
* The first line of all your files should be exactly  ` #!/usr/bin/env bash ` 
* All your files must be executable
### C# Tasks
* Allowed editors:  ` Visual Studio Code ` 
* All files will be compiled on Ubuntu 14.04 LTS using  ` dotnet ` 
* A  ` README.md `  file, at the root of the folder of the project, is mandatory
* All default C# files named  ` Program.cs `  should be renamed to the name given in each task
* You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project. The default names generated in  ` Program.cs `  for  ` class `  are okay
* Each C# task requires its own folder and  ` .csproj `  file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your  ` obj/ `  or  ` bin/ `  folders
## Quiz questions
Great!          You've completed the quiz successfully! Keep going!          (Show quiz)#### 
        
        Question #0
    
 Quiz question Body What is the meaning behind the name C#?
 Quiz question Answers * C++++

* C Hash

* Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch

 Quiz question Tips #### 
        
        Question #1
    
 Quiz question Body Who is the lead architect of the development team of C#?
 Quiz question Answers * Bill Gates

* Anders Hejlseberg

* James Gosling

 Quiz question Tips #### 
        
        Question #2
    
 Quiz question Body What is .NET framework?
 Quiz question Answers * a web development tool

* a generic top-level domain used in DNS

* a software framework developed by Microsoft

 Quiz question Tips #### 
        
        Question #3
    
 Quiz question Body What is CLR?
 Quiz question Answers * Common Language Runtime

* C# Language Reader

* Clear

 Quiz question Tips #### 
        
        Question #4
    
 Quiz question Body What is Intermediate Language (IL) code?
 Quiz question Answers * a language used by .NET Framework to generate machine-independent code

* a language that is more difficult to learn

* a language with a purpose similar to Java bytecode

 Quiz question Tips #### 
        
        Question #5
    
 Quiz question Body What method is used for writing text to standard output with a new line?
 Quiz question Answers * Console.Write()

* Console.Print()

* Console.WriteLine()

 Quiz question Tips #### 
        
        Question #6
    
 Quiz question Body What method is used for writing text to standard output without a new line?
 Quiz question Answers * Console.Write()

* Console.Print()

* Console.WriteLine()

 Quiz question Tips #### 
        
        Question #7
    
 Quiz question Body What does the following code display?
```bash
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        Console.WriteLine("{0} {1} {2}", number1, number2, number3);
    }
}

```
 Quiz question Answers * 0 1 2

* 1 2 3

* number1 number2 number3

 Quiz question Tips #### 
        
        Question #8
    
 Quiz question Body What does the following code display?
```bash
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        Console.WriteLine("{2} {0} {1}", number1, number2, number3);
    }
}

```
 Quiz question Answers * 3 1 2

* number2, number1, number2

* 2 0 1

* 1 2 3

 Quiz question Tips ## Tasks
### 0. Initialize new project
          mandatory         Progress vs Score  Task Body Write a Bash script that initializes a new C# project inside a folder titled   ` 0-new_project `  .
* Use the command  ` dotnet ` 
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
0-initialize_new_project.sh
carrie@ubuntu:~/0x00-csharp-hello_world/$ ./0-initialize_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
  Restoring packages for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.targets.
  Restore completed in 151.49 ms for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj.


Restore succeeded.

carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
0-initialize_new_project.sh  0-new_project
carrie@ubuntu:~/0x00-csharp-hello_world/$ ls 0-new_project/
0-new_project.csproj  obj  Program.cs
carrie@ubuntu:~/0x00-csharp-hello_world/0-new_project$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 0-initialize_new_project.sh ` 
 Self-paced manual review  Panel footer - Controls 
### 1. Build new project
          mandatory         Progress vs Score  Task Body Write a Bash script that initializes and builds a new C# project inside a folder titled   ` 1-new_project `  .
* Use the command  ` dotnet ` 
```bash
carrie@ubuntu:~/0x00-csharp-hello_world$ ls
1-build_new_project.sh
carrie@ubuntu:~/0x00-csharp-hello_world$ ./1-build_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj...
  Restoring packages for /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj...
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.targets.
  Restore completed in 149.24 ms for /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj.


Restore succeeded.

Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  1-new_project -> /home/carrie/0x00-csharp-hello_world/1-new_project/bin/Debug/netcoreapp2.1/1-new_project.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.21
carrie@ubuntu:~/0x00-csharp-hello_world$ ls
1-build_new_project.sh  1-new_project
carrie@ubuntu:~/0x00-csharp-hello_world$ ls 1-new_project/
1-new_project.csproj  bin  obj  Program.cs
carrie@ubuntu:~/0x00-csharp-hello_world$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 1-build_new_project.sh ` 
 Self-paced manual review  Panel footer - Controls 
### 2. Run new project
          mandatory         Progress vs Score  Task Body Write a Bash script that initializes, builds, and runs a new C# project from a folder titled   ` 2-new_project `  .
* Use the command  ` dotnet ` 
```bash
carrie@ubuntu:~/0x00-csharp-hello_world$ ls
2-run_new_project.sh
carrie@ubuntu:~/0x00-csharp-hello_world$ ./2-run_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj...
  Restoring packages for /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj...
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/0x00-csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.targets.
  Restore completed in 154.48 ms for /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj.


Restore succeeded.

Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  2-new_project -> /home/carrie/0x00-csharp-hello_world/2-new_project/bin/Debug/netcoreapp2.1/2-new_project.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.21
Hello World!
carrie@ubuntu:~/0x00-csharp-hello_world$ ls
2-new_project  2-run_new_project.sh
carrie@ubuntu:~/0x00-csharp-hello_world$ ls 2-new_project/
2-new_project.csproj  bin  obj  Program.cs
carrie@ubuntu:~/0x00-csharp-hello_world$

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 2-run_new_project.sh ` 
 Self-paced manual review  Panel footer - Controls 
### 3. Hello, WriteLine
          mandatory         Progress vs Score  Task Body Write a C# script that prints exactly   ` "Programming is like building a multilingual puzzle `   followed by a new line.
* Use the method  ` Console.WriteLine ` 
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ ls
3-writeline.csproj  bin  obj  3-writeline.cs
carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ dotnet run
"Programming is like building a multilingual puzzle
carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 3-writeline/, 3-writeline/3-writeline.csproj, 3-writeline/3-writeline.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 4. Print integer
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/euxMhFdEF0-XZCLtdqne4Q) 
  in order to print the integer stored in the variable   ` number `  , followed by   ` Mission Street `   followed by a new line.
* You can find the source code [here](https://intranet.hbtn.io/rltoken/euxMhFdEF0-XZCLtdqne4Q) 

* Your code should be exactly 10 lines long
* The output of the script should be:* the number, followed by  ` Mission Street ` 
* followed by a new line

```bash
carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$  ls
4-print_integer.cs  4-print_integer.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$ dotnet run
972 Mission Street
carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 4-print_integer/, 4-print_integer/4-print_integer.csproj, 4-print_integer/4-print_integer.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 5. Print float
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/kuytn76s-qptXICqj2Vmmg) 
  in order to print the float stored in the variable   ` number `   with a precision of 2 digits.
* You can find the source code [here](https://intranet.hbtn.io/rltoken/kuytn76s-qptXICqj2Vmmg) 

* Your script should be exactly 10 lines long
* The output of the script should be:*  ` Float: `  followed by the number with only 2 digits
* followed by a new line

```bash
carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ ls
5-print_float.cs  5-print_float.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ dotnet run
Float: 3.14
carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 5-print_float/, 5-print_float/5-print_float.csproj, 5-print_float/5-print_float.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 6. Print string
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/BsLlMCzRgrGoeGqCGX3LWw) 
  in order to print a string stored in the variable   ` str `   3 times, followed by its first 9 characters.
* You can find the source code [here](https://intranet.hbtn.io/rltoken/BsLlMCzRgrGoeGqCGX3LWw) 

* The output of the script should be:* the value of  ` str `  3 times
* followed by a new line
* followed by the first 9 characters of  ` str ` 
* followed by a new line

* You are not allowed to use any loops or conditional statement
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ ls
6-print_string.cs  6-print_string.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ dotnet run
Holberton SchoolHolberton SchoolHolberton School
Holberton
carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 6-print_string/, 6-print_string/6-print_string.csproj, 6-print_string/6-print_string.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 7. Play with strings
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/legokuhnEkmHGP5-JkQV9w) 
  to print   ` Welcome to Holberton School! ` 
* You can find the source code [here](https://intranet.hbtn.io/rltoken/legokuhnEkmHGP5-JkQV9w) 

* Your code should be exactly 12 lines long
* You are not allowed to use any loops or conditional statement
* You have to use the variables  ` str1 `  and  ` str2 `  in your new line of code
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ ls
7-concat.cs  7-concat.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ dotnet run
Welcome to Holberton School!
carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 7-concat/, 7-concat/7-concat.csproj, 7-concat/7-concat.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 8. Print variables
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/c5U7giCio60Do2H4XU5YMg) 
  in order to print the given variables as   ` 972 Mission Street `  .
* You can find the source code [here](https://intranet.hbtn.io/rltoken/c5U7giCio60Do2H4XU5YMg) 

* Your code should be exactly 12 lines long
* You are not allowed to create new variables
* You are not allowed to edit existing variables
* The output of the script should be:*  ` 972 Mission Street ` 
* followed by a new line

```bash
carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ ls
8-print_variables.cs  8-print_variables.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ dotnet run
972 Mission Street
carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File: ```bash
8-print_variables/, 8-print_variables/8-print_variables.csproj, 8-print_variables/8-print_variables.cs
```

 Self-paced manual review  Panel footer - Controls 
### 9. Print specifiers
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/foEqLuZu644GyfX37MNTSw) 
  in order to print the given variables as in the result shown. 
* You can find the source code [here](https://intranet.hbtn.io/rltoken/foEqLuZu644GyfX37MNTSw) 

* Your code should be no more than 12 lines long
* You are not allowed to create new variables
* The target locale is  ` en-US.utf-8 ` 
* The output of the script should be:*  ` Percent: 75.53% ` [tip](https://intranet.hbtn.io/rltoken/8P-ckBD5Dw7FYvOg2kyRRA) 

* followed by a new line
* followed by  ` Currency: $98,765.43 ` 
* followed by a new line

```bash
carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ ls
9-print_specifiers.cs  9-print_specifiers.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ dotnet run
Percent: 75.53%
Currency: $98,765.43
carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File: ```bash
9-print_specifiers/, 9-print_specifiers/9-print_specifiers.csproj, 9-print_specifiers/9-print_specifiers.cs
```

 Self-paced manual review  Panel footer - Controls 
### 10. Copy - Cut - Paste
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/WOeBK1z0kP2-UUYhVmVEhQ) 
 .
* You can find the source code [here](https://intranet.hbtn.io/rltoken/WOeBK1z0kP2-UUYhVmVEhQ) 

* Your code should be exactly 15 lines long
* You are not allowed to use any loops or conditional statements
*  ` word_first_3 `  should contain the first 3 letters of the variable  ` word ` 
*  ` word_last_2 `  should contain the last 2 letters of the variable  ` word ` 
*  ` middle_word `  should contain the value of the variable  ` word `  without the first and last letters
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ ls
10-copy_cut_paste.cs  10-copy_cut_paste.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ dotnet run
First 3 letters: Hol
Last 2 letters: on
Middle word: olberto
carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File: ```bash
10-copy_cut_paste/, 10-copy_cut_paste/10-copy_cut_paste.csproj, 10-copy_cut_paste/10-copy_cut_paste.cs
```

 Self-paced manual review  Panel footer - Controls 
### 11. Create a new sentence
          mandatory         Progress vs Score  Task Body Complete this  [source code](https://intranet.hbtn.io/rltoken/jATFMnzdEgJstHhRISMf7A) 
  to print   ` object-oriented programming in C# `   followed by a new line.
* You can find the source code [here](https://intranet.hbtn.io/rltoken/jATFMnzdEgJstHhRISMf7A) 

* Your code should be exactly 11 lines long
* You are not allowed to use any loops or conditional statements
* You are not allowed to create new variables
* You are not allowed to use string literals
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ ls
11-concat_edges.cs  11-concat_edges.csproj  bin  obj
carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ dotnet run
object-oriented programming in C#
carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 11-concat_edges/, 11-concat_edges/11-concat_edges.csproj, 11-concat_edges/11-concat_edges.cs ` 
 Self-paced manual review  Panel footer - Controls 
### 12. Hello, Error
          #advanced         Progress vs Score  Task Body Write a C# script that prints exactly   ` and that piece of art is useful - Dora Korpar, 2015-10-19 `   followed by a new line.
* Your script should print to  ` stderr ` 
* Your script should exit with the status code  ` 1 ` 
```bash
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ ls
100-hello_error.cs  100-hello_error.csproj  obj
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ dotnet run
and that piece of art is useful - Dora Korpar, 2015-10-19
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ echo $?
1
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ dotnet run 2> q
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ cat q
and that piece of art is useful - Dora Korpar, 2015-10-19
carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ 

```
 Task URLs  Github information Repo:
* GitHub repository:  ` holbertonschool-csharp ` 
* Directory:  ` 0x00-csharp-hello_world ` 
* File:  ` 100-hello_error/, 100-hello_error/100-hello_error.csproj, 100-hello_error/100-hello_error.cs ` 
 Self-paced manual review  Panel footer - Controls 