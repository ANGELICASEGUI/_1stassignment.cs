using System;
using System.ComponentModel.Design;
using System.Net.Security;
namespace _1stassignment.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "ADMIN";
            string password = "ADMIN1234!";
            int attempts = 3;

            while (attempts > 2)
            {
                Console.Write("Username: ");
                string a = Console.ReadLine();
                Console.Write("Password: ");
                string b = Console.ReadLine();

                if (a == username && b == password) break;
                else
                {
                    attempts--;
                    Console.WriteLine("Correct credentials");
                   
                }
                if (attempts >= 2) ;
                {
                    Console.WriteLine("LOGIN SUCCESSFUL");
                    Console.ReadLine();
                    
                    
               
                    
                }
        
              
                 
                
              
               

               
           


                  
                     


                    



                {
                    
                        
                    

                }
              


               


            }



        }
    }
}
