using System;

namespace Plexus
{
    class UserInterface
    {
        public UserInterface()
        {
            glassNum = -1;
            rowNum = -1;
            totalWaterPoured = 0;           
        }
        
        //Accept and validate User Input
        private int GetRowNum()
        {
            int rowval;
            do
            {
                Console.Write("Enter Row Number (int) : ");                    
                if(!int.TryParse(Console.ReadLine(), out rowval))
                    Console.WriteLine("The value must be of integer type, try again "); 
                else
                {            
                    if(rowval < 0)
                        Console.WriteLine("The value must be non negative, try again "); 
                    else
                        break;
                }
                
            } while(true);                                
            return rowval;
        }
        private int GetGlassNum()
        {
            int glassVal = 0;
            do
            {
                Console.Write("Enter Glass Number (int) : ");                
                if(!int.TryParse(Console.ReadLine(), out glassVal))
                    Console.WriteLine("The value must be of integer type, try again "); 
                else
                {            
                    if(glassVal < 0 || glassVal > (rowNum + 1))
                        Console.WriteLine("The value must be non negative number between 0 to {0} , try again ", rowNum + 1); 
                    else
                        break;
                }
                
            } while(true);   

            return glassVal;
        }
        private double GetWaterPoured()
        {
            double waterVal = 0;
            do
            {
                Console.Write("Enter Total Water Poured (Liters) : ");                
                if(!Double.TryParse(Console.ReadLine(), out waterVal))
                    Console.WriteLine("The value must be of double type, try again "); 
                else
                {            
                    if(waterVal < 0)
                        Console.WriteLine("The value must be non negative, try again "); 
                    else
                        break;
                }
                
            } while(true);   

            return waterVal;
        }

        //Method taking user input such as glassnum, rownum , total water poured
        public void AskUser()
        {
            Console.WriteLine("----------- Welcome to Water calculator---------");  

            rowNum = GetRowNum();
            glassNum = GetGlassNum();
            totalWaterPoured = GetWaterPoured();
        }

        // Method to output the water poured in the glass    
        public void OutputWaterPoured(double waterInTheGlass) => Console.WriteLine(" Result ==> Water Poured in Row {0} Glass {1} is {2} liters", 
                                    rowNum, glassNum, waterInTheGlass.ToString("n2"));

        public int glassNum {get; set;}
        public int rowNum {get; set;}
        public double totalWaterPoured {get; set;}       

    }
}