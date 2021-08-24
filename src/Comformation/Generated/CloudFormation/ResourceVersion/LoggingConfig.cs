using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.ResourceVersion
{
    /// <summary>
    /// AWS::CloudFormation::ResourceVersion LoggingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-resourceversion-loggingconfig.html
    /// </summary>
    public class LoggingConfig
    {

        /// <summary>
        /// LogGroupName
        /// The Amazon CloudWatch log group to which CloudFormation sends error logging information when
        /// invoking the type&#39;s handlers.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: [\. \-_/#A-Za-z0-9]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// LogRoleArn
        /// The ARN of the role that CloudFormation should assume when sending log entries to CloudWatch logs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: arn:. +:iam::[0-9]{12}:role/. +
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LogRoleArn")]
        public Union<string, IntrinsicFunction> LogRoleArn { get; set; }

    }
}
