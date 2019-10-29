using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// AWS::Route53::HealthCheck AlarmIdentifier
    /// A complex type that identifies the CloudWatch alarm that you want Amazon Route 53 health checkers to use to
    /// determine whether 			the specified health check is healthy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-alarmidentifier.html
    /// </summary>
    public class AlarmIdentifier
    {

        /// <summary>
        /// Name
        /// 		
        /// The name of the CloudWatch alarm that you want Amazon Route 53 health checkers to use to determine
        /// whether this health check is healthy.
        /// 		
        /// Note Route 53 supports CloudWatch alarms with the following features: 				 				 			
        /// Standard-resolution metrics. High-resolution metrics aren&#39;t supported. For more information, see
        /// 					High-Resolution Metrics 					in the Amazon CloudWatch User Guide. Statistics: Average, Minimum,
        /// Maximum, Sum, and SampleCount. Extended statistics aren&#39;t supported.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Region
        /// 		
        /// For the CloudWatch alarm that you want Route 53 health checkers to use to determine whether this
        /// health check is healthy, 			the region that the alarm was created in.
        /// 		
        /// For the current list of CloudWatch regions, see Amazon CloudWatch in 			the AWS Service Endpoints
        /// chapter of the Amazon Web Services General Reference.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ap-east-1 | ap-northeast-1 | ap-northeast-2 | ap-northeast-3 | ap-south-1 |
        /// ap-southeast-1 | ap-southeast-2 | ca-central-1 | cn-north-1 | cn-northwest-1 | eu-central-1 |
        /// eu-north-1 | eu-west-1 | eu-west-2 | eu-west-3 | me-south-1 | sa-east-1 | us-east-1 | us-east-2 |
        /// us-west-1 | us-west-2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
