# "Hello, world!" program

## Overview
 "Hello, world!" program prints "Hello, world!" on console.
 This program is wriiten by Kyumin Nam.

## Features
 - Print "Hello, world!".
 - Change output text instead "Hello, world!".
 - Change greeting and name instead "Hello" and "world".

## Sample output
Here are some examples of running "Hello, world!" program

This is the output of the command `hello-world.exe`:
```
Hello, world!
```

This is the output of the command `hello-world.exe --text="Hi, world"`:
```
Hi, world
```

This is the output of the command `hello-world.exe --greeting="Hi" --name="Kyumin"`:
```
Hi, Kyumin!
```

## Options

"Hello, world!" program supports the following options:

 - `-t <Text>`, `--text=<Text>`: Other output text. Default value is 'Hello, world!'. The output will be like '<Text>'.
 - `-g <Text>`, `--greeting=<Text>`: Other greeting text. Default value is 'Hello'. The output will be like '<Greeting>, <Name>!'.
 - `-n <Text>`, `--name=<Text>`: The name of someone to greet. The default value is 'world'. The output will be like '<Greeting>, <Name>!'.
 - `-r <Number>`, `--repeat=<Numver>`: The number of times to repeat the greeting. The default value is 1.
 - `-v`, `--version`: Print the version number and licensing information of Hello on standard output and then exit successfully.
 - `-h`, `--help`: Print an informative help message on standard output and exit successfully.

With no options, "Hello, world!" program prints "Hello, world!".

## Build from Source Code
 To build the application from source code, first install the required dependencies:
  - Visual Studio 2019
  - .NET Framework 4.8

 1. Download source code.
 2. Open solution in visual studio.
 3. Build solution.

## License
 - `Source Code` [MIT License](license.txt)
