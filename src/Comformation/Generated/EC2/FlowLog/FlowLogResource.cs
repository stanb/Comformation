using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.FlowLog
{
    /// <summary>
    /// AWS::EC2::FlowLog
    /// The AWS::EC2::FlowLog resource creates an Amazon Elastic Compute Cloud (Amazon EC2) flow log that captures IP
    /// traffic for a specified network interface, subnet, or VPC. To view the log data, use Amazon CloudWatch Logs
    /// (CloudWatch Logs) to help troubleshoot connection issues. For example, you can use a flow log to investigate
    /// why certain traffic isn&#39;t reaching an instance, which can help you diagnose overly restrictive security group
    /// rules. For more information, see VPC Flow Logs in the Amazon VPC User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html
    /// </summary>
    public class FlowLogResource : ResourceBase
    {
        public class FlowLogProperties
        {
            /// <summary>
            /// DeliverLogsPermissionArn
            /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that permits
            /// Amazon EC2 to publish flow logs to a CloudWatch Logs log group in your account.
            /// If you specify LogDestinationType as s3, do not specify DeliverLogsPermissionArn or LogGroupName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeliverLogsPermissionArn { get; set; }

            /// <summary>
            /// LogDestination
            /// Specifies the destination to which the flow log data is to be published. Flow log data can be
            /// published to a CloudWatch Logs log group or an Amazon S3 bucket. The value specified for this
            /// parameter depends on the value specified for LogDestinationType.
            /// If LogDestinationType is not specified or cloud-watch-logs, specify the Amazon Resource Name (ARN)
            /// of the CloudWatch Logs log group. If LogDestinationType is s3, specify the ARN of the Amazon S3
            /// bucket. You can also specify a subfolder in the bucket. To specify a subfolder in the bucket, use
            /// the following ARN format: bucket_ARN/subfolder_name/. For example, to specify a subfolder named
            /// my-logs in a bucket named my-bucket , use the following ARN: arn:aws:s3:::my-bucket/my-logs/.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogDestination { get; set; }

            /// <summary>
            /// LogDestinationType
            /// Specifies the type of destination to which the flow log data is to be published. Flow log data can
            /// be published to CloudWatch Logs or Amazon S3. To publish flow log data to CloudWatch Logs, specify
            /// cloud-watch-logs. To publish flow log data to Amazon S3, specify s3.
            /// If you specify LogDestinationType as s3, do not specify DeliverLogsPermissionArn or LogGroupName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogDestinationType { get; set; }

            /// <summary>
            /// LogGroupName
            /// The name of a new or existing CloudWatch Logs log group where Amazon EC2 publishes your flow logs.
            /// If you specify LogDestinationType as s3, do not specify DeliverLogsPermissionArn or LogGroupName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// ResourceId
            /// The ID of the subnet, network interface, or VPC for which you want to create a flow log.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// ResourceType
            /// The type of resource that you specified in the ResourceId property. For example, if you specified a
            /// VPC ID for the ResourceId property, specify VPC for this property. For valid values, see the
            /// ResourceType parameter for the CreateFlowLogs action in the Amazon EC2 API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceType { get; set; }

            /// <summary>
            /// TrafficType
            /// The type of traffic to log. You can log traffic that the resource accepts or rejects, or all
            /// traffic. For valid values, see the TrafficType parameter for the CreateFlowLogs action in the Amazon
            /// EC2 API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TrafficType { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::FlowLog";
        
        public FlowLogProperties Properties { get; } = new FlowLogProperties();

    }
}
