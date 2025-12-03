using System;
using CosmicLexicon.Foundation.GuardClauses.Exceptions;

namespace CosmicLexicon.Foundation.GuardClauses
{
    public static class NotFoundGuardExtensions
    {
        extension(IGuardClause guardClause)
        {
            public void NotFound<TKey, TValue>(TKey key, Func<TKey, TValue?> lookup) where TValue : class
            {
                if (lookup(key) is null)
                {
                    throw new NotFoundException($"Resource with key '{key}' was not found.");
                }
            }
        }
    }
}