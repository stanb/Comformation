using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.ApiCache
{
    /// <summary>
    /// AWS::AppSync::ApiCache
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apicache.html
    /// </summary>
    public class ApiCacheResource : ResourceBase
    {
        public class ApiCacheProperties
        {
            /// <summary>
            /// Type
            /// The cache instance type. Valid values are
            /// SMALL MEDIUM LARGE XLARGE LARGE_2X LARGE_4X LARGE_8X (not available in all regions) LARGE_12X
            /// Historically, instance types were identified by an EC2-style value. As of July 2020, this is
            /// deprecated, and the generic identifiers above should be used.
            /// The following legacy instance types are available, but their use is discouraged:
            /// T2_SMALL: A t2. small instance type. T2_MEDIUM: A t2. medium instance type. R4_LARGE: A r4. large
            /// instance type. R4_XLARGE: A r4. xlarge instance type. R4_2XLARGE: A r4. 2xlarge instance type.
            /// R4_4XLARGE: A r4. 4xlarge instance type. R4_8XLARGE: A r4. 8xlarge instance type.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// TransitEncryptionEnabled
            /// Transit encryption flag when connecting to cache. This setting cannot be updated after creation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> TransitEncryptionEnabled { get; set; }

            /// <summary>
            /// AtRestEncryptionEnabled
            /// At rest encryption flag for cache. This setting cannot be updated after creation.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AtRestEncryptionEnabled { get; set; }

            /// <summary>
            /// ApiId
            /// The GraphQL API Id.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// ApiCachingBehavior
            /// Caching behavior.
            /// FULL_REQUEST_CACHING: All requests are fully cached. PER_RESOLVER_CACHING: Individual resolvers that
            /// you specify are cached.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApiCachingBehavior { get; set; }

            /// <summary>
            /// Ttl
            /// TTL in seconds for cache entries.
            /// Valid values are between 1 and 3600 seconds.
            /// Required: Yes
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> Ttl { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::ApiCache";

        public ApiCacheProperties Properties { get; } = new ApiCacheProperties();

    }
}
