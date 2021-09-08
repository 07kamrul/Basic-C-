using System;

namespace CSH
{
    class ConditionalStatement
    {
        public void ifElseSatement(){
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num %2 == 0){
                Console.WriteLine("It is even number.");
            }else{
                Console.WriteLine("it is odd number.");
            }  
        }
    }    
}
