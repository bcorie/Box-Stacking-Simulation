# Box-Stacking-Simulation
## Assignment E9 for IGME 206

Background: Suppose that on a given day, workers in a factory create four individual stacks of boxes that contain items inside each box. After each day ends, someone counts the number of boxes in each stack and the items in each box. The workers will stack one to three boxes (inclusive) with one to nine items (inclusive) inside each box.

Tasks: Write a program that builds and fills an array called `array` that simulates the box-stacking results over three days. Given that you need to store a random amount of items per box per stack per day, `array` is 3D:
-	The first index indicates the current day. The simulation runs for a total of `DAYS`.
-	The second index refers to a stack of boxes. There is `STACKS` number of stacks.
-	The third index indicates a box in a particular stack: `MINHEIGHT` to `MAXHEIGHT`, inclusive.
-	There are between `MINITEMS` and `MAXITEMS` in each box, inclusive.

Specifications:
-	Keep your code general and use supplied constants.
-	`main` calls:
-	`createArray()`, which creates a static field array, which must be ragged/jagged and 3D.
-	`printArray()`, which prints the contents of the boxes in *column-major order*. So, wherever a stack ends, a box does not exist. Print a blank space instead of a number for empty spots.
-	The height of each stack and the contents of each box are random. See the constants for ranges.
-	You can create a class `Box` to contain items, but I’m more interested in arrays in this case.

Constants:
```
const int DAYS      = 3; // # of days to run simulation

const int STACKS    = 4; // # of stacks every day

const int MINHEIGHT = 1; // min height of a stack

const int MAXHEIGHT = 3; // max height of a stack

const int MINITEMS  = 1; // min # of items in a box

const int MAXITEMS  = 9; // max # of items in a box
```

Example Session:
```
Day 1:
  1
  8 6 6
3 2 2 3

Day 2:
    4
  9 6
9 1 2 8

Day 3:
  9
4 7   2
6 7 8 6
```
