# dotnet
<br>
List of programs on C#
<br>
1. Write a C# program that asks the user to enter multiple lines of text (until they type "STOP"). Save these lines into a file <br>named "output.txt". Then, read and display the contents of the file. Implement proper exception handling to catch potential <br>errors (e.g., file access issues)
<br>
2.Write a program that takes a list of integers from the user and performs the following operations using LINQ:<br>
a) Find all numbers greater than 50<br>
b) Sort the numbers in ascending order<br>
c) Find the square of each number<br>
<br>
3.Create a program that allows the user to store student records using a dictionary. Each student should have:
ID (integer, unique)
Name (string)
Your program should allow the user to:<br>
a) Add a new student.<br>
b) Remove a student by ID.<br>
c) Display all students.<br>
<br>
4.Simulate an online order processing system using async programming. Your program should:<br>
a) Ask the user for an order name.<br>
b) Display "Processing order..."<br>
c) Wait 3 seconds (to simulate processing time).<br>
d) Display "Order for [item] is ready!"<br>
Use async and await to make the processing non-blocking.<br>
<br>
5.Write a program to write 10MB of data to multiple files as per the procedure mentioned below:<br>
Write 10MB of binary data in blocks of 50kB byte array<br>
The above should be replicated for 100 files i.e. after execution, the program should have created 100 number 10MB files.<br>
After completion of writing to each single file, the program should output the following message on console "<Filename> <br>Writing Completed"
Execute the above program in a single thread and also multiple threads/tasks using async/await programming. Make sure that<br> the UI thread is not blocked.<br>
Note the time taken for execution of the program in single task and multiple tasks
