using System;

namespace Plexus
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            userInterface.AskUser();
            WaterCalculator waterCalculator = new WaterCalculator();
            waterCalculator.CalculateWaterInGlass(userInterface.rowNum,
                                                  userInterface.glassNum,
                                                  userInterface.totalWaterPoured);
            userInterface.OutputWaterPoured(waterCalculator.WaterInGlass);
            Console.ReadKey();
            
        }
        
    }
}
