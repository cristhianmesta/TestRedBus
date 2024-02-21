namespace TestRedBus;

public sealed class Bikes
{
    public static int CalculateBikes(List<int> packageWeights, int totalWeightPerBike)
    {
        int bikesCounter = 0;
        List<int> revisedPackageWeights = []; 

        foreach (int packageWeight in packageWeights)
        {
            int complementaryWeight = totalWeightPerBike - packageWeight;

            if (revisedPackageWeights.Contains(complementaryWeight))
            {
                bikesCounter++;
                revisedPackageWeights.Remove(complementaryWeight); 
            }
            else
            {
                revisedPackageWeights.Add(packageWeight); 
            }
        }

        return bikesCounter;
    }
}
