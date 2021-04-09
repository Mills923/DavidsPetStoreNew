# DavidsPetStore
This is a build of a demo MVC application utilizing my own personal taste on it.
## link
https://www.apress.com/gp/book/9781484254394 - Authors Work - This is a student demo

## Chapter 9:!

[SportsStore_pt3](https://user-images.githubusercontent.com/77302336/114110371-37909e00-988c-11eb-9b25-adf99c34e139.JPG)


## Chapter 8:

### Filter and highlight Category:
![image](https://user-images.githubusercontent.com/77302336/113456691-c7cd6f80-93c2-11eb-93ab-313723ba2998.png)

### Shopping Cart and Session Data:
![image](https://user-images.githubusercontent.com/77302336/113456731-eaf81f00-93c2-11eb-95d8-2f0a6dca9715.png)

### Test Explorer Passed Tests:
![image](https://user-images.githubusercontent.com/77302336/113456804-1d098100-93c3-11eb-9648-7e7ba9f91f42.png)


## Chapter 7:

## Build Script
    dotnet new globaljson --sdk-version 5.0.103 --output DavidsPetStoreSln/DavidsPets
    dotnet new web --no-https --output DavidsPetStoreSln/DavidsPets --framework net5.0
    dotnet new sln -o DavidsPetStoreSln
    dotnet sln DavidsPetStoreSln add DavidsPetStoreSln/DavidsPets 
    dotnet new xunit -o DavidsPetStoreSln/DavidsPets.Tests --framework net5.0
    dotnet sln DavidsPetStoreSln add DavidsPetStoreSln/DavidsPets.Tests 
    dotnet add DavidsPetStoreSln/DavidsPets.Tests reference DavidsPetStoreSln/DavidsPets

![image](https://user-images.githubusercontent.com/77302336/112680416-94bb3700-8e2a-11eb-8d2a-e9f5734563f5.png)

![image](https://user-images.githubusercontent.com/77302336/112707137-30b66400-8e66-11eb-8889-e56c16ffd348.png)

