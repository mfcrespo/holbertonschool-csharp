![](https://www.cnjobs.dk/drupal/sites/default/files/2019-01/csharp-01.png)

# 0x0B. C# - Interfaces

## Requirements

### General
* Allowed editors: vi, vim, emacs
* All your files will be compiled on Ubuntu 14.04 LTS
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task.
* Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags

### Tasks

| **Filename** | **Files** | **Description** |
|---|---|---|
| 0. Abstract thinking | (0-abstract_thinking/) | Create an abstract class called Base  |
| 1. User interface | (1-user_interface/) | Based on 0-abstract_thinking, create an interface called IInteractive  |
| 2. Escape room | (2-doors/) | Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive  |
| 3. Interior decorating | (3-decorations/) | Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable  |
| 4. Key collecting | (4-keys/) | Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable  |
| 5. Iterate and act | (5-iterate_act/) | Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it)  |
| 6. Better iterating and acting | (6-generic_iteration/) | Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach  |

#### Follow me 💬

| Authors | GitHub | Twitter | Linkedin |
| :---: | :---: | :---: | :---: |
| Maria Fernanda Crespo | [mfcrespo](https://github.com/mfcrespo) | [@mafe_crespo](https://twitter.com/mafe_crespo) | [mariafernandacrespo](https://www.linkedin.com/in/mariafernandacrespo) |

### License
*`0x0B. C# - Interfaces ` is open source and therefore free to download and use without permission.*

<a href="url"><img src="https://www.holbertonschool.com/holberton-logo.png" align="middle" width="100" height="30"></a>

##### Holberton School – Specializations - Csharp - Interfaces
##### July, 2021. Cali, Colombia