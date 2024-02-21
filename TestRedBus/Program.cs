using TestRedBus;

List<int> packageWeights = [5,3,2,5,6,1,4,7,9];
int totalWeightPerBike = 10;

int bikes = Bikes.CalculateBikes(packageWeights, totalWeightPerBike);
Console.WriteLine($"Núnero de bicicletas con un total de  {totalWeightPerBike} de peso: {bikes}");