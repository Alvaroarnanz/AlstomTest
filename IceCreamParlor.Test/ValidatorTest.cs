namespace IceCreamParlor.Test;

//In this class all the methods of the Validator class are validated (the valid and invalid cases)
public class ValidatorTest
{

    [Theory(DisplayName = "Must validate a invalid number of trips and throw ArgumentException")]
    [InlineData(0)]
    [InlineData(51)]
    [InlineData(10000)]
    public void ValidateNumberOfTrips_with_invalid_values_and_throw_ArgumentException(int numberOfTrips)
    {
        Assert.Throws<ArgumentException>(() => Validator.ValidateNumberTrips(numberOfTrips));
    }

    [Theory(DisplayName = "Must validate a valid number of trips and not throw ArgumentException")]
    [InlineData(1)]
    [InlineData(25)]
    [InlineData(50)]
    public void ValidateNumberOfTrips_with_valid_values_and_dont_throw_ArgumentException(int numberOfTrips)
    {
        var exception = Record.Exception(() => Validator.ValidateNumberTrips(numberOfTrips));
        Assert.Null(exception);
    }


    [Theory(DisplayName = "Must validate a invalid amount of money and throw ArgumentException")]
    [InlineData(1)]
    [InlineData(10001)]
    [InlineData(99999)]
    public void ValidateAmountMoney_with_invalid_values_and_throw_ArgumentException(int amountOfMoney)
    {
        Assert.Throws<ArgumentException>(() => Validator.ValidateAmountMoney(amountOfMoney));
    }


    [Theory(DisplayName = "Must validate a valid amount of money and not throw ArgumentException")]
    [InlineData(2)]
    [InlineData(5000)]
    [InlineData(10000)]
    public void ValidateAmountMoney_with_valid_values_and_dont_throw_ArgumentException(int amountOfMoney)
    {
        var exception = Record.Exception(() => Validator.ValidateAmountMoney(amountOfMoney));
        Assert.Null(exception);
    }


    [Theory(DisplayName = "Must validate a invalid number of flavors and throw ArgumentException")]
    [InlineData(1)]
    [InlineData(10001)]
    [InlineData(99999)]
    public void ValidateNumberOfFlavors_with_invalid_values_and_throw_ArgumentException(int numberOfFlavors)
    {
        Assert.Throws<ArgumentException>(() => Validator.ValidateNumberFlavors(numberOfFlavors));
    }


    [Theory(DisplayName = "Must validate a valid number of flavors and not throw ArgumentException")]
    [InlineData(2)]
    [InlineData(5000)]
    [InlineData(10000)]
    public void ValidateNumberOfFlavors_with_valid_values_and_dont_throw_ArgumentException(int numberOfFlavors)
    {
        var exception = Record.Exception(() => Validator.ValidateNumberFlavors(numberOfFlavors));
        Assert.Null(exception);
    }


    [Fact(DisplayName = "Must must compare the number of elements of the array with the size of the array and throw ArgumentException")]
    public void ValidateFlavors_with_invalid_values_and_throw_ArgumentException()
    {
        //Arrange
        int numberOfFlavors = 4;
        List<int> arr = new List<int> { 1, 2, 3, 4, 5 };

        //Assert
        Assert.Throws<ArgumentException>(() => Validator.ValidateSizeFlavors(numberOfFlavors, arr));
    }

    [Fact(DisplayName = "Must must compare the number of elements of the array with the size of the array and not throw ArgumentException")]
    public void ValidateFlavors_with_valid_values_and_dont_throw_ArgumentException()
    {
        //Arrange
        int numberOfFlavors = 5;
        List<int> arr = new List<int> { 1, 2, 3, 4, 5 };

        //Act
        var exception = Record.Exception(() => Validator.ValidateNumberFlavors(numberOfFlavors));

        //Assert
        Assert.Null(exception);
    }
}

