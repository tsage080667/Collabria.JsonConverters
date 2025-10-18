using System.Text.Json;
using FluentAssertions;
using Models;

namespace JsonSerialization.Tests;

[TestClass]
public sealed class ReturnCodeConverterTests : JsonConverterTestBase
{
    [TestMethod]
    public void Given_ReturnCode_OfType_Int_Then_Should_Pass()
    {
        // Arrange
        var json = "{" +
                   "\"message\": \"\"," +
                   "\"returnCode\": 200," +
                   "\"success\": true," +
                   "\"data\": [" +
                       "{" +
                            "\"transactionId\": \"abc123\"," +
                            "\"amount\": 100.00," +
                            "\"date\": \"2025-10-10\"," +
                            "\"status\": \"posted\"" +
                       "}," +
                       "{" +
                           "\"transactionId\": \"abc124\"," +
                           "\"amount\": 500.00," +
                           "\"date\": \"2025-10-12\"," +
                           "\"status\": \"pending\"" +
                       "}" +
                    "]" +
                   "}";
        // Act
        var result = JsonSerializer.Deserialize<TransactionResultsResponse>(json, Options);

        // Assert
        result.Should().NotBeNull();
        result.ReturnCode.Should().BeOfType(typeof(int)).And
            .Subject.Should().Be(200);
    }

    [TestMethod]
    public void Given_ReturnCode_OfType_String_Then_Should_Pass()
    {
        // Arrange
        var json = "{" +
                   "\"message\": \"\"," +
                   "\"returnCode\": \"200\"," +
                   "\"success\": true," +
                   "\"data\": [" +
                       "{" +
                            "\"transactionId\": \"abc123\"," +
                            "\"amount\": 100.00," +
                            "\"date\": \"2025-10-10\"," +
                            "\"status\": \"posted\"" +
                       "}," +
                       "{" +
                           "\"transactionId\": \"abc124\"," +
                           "\"amount\": 500.00," +
                           "\"date\": \"2025-10-12\"," +
                           "\"status\": \"pending\"" +
                       "}" +
                    "]" +
                   "}";
        // Act
        var result = JsonSerializer.Deserialize<TransactionResultsResponse>(json, Options);

        // Assert
        result.Should().NotBeNull();
        result.ReturnCode.Should().BeOfType(typeof(int)).And
            .Subject.Should().Be(200);
    }
}