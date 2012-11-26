#Colorful console extension
Allows to write colored messages to console in an easy way.

####Usage example

```C#
 ColorfullConsole.WriteLine("gray " + "green".Green() + " red".Red() + " blue".Blue());
 ```
 
 Will output:
 
 ![Alt text](http://content.screencast.com/users/Restuta/folders/Jing/media/7a95f622-b8bd-4322-9af8-a434dcf6df3a/2012-03-02_1648.png)
 
 Compare with classic syntax:
 
```C#
Console.Write("gray ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("green");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" red");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(" blue");
Console.ResetColor();
```

####Namespace to include
```C# 
using Restuta.ConsoleExtensions.Colorfull;
```