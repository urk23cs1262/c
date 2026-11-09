using System;

class program{
    static void Main(){
        string a = "waterbottle";
        string b = "erbottlewat";

        string c = a + a;

        if(c.Contains(b)){
            Console.WriteLine("Rotation");
        }
        else{
            Console.WriteLine("No Rotation");
        }
    }
}