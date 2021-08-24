using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule RetryPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html
    /// </summary>
    public class RetryPolicy
    {

        /// <summary>
        /// MaximumEventAgeInSeconds
        /// The maximum amount of time, in seconds, to continue to make retry attempts.
        /// Required: No
        /// Type: Integer
        /// Minimum: 60
        /// Maximum: 86400
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumEventAgeInSeconds")]
        public Union<int, IntrinsicFunction> MaximumEventAgeInSeconds { get; set; }

        /// <summary>
        /// MaximumRetryAttempts
        /// The maximum number of retry attempts to make before the request fails. Retry attempts continue until
        /// either the maximum number of attempts is made or until the duration of the MaximumEventAgeInSeconds
        /// is met.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 185
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumRetryAttempts")]
        public Union<int, IntrinsicFunction> MaximumRetryAttempts { get; set; }

    }
}
