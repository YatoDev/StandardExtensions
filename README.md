# NetStandardExtension

This library provides frequently used methods as extension methods.
It mainly adds better support for null checking, exception throwing and enumerables.

### NuGet

    Install-Package NetStandardExtensions

### Features
1. Check if collections are null or empty
2. Converting strings and other types into a target type using default conversion method
3. Clone enumerables and loop through them with ForEach, Take, TakeWhile and TakeUntil
4. Flatten arrays of any type into a string
5. Throw exceptions directly from any type
6. IsNull and IsDefault (and more) for every type
7. Clamp numbers to minimum and maximum values
8. Limit numbers and strings to a maximum
9. A shortcut for String.Format and String.Concat

### .Net Standard

We build this library with the .Net Standard 1.0 and thats why it supports all .Net platforms.

|<div align="right">.NET Standard</div>|    1.0 |
|:-------------------------------------|---------:|
|.NET Core                             |     1.0  |
|.NET Framework                        |     4.5  |
|Mono                                  |     4.6  |
|Xamarin.iOS                           |    10.0  |
|Xamarin.Mac                           |     3.0  |
|Xamarin.Android                       |     7.0  |
|Universal Windows Platform            |    10.0  |
|Windows                               |     8.0  |
|Windows Phone                         |     8.1  |
|Windows Phone Silverlight             |   **8.0**|

### Contribute

You can contribute to this project by fixing Typos, Documentation and by adding more useful general purpose extension methods.

### License

MIT

[NetStandardExtensions License](https://github.com/michel-pi/StandardExtensions/blob/master/LICENSE "NetStandardExtensions License")