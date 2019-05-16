using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.Destination
{
    /// <summary>
    /// AWS::Logs::Destination
    /// The AWS::Logs::Destination resource specifies a CloudWatch Logs destination. A destination encapsulates a
    /// physical resource (such as an Amazon Kinesis data stream) and enables you to subscribe that resource to a
    /// stream of log events.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html
    /// </summary>
    public class DestinationResource : ResourceBase
    {
        public class DestinationProperties
        {
            /// <summary>
            /// DestinationName
            /// The name of the destination.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [^:*]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationName { get; set; }

            /// <summary>
            /// DestinationPolicy
            /// An IAM policy document that governs which AWS accounts can create subscription filters against this
            /// destination.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationPolicy { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of an IAM role that permits CloudWatch Logs to send data to the specified AWS resource.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// TargetArn
            /// The Amazon Resource Name (ARN) of the physical target to where the log events are delivered (for
            /// example, a Kinesis stream).
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetArn { get; set; }

        }

        public string Type { get; } = "AWS::Logs::Destination";

        public DestinationProperties Properties { get; } = new DestinationProperties();

    }

	public static class DestinationAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
