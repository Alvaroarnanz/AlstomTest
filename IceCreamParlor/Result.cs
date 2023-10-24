namespace IceCreamParlor;
public class Result
{
    public static List<int> IcecreamParlor(int amountMoney, List<int> iceCreamPrices)
    {
        for (int i = 0; i < iceCreamPrices.Count(); i++) //Iterates the matrix selecting a number
        {
            int a = iceCreamPrices[i]; 

            for (int j = i + 1; j < iceCreamPrices.Count(); j++) //Iterates the matrix selecting the number in the next position
            {
                int b = iceCreamPrices[j];

                if (a + b == amountMoney) //Check if sum of two elements equals amount money
                {
                    return new List<int> { i + 1, j + 1 }.OrderBy(x => x).ToList(); //Return the indices of the two flavors (Using 1-based indexing)
                }
            }
        }
        return new List<int>(); //If not find a solution, return an empty list
    }
}