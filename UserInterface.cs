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

        //Method taking user input such as glassnum, rownum , total water poured
        public void AskUser()
        {
            Console.WriteLine("----------- Welcome to Water calculator---------");           
            rowNum = 2;
            glassNum = 0;
            totalWaterPoured = 1002;
        }

        // Method to output the water poured in the glass    
        public void OutputWaterPoured(double waterInTheGlass) => Console.WriteLine(" Water Poured in Row {0} Glass {1} is {2} liters", 
                                    rowNum, glassNum, waterInTheGlass.ToString("n2"));

        public int glassNum {get; set;}
        public int rowNum {get; set;}
        public double totalWaterPoured {get; set;}       

    }
}