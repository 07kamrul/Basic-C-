using System;

namespace CSH
{
    public class GotoStatement{
        public void gotoMethod(){
            ineligible:
                Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 18){
                goto ineligible;
            }else{
                Console.WriteLine("You are eligible to vote!");
            }
        }
    }
}