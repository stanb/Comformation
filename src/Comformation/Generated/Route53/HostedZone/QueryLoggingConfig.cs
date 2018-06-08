using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// Route 53 QueryLoggingConfig
    /// The QueryLoggingConfig property is part of the AWS::Route53::HostedZone resource that specifies a
    /// configuration for DNS query logging. After you create a query logging configuration, Amazon Route 53 begins to
    /// publish log data to an Amazon CloudWatch Logs log group. For more information, see CreateQueryLoggingConfig in
    /// the Amazon Route 53 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-queryloggingconfig.html
    /// </summary>
    public class QueryLoggingConfig
    {

        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// The Amazon Resource Name (ARN) for the log group that you want Amazon Route 53 to send query logs
        /// to. This is the format of the ARN:
        /// arn:aws:logs:region:account-id:log-group:log_group_name
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("CloudWatchLogsLogGroupArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogsLogGroupArn { get; set; }

    }
}
