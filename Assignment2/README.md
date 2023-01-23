# Assignment 2

## Learning outcomes

- Gain familiarity on Interfaces, how to implement them and use them.

- Gain familiarity on Properties.

## Introduction

In this assignment, you will implement 3 different 'string builder' objects that will conform to a single interface.

## What is a string builder

String builders is a kind of collection that, as denoted by their namesake, build strings for their users. The code below shows an example of a possible implementation of a simple string builder: 



```
class StringBuilder {
private string internalString;
public StringBuilder() {
internalString = "";

// We can also do:
// internalString = new string();
}

public void Append(string str) {
internalString += str;
}

public string GetString() {
return internalString;
}
}
```
And the code below demonstrates how a user might use the string builder:
```
// Attempt to use StringBuilder
StringBuilder builder = new StringBuilder();
builder.Append("Hello World");
builder.Append(". ");
builder.Append("My name is Gerald");
Console.WriteLine(builder.GetString());
// Prints to console: "Hello World. My name is Gerald"
```

The string builders we will be implementing will be different from the one in the example above, but it should give you a good idea on what a string builder is.

### The design of our string builder

Just implementing a string builder like the one we showed above might be good, but what if the user wants to be able to easily swap between different string builders?

Consider the following code:

```
class Program {
// This method shouldn't care about the actual type of string builder
static void Print(IStringBuilder builder) {
Console.WriteLine("{0}", builder.String);
}
static void Main() {
NormalStringBuilder b1 = new NormalStringBuilder();
BeegStringBuilder b2 = new BeegStringBuilder();
SmolStringBuilder b3 = new SmolStringBuilder();
```
```
b1.Append("Hello World");
b2.Append("Hello World");
b3.Append("Hello World");
```
```
Print(b1);
Print(b2);
Print(b3);
}
}
```

Notice that the <Mark>Print</Mark> method does not care whether it takes in a <Mark>NormalStringBuilder</Mark>, a

<Mark>BeegStringBuilder</Mark> or a <Mark>SmolStringBuilder!</Mark> This is the power of polymorphism and interfaces.

You are required to modify and submit the following files and implement their respective classes and interfaces:

- IStringBuilder.cs - Contains the IStringBuilder interface and its implementation.

- BeegStringBuilder.cs - Contains the BeegStringBuilder class and its implementation.

- SmolStringBuilder.cs - Contains the SmolStringBuilder class and its implementation.

- NormalStringBuilder.cs - Contains the NormalStringBuilder class and its implementation.

The specifications of each interface and class are detailed in the **Specifications** section below. At the end of the day, the idea is to abstract the concrete string builders (BeegStringBuilder, SmolStringBuilder and NormalStringBuilder) behind the the IStringBuilder interface.

## Specifications

### IStringBuilder

This is the interface which all StringBuilders must inherit. It will have the following members:

- String - A string property that minimally returns a string.

- Append - A method that takes in a string and does not return anything

- Clear - A method that does not take in anything and does not return anything.

### NormalStringBuilder

This class must inherit the IStringBuilder interface. It is up to you how you want to implement the interface's method, but it must at least do the following:

#### Public member methods

- String - A property that returns the string that is being built by the string builder.

- Append - A method that will take in a string and append to the string it is building.

- Clear - A method that will reset the string that is being built by the string builder.

### BeegStringBuilder

This class must inherit the IStringBuilder interface. It is up to you how you want to implement the interface's method, but it must at least do the following:

#### Public member methods

- String - A property that returns the string that is being built by the string builder.

- Append - A method that will take in a string, convert all its characters to uppercase and then append that

- Clear - A method that will reset the string that is being built by the string builder.

### SmolStringBuilder

This class must inherit the IStringBuilder interface. It is up to you how you want to implement the interface's method, but it must at least do the following:

#### Public member methods

- String - A property that returns the string that is being built by the string builder.

- Append - A method that will take in a string, convert all its characters to lowercase and then append that to the string it is building.

- Clear - A method that will reset the string that is being built by the string builder.

## Check your work

1. After you are done, compile and execute the program.

2. If your Program.cs is unmodified, the output should look like the expected_output.txt file given.

3. Try to test with other values in Program.cs to see if your methods yield the intended results.

4. Ensure that your IStringBuilder.cs, BeegStringBuilder.cs, SmolStringBuilder.cs and NormalStringBuilder.cs works with the original Program.cs file, if you have modified Program.cs.

## Submission and automatic evaluation

1. In the course web page, click on the VPL submission page to submit IStringBuilder.cs, BeegStringBuilder.cs, SmolStringBuilder.cs and NormalStringBuilder.cs.

2. Read the following rubrics to maximize your grade. Your submission will receive:
    1. F grade if your Solution.cs does not compile with the original Program.cs
    2. A+ if every method is implemented correctly according to VPL.
    3. VPL will provide a proportional grade based on how many incorrect results were generated by your submission. Check the comments section for any feedback of your results.


