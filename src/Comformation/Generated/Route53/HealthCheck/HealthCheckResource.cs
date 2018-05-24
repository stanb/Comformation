using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html
    /// </summary>
    public class HealthCheckResource : ResourceBase
    {
        public class HealthCheckProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthcheckconfig
            /// </summary>
			public Union<HealthCheckConfig, IntrinsicFunction> HealthCheckConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-healthcheck.html#cfn-route53-healthcheck-healthchecktags
            /// </summary>
			public Union<List<HealthCheckTag>, IntrinsicFunction> HealthCheckTags { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::HealthCheck";
        
        public HealthCheckProperties Properties { get; } = new HealthCheckProperties();
    }
}
