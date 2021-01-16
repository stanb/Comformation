using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.AggregationAuthorization
{
    /// <summary>
    /// AWS::Config::AggregationAuthorization
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html
    /// </summary>
    public class AggregationAuthorizationResource : ResourceBase
    {
        public class AggregationAuthorizationProperties
        {
            /// <summary>
            /// AuthorizedAccountId
            /// 		
            /// The 12-digit account ID of the account authorized to aggregate 			data.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Pattern: \d{12}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizedAccountId { get; set; }

            /// <summary>
            /// AuthorizedAwsRegion
            /// 		
            /// The region authorized to collect aggregated data.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizedAwsRegion { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// An array of tag object.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Config::AggregationAuthorization";

        public AggregationAuthorizationProperties Properties { get; } = new AggregationAuthorizationProperties();

    }
}
