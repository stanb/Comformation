using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver CachingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html
    /// </summary>
    public class CachingConfig
    {

        /// <summary>
        /// CachingKeys
        /// The caching keys for a resolver that has caching enabled.
        /// Valid values are entries from the $context. arguments, $context. source, and $context. identity
        /// maps.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CachingKeys")]
        public List<Union<string, IntrinsicFunction>> CachingKeys { get; set; }

        /// <summary>
        /// Ttl
        /// The TTL in seconds for a resolver that has caching enabled.
        /// Valid values are between 1 and 3600 seconds.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ttl")]
        public Union<double, IntrinsicFunction> Ttl { get; set; }

    }
}
