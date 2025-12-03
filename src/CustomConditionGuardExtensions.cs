using System;

namespace CosmicLexicon.Foundation.GuardClauses
{
    public static class CustomConditionGuardExtensions
    {
        extension(IGuardClause guardClause)
        {
            public void CustomCondition(bool condition, string parameterName)
            {
                if (condition)
                {
                    throw new ArgumentException("The specified condition was met, indicating an invalid state.", parameterName);
                }
            }
        }
    }
}