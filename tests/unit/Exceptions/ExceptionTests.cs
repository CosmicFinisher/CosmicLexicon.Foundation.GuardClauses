using System;
using CosmicLexicon.Foundation.GuardClauses.Exceptions;
using Xunit;

namespace CosmicLexicon.Foundation.GuardClauses.UnitTests.Exceptions
{
    public class ExceptionTests
    {
        [Fact]
        public void NotFoundException_WithInnerException_SetsInnerException()
        {
            // Arrange
            var inner = new InvalidOperationException("Inner");
            var message = "Outer";

            // Act
            var ex = new NotFoundException(message, inner);

            // Assert
            Assert.Equal(message, ex.Message);
            Assert.Same(inner, ex.InnerException);
        }
    }
}