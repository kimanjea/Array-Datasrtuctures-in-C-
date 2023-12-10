using System.Data;

class Program {
    static void Main(string [] args) {
        int [] array = new int[5];
        int length= 0;

        for(int i=0; i<2; i++) {
            array[i]= i+1;
           // Console.WriteLine(array[i]);
            length++;
        }

        array[length]=88; //insert at the end
        length++;
        //insert at the beginning
        for(int i = length-1; i>=0; i--) {
            array[i+1]=array[i]; //moves elements forward
        }
        array[0]=99;
        length++;

        //inserting in the middle is like inserting at the beginning
        for(int i = length-1;i>=1;i--) {// we insert at position 2
            array[i+1]= array[i];
        }    

        array[1]=900;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i].ToString()); //print our new array while experimenting with .ToString
        }


        //how to insert in an array of strings
        string [] names = new string[5];
        int length2 = 0;  
        names[0] = "azhar"; //inserting at index 0
        names[1]= "shukra"; //inserting at index 1
        names[2]= "najib"; //inserting at the end

        length2=3;
        
        //trying to insert string at the beginning
        for(int i = length2-1; i>=0; i--) {
            names[i+1] = names[i];
        } 

        names[0] = "Jerome";
        length2++; //always increase length 

        //inserting at the middle is like inserting at the beginning, all you are doing is shifting only up to a particular index
        for(int i=length2-1;i>=2; i--){ //make sure you watch out for your indexing because it could be prone to errors from slight mistakes
            names[i+1] = names[i];
        }

        names[2]="insertedmid";
    
        for(int i = 0; i<names.Length; i++) {
            Console.WriteLine(names[i].ToUpper());
        }
       

    }
    
}