using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck
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
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> HealthCheckConfig { get; set; }

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

    public static class HealthCheckAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> HealthCheckId = new ResourceAttribute<Union<string, IntrinsicFunction>>("HealthCheckId");
    }
}
