using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmicLexicon.Foundation.GuardClauses
{
    /// <summary>
    /// Provides extension methods for null-related guard clauses.
    /// </summary>
    public static class GuardClauseNullExtensions
    {
        extension(IGuardClause guardClause)
        {
            /// <summary>
            /// Throws <see cref="ArgumentNullException"/> if the input is null.
            /// </summary>
            /// <typeparam name="T">The type of the input.</typeparam>
            /// <param name="guardClause">The guard clause instance.</param>
            /// <param name="input">The input to check for nullity.</param>
            /// <param name="parameterName">The name of the parameter.</param>
            /// <param name="message">An optional custom error message.</param>
            public void Null<T>(T input, string parameterName, string? message = null)
            {
                if (input is null)
                {
                    throw new ArgumentNullException(parameterName, message ?? $"Parameter [{parameterName}] cannot be null.");
                }
            }

            /// <summary>
            /// Throws <see cref="ArgumentNullException"/> if the input string is null,
            /// or <see cref="ArgumentException"/> if the input string is empty.
            /// </summary>
            /// <param name="guardClause">The guard clause instance.</param>
            /// <param name="input">The string to check.</param>
            /// <param name="parameterName">The name of the parameter.</param>
            /// <param name="message">An optional custom error message.</param>
            public void NullOrEmpty(string? input, string parameterName, string? message = null)
            {
                if (input is null)
                {
                    throw new ArgumentNullException(parameterName, message ?? $"Parameter [{parameterName}] cannot be null.");
                }
                if (input == string.Empty)
                {
                    throw new ArgumentException(message ?? $"Parameter [{parameterName}] cannot be empty.", parameterName);
                }
            }

            /// <summary>
            /// Throws <see cref="ArgumentNullException"/> if the input string is null,
            /// or <see cref="ArgumentException"/> if the input string is empty or consists only of white-space characters.
            /// </summary>
            /// <param name="guardClause">The guard clause instance.</param>
            /// <param name="input">The string to check.</param>
            /// <param name="parameterName">The name of the parameter.</param>
            /// <param name="message">An optional custom error message.</param>
            public void NullOrWhiteSpace(string? input, string parameterName, string? message = null)
            {
                if (input is null)
                {
                    throw new ArgumentNullException(parameterName, message ?? $"Parameter [{parameterName}] cannot be null.");
                }
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException(message ?? $"Parameter [{parameterName}] cannot be empty or whitespace.", parameterName);
                }
            }
        }
    }
}