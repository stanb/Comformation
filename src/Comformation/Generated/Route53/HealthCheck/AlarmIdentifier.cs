using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// Amazon Route 53 HealthCheck AlarmIdentifier
    /// The AlarmIdentifier subproperty describes the name and Region that are associated with an Route 53 HealthCheck
    /// HealthCheckConfig property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-healthcheckconfig-alarmidentifier.html
    /// </summary>
    public class AlarmIdentifier
    {

        /// <summary>
        /// Name
        /// The name of the Amazon CloudWatch alarm that you want Route 53 health checkers to use to determine
        /// whether this health check is healthy.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Region
        /// A complex type that identifies the CloudWatch alarm that you want Route 53 health checkers to use to
        /// determine whether this health check is healthy. For example, us-west-2.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
