using System;

class Program{
    static void Main(){
        int count=0;
        int n=2;

        while(count<50){
            
            bool prime = true;
            
            for (int i=2;i<n;i++){
                if (n%i == 0){
                    prime=false;
                }
            }

            if(prime){
                Console.Write(n + " ");
                count++;
            }

            n++;
        }
    }
}