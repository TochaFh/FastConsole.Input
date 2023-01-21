# FastConsole.Input - Library for .NET
It's never been so easy to get input from the console. With FastConsole.Input you have fast and simple methods to get user input with messages, conversions and validations! Complements [FastConsole](https://github.com/TochaFh/FastConsole).
* [NuGet Page](https://www.nuget.org/packages/FastConsole.Input/)
* [FuGet Package Explorer](https://www.fuget.org/packages/FastConsole.Input/1.0.0)
## Install
* Package Reference
```csproj
<PackageReference Include="FastConsole.Input" Version="1.0.0" />
```
* Dotnet CLI
```
dotnet add package FastConsole.Input --version 1.0.0
```
* Package Manager
```
Install-Package FastConsole.Input -Version 1.0.0
```
* Paket CLI
```
paket add FastConsole.Input --version 1.0.0
```
## Quickstart - Examples
* ### Using
```c#
using FastConsole;
```
* ### Simple read line
```c#
string name = In.ReadLine("Enter your name: ");
```
* ### Main method to read input
```c#
// 'RepeatWhenInvalid' and 'ShowInvalidInputMsg' are true by default.
var opt = new SimpleInputOpt("Enter a number: ", "You must digit a valid number!\n") { RepeatWhenInvalid = true, ShowInvalidInputMsg = true };

// You must use 'double?' (nullable) because of the validation and parsing.
double num = In.ReadInput<double?>(opt: opt, parse: InputParser.ToDouble).Value;
```
It is highly recommended to take a look at the [source code](https://github.com/TochaFh/FastConsole.Input/blob/master/src/FastConsole.Input/In.cs) to better understand how this library works.
* ### Or just...
```c#
double num = In.ReadDouble(In.InOpt("Enter a number: ", "You must digit a valid number!\n")).Value;
// Or...
double num = In.ReadDouble("Enter a number: ".InOpt()).Value;
// Or...
double num = In.ReadDouble("Enter a number: ".InOpt(repeatWhenInvalid: true, showInvalidMessage: false)).Value;
// Or...
double num = In.ReadDouble(("Enter a number: ", "You must digit a valid number!\n").InOpt()).Value;
```
In the example, double is used, but there are options for several other types of numbers (int, short, decimal, float, uint, long, byte...).
* ### SimpleInputOpt.SetMsg
```c#
var opts = new SimpleInputOpt("Enter your age: ", "This value is not valid!") { RepeatWhenInvalid = true, ShowInvalidInputMsg = false };

string name = In.ReadString(opts);
int age = In.ReadInt(opts.SetMsg("Enter your age: ")).Value;
opts.ShowInvalidInputMsg = true;
float height = In.ReadFloat(opts.SetMsg("Enter your height: ")).Value;
```
* ### Advanced parse
```c#
Func<string, int?> parseAge = s =>
{
  bool conversion = int.TryParse(s, out int age);
  
  if (!conversion) return null;
  else if (age < 18) return null;
  else return age;
};

int age = In.ReadInput<int?>(In.InOpt("Enter your age: ", "You must be over 18!\n"), parseAge).Value;
```
* ### Notes
The methods accept IInputOptions and NOT SimpleINputOpt, so you can create your own implementation.  
  
There's another implementation of IInputOptions, it's the CoolInputOpt, which is like SimpleInputOpt but it's cool, because you can use CoolText (from [FastConsole](https://github.com/TochaFh/FastConsole)) instead of string!  
  
This library depends on [FastConsole](https://github.com/TochaFh/FastConsole). Probably when you add this to your project, FastConsole is automatically added.
