namespace IceCreamParlor.Test;

//In this class the method of the Result class is validated (the valid and invalid cases)

public class ResultTest
{

    [Fact(DisplayName = "Must find two flavors and return the indices")]
    public void IcecreamParlor_FoundMatch_ReturnsIndices()
    {
        //Arrange
        int m = 9;
        List<int> arr = new List<int> { 1, 3, 4, 6, 7, 8 };

        //Act
        List<int> result = Result.IcecreamParlor(m, arr);

        //Assert
        result.Should().BeEquivalentTo(new List<int> { 1, 6 }, options => options.WithStrictOrdering());
    }

    [Fact(DisplayName = "Must try to find two flavors and return invalid result")]
    public void IcecreamParlor_NoMatch_ReturnsZeroIndices()
    {
        //Arrange
        int m = 10;
        List<int> arr = new List<int> { 1, 2, 3, 4, 5};

        //Act
        List<int> result = Result.IcecreamParlor(m, arr);

        //Assert
        result.Should().BeEquivalentTo(new List<int>());
    }
}

