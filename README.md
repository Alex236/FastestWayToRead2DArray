# FastestWayToRead2DArray
This program will show you difference between reading two-dimentional array by rows and columns. In the end you can look at optimized variant of reading array (using unsafe code).

How to deploy?
1) Install Visual Studio Code
2) Install .NET Core
3) Build and run

My personal tests (I used array with size 20000x20000):
1) Using fastest variant I got 2672ms
2) Using reading by rows I got 4072ms
3) Using reading by columns I got 16246ms

Warning!!!
Before making your tests you must one time after runing, run 3 variants of user choise to compile all methods.
