using System;

namespace Plexus
{
    class WaterCalculator
    {
        //Max capacity of glass
        const int MAX_GLASS_CAPACITY = 250;
        public WaterCalculator() => WaterInGlass = 0;

        public void CalculateWaterInGlass(int rowNum, int glassNum, double totalWaterPoured)
        {
            double waterRemaining = totalWaterPoured;
            Console.WriteLine(" \n Total Water Poured on glasses is {0} liters", totalWaterPoured);

            //Iterate the glass rows
            for(int currentRow = 0; ; currentRow ++)
            {
                int glassesInEachRow = currentRow + 1;
                int maxWaterRowCapacity = MAX_GLASS_CAPACITY * glassesInEachRow;
                if (waterRemaining > maxWaterRowCapacity)
                {
                    //Water Overflow state
                    Console.WriteLine(" Water accumulated in {0} glasses of Row {1}  is {2} liters", 
                                      currentRow + 1, currentRow, MAX_GLASS_CAPACITY);

                    waterRemaining = waterRemaining - maxWaterRowCapacity;
                    Console.WriteLine(" Remaining Water is {0} liters\n", waterRemaining);

                    if(rowNum == currentRow)
                    {
                        WaterInGlass = MAX_GLASS_CAPACITY;                        
                    }                    
                }
                else
                {
                    //Water finish state
                    double waterInLastRow = waterRemaining/glassesInEachRow;
                    if(rowNum == currentRow)
                    {
                        WaterInGlass = waterInLastRow;                        
                    }
                    Console.WriteLine(" Water accumulated in {2} glasses of Row {0}  is {1} liters", 
                                    currentRow, waterInLastRow.ToString("n2"), currentRow + 1);                   
                    waterRemaining = 0;
                    Console.WriteLine(" Water is finished!\n");
                    break;

                }

            }
        }
        public double WaterInGlass {get; set;}
    }
}