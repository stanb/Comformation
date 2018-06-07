using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS::CloudTrail::Trail
    /// Use the AWS::CloudTrail::Trail resource to create a trail and specify where logs are published. An AWS
    /// CloudTrail (CloudTrail) trail can capture AWS API calls made by your AWS account and publish the logs to an
    /// Amazon S3 bucket. For more information, see What is AWS CloudTrail? in the AWS CloudTrail User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html
    /// </summary>
    public class TrailResource : ResourceBase
    {
        public class TrailProperties
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// The Amazon Resource Name (ARN) of a log group to which CloudTrail logs will be delivered.
            /// Required: Conditional. This property is required if you specify the CloudWatchLogsRoleArn property.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-cloudwatchlogsloggrouparn
            /// </summary>
			public Union<string, IntrinsicFunction> CloudWatchLogsLogGroupArn { get; set; }

            /// <summary>
            /// CloudWatchLogsRoleArn
            /// The role ARN that Amazon CloudWatch Logs (CloudWatch Logs) assumes to write logs to a log group. For
            /// more information, see Role Policy Document for CloudTrail to Use CloudWatch Logs for Monitoring in
            /// the AWS CloudTrail User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-cloudwatchlogsrolearn
            /// </summary>
			public Union<string, IntrinsicFunction> CloudWatchLogsRoleArn { get; set; }

            /// <summary>
            /// EnableLogFileValidation
            /// Indicates whether CloudTrail validates the integrity of log files. By default, AWS CloudFormation
            /// sets this value to false. When you disable log file integrity validation, CloudTrail stops creating
            /// digest files. For more information, see CreateTrail in the AWS CloudTrail API Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-enablelogfilevalidation
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableLogFileValidation { get; set; }

            /// <summary>
            /// EventSelectors
            /// Configures logging for management and data events.
            /// Required: No
            /// Type: List of CloudTrail Trail EventSelector
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-eventselectors
            /// </summary>
			public Union<List<EventSelector>, IntrinsicFunction> EventSelectors { get; set; }

            /// <summary>
            /// IncludeGlobalServiceEvents
            /// Indicates whether the trail is publishing events from global services, such as IAM, to the log
            /// files. By default, AWS CloudFormation sets this value to false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-includeglobalserviceevents
            /// </summary>
			public Union<bool, IntrinsicFunction> IncludeGlobalServiceEvents { get; set; }

            /// <summary>
            /// IsLogging
            /// Indicates whether the CloudTrail trail is currently logging AWS API calls.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-islogging
            /// </summary>
			public Union<bool, IntrinsicFunction> IsLogging { get; set; }

            /// <summary>
            /// IsMultiRegionTrail
            /// Indicates whether the CloudTrail trail is created in the region in which you create the stack
            /// (false) or in all regions (true). By default, AWS CloudFormation sets this value to false. For more
            /// information, see How Does CloudTrail Behave Regionally and Globally? in the AWS CloudTrail User
            /// Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-ismultiregiontrail
            /// </summary>
			public Union<bool, IntrinsicFunction> IsMultiRegionTrail { get; set; }

            /// <summary>
            /// KMSKeyId
            /// The AWS Key Management Service (AWS KMS) key ID that you want to use to encrypt CloudTrail logs. You
            /// can specify an alias name (prefixed with alias/), an alias ARN, a key ARN, or a globally unique
            /// identifier.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-kmskeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KMSKeyId { get; set; }

            /// <summary>
            /// S3BucketName
            /// The name of the Amazon S3 bucket where CloudTrail publishes log files.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-s3bucketname
            /// </summary>
			public Union<string, IntrinsicFunction> S3BucketName { get; set; }

            /// <summary>
            /// S3KeyPrefix
            /// An Amazon S3 object key prefix that precedes the name of all log files.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-s3keyprefix
            /// </summary>
			public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

            /// <summary>
            /// SnsTopicName
            /// The name of an Amazon SNS topic that is notified when new log files are published.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-snstopicname
            /// </summary>
			public Union<string, IntrinsicFunction> SnsTopicName { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this trail.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// TrailName
            /// The name of the trail. For constraint information, see CreateTrail in the AWS CloudTrail API
            /// Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html#cfn-cloudtrail-trail-trailname
            /// </summary>
			public Union<string, IntrinsicFunction> TrailName { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudTrail::Trail";
        
        public TrailProperties Properties { get; } = new TrailProperties();
    }

	public static class TrailAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> SnsTopicArn = new ResourceAttribute<string>("SnsTopicArn");
	}
}
