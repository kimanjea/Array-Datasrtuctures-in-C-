# Array Datasrtuctures in C#
 Learning how to insert and delete from an array
## Program Details
# Program Class:
* Main Method:
Purpose: Entry point of the program where array insertion operations are performed.
* Functionality:
Inserts elements into an integer array at the beginning, end, and middle.
Inserts elements into a string array at the beginning, end, and middle.
Prints the resulting arrays.
# Integer Array Insertion:
* Array Initialization:
*** int[] array = new int[5]; **

Insert at the End: 
***  array[length]=88; 
        length++; ***

# String Array Insertion:
* Array Initialization:

*** string [] names = new string[5];
        int length2 = 0; ***

Insert at the Beginning:
*** for(int i = length2-1; i>=0; i--) {
            names[i+1] = names[i];
        } 

        names[0] = "Jerome";
        length2++; *** 

Insert in the Middle:
*** for(int i=length2-1;i>=2; i--){ 
            names[i+1] = names[i];
        }

        names[2]="insertedmid";
    
        for(int i = 0; i<names.Length; i++) {
            Console.WriteLine(names[i].ToUpper());
        } ***

