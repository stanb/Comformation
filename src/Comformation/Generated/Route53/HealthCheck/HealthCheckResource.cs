using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck
    /// The AWS::Route53::HealthCheck resource is a Route 53 resource type that contains settings for 			a Route 53
    /// health check.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html
    /// </summary>
    public class HealthCheckResource : ResourceBase
    {
        public class HealthCheckProperties
        {
            /// <summary>
            /// HealthCheckConfig
            /// 		
            /// A complex type that contains detailed information about one health check.
            /// 	
            /// Required: Yes
            /// Type: HealthCheckConfig
            /// Update requires: No interruption
            /// </summary>
			public HealthCheckConfig HealthCheckConfig { get; set; }

            /// <summary>
            /// HealthCheckTags
            /// 		
            /// The HealthCheckTags property describes key-value pairs that are associated with an
            /// AWS::Route53::HealthCheck resource.
            /// 	
            /// Required: No
            /// Type: List of HealthCheckTag
            /// Update requires: No interruption
            /// </summary>
			public List<HealthCheckTag> HealthCheckTags { get; set; }

        }

        public string Type { get; } = "AWS::Route53::HealthCheck";

        public HealthCheckProperties Properties { get; } = new HealthCheckProperties();

    }
}
