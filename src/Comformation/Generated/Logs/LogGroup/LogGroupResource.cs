using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.LogGroup
{
    /// <summary>
    /// AWS::Logs::LogGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html
    /// </summary>
    public class LogGroupResource : ResourceBase
    {
        public class LogGroupProperties
        {
            /// <summary>
            /// LogGroupName
            /// The name of the log group. If you don&#39;t specify a name, AWS CloudFormation generates a unique ID for
            /// the log group.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [\. \-_/#A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of the CMK to use when encrypting log data.
            /// Required: No
            /// Type: String
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// RetentionInDays
            /// The number of days to retain the log events in the specified log group. Possible values are: 1, 3,
            /// 5, 7, 14, 30, 60, 90, 120, 150, 180, 365, 400, 545, 731, 1827, and 3653.
            /// If you omit retentionInDays in a PutRetentionPolicy operation, the events in the log group are
            /// always retained and never expire.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RetentionInDays { get; set; }

        }

        public string Type { get; } = "AWS::Logs::LogGroup";

        public LogGroupProperties Properties { get; } = new LogGroupProperties();

    }

    public static class LogGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
