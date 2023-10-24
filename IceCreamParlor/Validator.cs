using IceCreamParlor.Enums;

namespace IceCreamParlor;

// This class contains all the necessary validations of the inputs
public class Validator
{
    /// <summary>
    /// Validate the number of trips
    /// </summary>
    /// <param name="numberTrips"></param>
    /// <exception cref="ArgumentException">the numberTrips is not valid</exception>
    public static void ValidateNumberTrips(int numberTrips)
    {
        if (numberTrips < (int)EConstraints.NUMBER_OF_TRIPS_MIN)
            throw new ArgumentException($"the number of trips must be more than or equals to {(int)EConstraints.NUMBER_OF_TRIPS_MIN}");
        else if (numberTrips > (int)EConstraints.NUMBER_OF_TRIPS_MAX)
            throw new ArgumentException($"the number of trips must be less than or equals to {(int)EConstraints.NUMBER_OF_TRIPS_MAX}");
    }

    /// <summary>
    /// Validate amount of money
    /// </summary>
    /// <param name="amountMoney"></param>
    /// <exception cref="ArgumentException">the amount of money is not valid</exception>
    public static void ValidateAmountMoney(int amountMoney)
    {
        if (amountMoney < (int)EConstraints.AMOUNT_OF_MONEY_MIN)
            throw new ArgumentException($"the amount of money must be more than or equals to {(int)EConstraints.AMOUNT_OF_MONEY_MIN}");
        else if (amountMoney > (int)EConstraints.AMOUNT_OF_MONEY_MAX)
            throw new ArgumentException($"the amount of money must be less than or equals to {(int)EConstraints.AMOUNT_OF_MONEY_MAX}");
    }
    /// <summary>
    /// Validate the number of flavors
    /// </summary>
    /// <param name="flavorsSize"></param>
    /// <exception cref="ArgumentException">the size is not a valid size</exception>
    public static void ValidateNumberFlavors(int flavorsSize)
    {
        if (flavorsSize < (int)EConstraints.NUMBER_OF_FLAVORS_MIN)
            throw new ArgumentException($"the number of flavors must be more than or equals to {(int)EConstraints.NUMBER_OF_FLAVORS_MIN}");
        else if (flavorsSize > (int)EConstraints.NUMBER_OF_FLAVORS_MAX)
            throw new ArgumentException($"the number of flavors must be less than or equals to {(int)EConstraints.NUMBER_OF_FLAVORS_MAX}");
    }

    /// <summary>
    /// Validate if the array size match with the data entered
    /// </summary>
    /// <param name="flavorsSize"></param>
    /// <param name="flavors"></param>
    /// <exception cref="ArgumentException">the list does not have the indicated size</exception>
    public static void ValidateSizeFlavors(int flavorsSize, List<int> flavors)
    {
        if (!flavorsSize.Equals(flavors.Count()))
            throw new ArgumentException($"the number of array element must be equal than the size array");
    }
}