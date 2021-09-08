using System;

namespace CSH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Language");

            Console.WriteLine("\nNumber is odd or even press: 1");
            Console.WriteLine("\nVoting by GOTO press: 2");
            Console.WriteLine("\nSingle Level Inheritance press: 3");
            Console.WriteLine("\nMulti Level Inheritance press: 4");
            Console.WriteLine("\nAggregation (HAS-A Relationship) press 5");
            Console.WriteLine("\nMethod Overloading press 6");

            Console.WriteLine("\nEnter your choice: ");

            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Conditional Statement");

                    ConditionalStatement cs = new ConditionalStatement();
                    cs.ifElseSatement();

                    break;
                case 2:
                    Console.WriteLine("GOTo Statement");

                    GotoStatement gs = new GotoStatement();                    
                    gs.gotoMethod();

                    break;
                case 3:
                    Console.WriteLine("Single Level Inheritance");

                    Programmer p = new Programmer();
                    Console.WriteLine("Salary: "+p.salary);
                    Console.WriteLine("Bonus: "+p.bonus);

                    break;
                case 4:
                    Console.WriteLine("Multi Level Inheritance");

                    BabyDog bd = new BabyDog();
                    bd.eat();
                    bd.bark();
                    bd.weep();

                    break;

                case 5:
                    Console.WriteLine("Aggregation (HAS-A Relationship)");

                    Address a = new Address("Niketan","Gulshan", "Dhaka");
                    Person ps = new Person(1,"Person Name",a);
                    ps.display();

                    break;

                
                case 6:
                    Console.WriteLine("Method Overloading By changing no. of arguments");

                    Console.WriteLine(Cal.add(12, 23));  
                    Console.WriteLine(Cal.add(12, 23, 25)); 
                    
                    Console.WriteLine("Method Overloading By changing data type of arguments");
                    Console.WriteLine(Cal2.add(12, 23));  
                    Console.WriteLine(Cal2.add(12.4f,21.3f));  

                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

       
        }
    }
}
