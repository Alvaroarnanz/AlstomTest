namespace IceCreamParlor;
class Program
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        try
        {
            int t = ReadNumber();
            Validator.ValidateNumberTrips(t); //validate the number of trips

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = ReadNumber();
                Validator.ValidateAmountMoney(m);//validate the amount of money

                int n = ReadNumber();
                Validator.ValidateNumberFlavors(n);//validate the number of flavors

                List<int> arr = ReadArray();
                Validator.ValidateSizeFlavors(n, arr); //validate the size of array

                List<int> result = Result.IcecreamParlor(m, arr); //search for a possible solution

                textWriter.WriteLine(String.Join(" ", result));
            }
        }
        catch (Exception ex)
        {
            //If some exception is thrown, display the custom message and close the app
            Console.WriteLine(ex.Message);
        }
        finally
        {
            //Resource cleanup
            textWriter.Flush();
            textWriter.Close();
        }
    
    }


    /// <summary>
    /// Read the string entered and split
    /// </summary>
    /// <returns>>numbers list</returns>
    private static List<int> ReadArray()
    {
        return Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    }

    /// <summary>
    /// Read the number entered
    /// </summary>
    /// <returns>>number entered</returns>
    private static int ReadNumber()
    {
        return Convert.ToInt32(Console.ReadLine().Trim());
    }
}
