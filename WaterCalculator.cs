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
            Console.WriteLine(" Water Poured on glasses is {0} liters", totalWaterPoured);

            //Iterate the glass rows
            for(int currentRow = 0; ; currentRow ++)
            {
                int glassesInEachRow = currentRow + 1;
                int maxWaterRowCapacity = MAX_GLASS_CAPACITY * glassesInEachRow;
                if (waterRemaining > maxWaterRowCapacity)
                {
                    //Water Overflow state
                    Console.WriteLine(" Water accumulated in all glasses of Row {0}  is {1} liters", 
                                    currentRow, MAX_GLASS_CAPACITY);

                    waterRemaining = waterRemaining - maxWaterRowCapacity;
                    Console.WriteLine(" Remaining Water is {0} liters", waterRemaining);

                    if(rowNum == currentRow)
                    {
                        WaterInGlass = MAX_GLASS_CAPACITY;
                        break;
                    }                    
                }
                else
                {
                    //Water finish state
                    if(rowNum == currentRow)
                    {
                        WaterInGlass = waterRemaining/glassesInEachRow;                        
                    }
                    waterRemaining = 0;
                    break;

                }

            }
        }
        public double WaterInGlass {get; set;}
    }
}