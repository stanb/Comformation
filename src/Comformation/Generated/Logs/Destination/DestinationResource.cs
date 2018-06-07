using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.Destination
{
    /// <summary>
    /// AWS::Logs::Destination
    /// The AWS::Logs::Destination resource creates an Amazon CloudWatch Logs (CloudWatch Logs) destination, which
    /// enables you to specify a physical resource (such as an Kinesis stream) that subscribes to CloudWatch Logs log
    /// events from another AWS account. For more information, see Cross-Account Log Data Sharing with Subscriptions
    /// in the Amazon CloudWatch User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html
    /// </summary>
    public class DestinationResource : ResourceBase
    {
        public class DestinationProperties
        {
            /// <summary>
            /// DestinationName
            /// The name of the CloudWatch Logs destination.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html#cfn-logs-destination-destinationname
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationName { get; set; }

            /// <summary>
            /// DestinationPolicy
            /// An AWS Identity and Access Management (IAM) policy that specifies who can write to your destination.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html#cfn-logs-destination-destinationpolicy
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationPolicy { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of an IAM role that permits CloudWatch Logs to send data to the
            /// specified AWS resource (TargetArn).
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html#cfn-logs-destination-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// TargetArn
            /// The ARN of the AWS resource that receives log events. Currently, you can specify only an Kinesis
            /// stream.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-destination.html#cfn-logs-destination-targetarn
            /// </summary>
			public Union<string, IntrinsicFunction> TargetArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::Destination";
        
        public DestinationProperties Properties { get; } = new DestinationProperties();
    }

	public static class DestinationAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
