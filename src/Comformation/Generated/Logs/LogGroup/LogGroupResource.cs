using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.LogGroup
{
    /// <summary>
    /// AWS::Logs::LogGroup
    /// The AWS::Logs::LogGroup resource creates an Amazon CloudWatch Logs log group that defines common properties
    /// for log streams, such as their retention and access control rules. Each log stream must belong to one log
    /// group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html
    /// </summary>
    public class LogGroupResource : ResourceBase
    {
        public class LogGroupProperties
        {
            /// <summary>
            /// LogGroupName
            /// A name for the log group. If you don't specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the log group. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// RetentionInDays
            /// The number of days log events are kept in CloudWatch Logs. When a log event expires, CloudWatch Logs
            /// automatically deletes it. For valid values, see PutRetentionPolicy in the Amazon CloudWatch Logs API
            /// Reference.
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
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
