using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck
    /// Use the AWS::Route53::HealthCheck resource to check the health of your resources before Amazon Route 53
    /// responds to a DNS query. For more information, see How Health Checks Work in Simple Amazon Route 53
    /// Configurations in the Amazon Route 53 Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html
    /// </summary>
    public class HealthCheckResource : ResourceBase
    {
        public class HealthCheckProperties
        {
            /// <summary>
            /// HealthCheckConfig
            /// An Amazon Route 53 health check.
            /// Required: Yes
            /// Type: Route 53 HealthCheck HealthCheckConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthcheckconfig
            /// </summary>
			public Union<HealthCheckConfig, IntrinsicFunction> HealthCheckConfig { get; set; }

            /// <summary>
            /// HealthCheckTags
            /// An arbitrary set of tags (key–value pairs) for this health check.
            /// Required: No
            /// Type: A list of Amazon Route 53 HealthCheck HealthCheckTags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthchecktags
            /// </summary>
			public Union<List<HealthCheckTag>, IntrinsicFunction> HealthCheckTags { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::HealthCheck";
        
        public HealthCheckProperties Properties { get; } = new HealthCheckProperties();
    }
}
