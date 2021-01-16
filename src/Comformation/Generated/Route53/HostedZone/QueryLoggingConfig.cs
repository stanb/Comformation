using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone QueryLoggingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-queryloggingconfig.html
    /// </summary>
    public class QueryLoggingConfig
    {

        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// 		
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs log group that Amazon Route 53 is publishing
        /// logs to.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsLogGroupArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogsLogGroupArn { get; set; }

    }
}
