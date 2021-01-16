using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS::CloudTrail::Trail
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-trail.html
    /// </summary>
    public class TrailResource : ResourceBase
    {
        public class TrailProperties
        {
            /// <summary>
            /// CloudWatchLogsLogGroupArn
            /// Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier that represents
            /// the log group to which CloudTrail logs will be delivered. Not required unless you specify
            /// CloudWatchLogsRoleArn.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CloudWatchLogsLogGroupArn { get; set; }

            /// <summary>
            /// CloudWatchLogsRoleArn
            /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user&#39;s log group.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CloudWatchLogsRoleArn { get; set; }

            /// <summary>
            /// EnableLogFileValidation
            /// Specifies whether log file validation is enabled. The default is false.
            /// Note When you disable log file integrity validation, the chain of digest files is broken after one
            /// hour. CloudTrail will not create digest files for log files that were delivered during a period in
            /// which log file integrity validation was disabled. For example, if you enable log file integrity
            /// validation at noon on January 1, disable it at noon on January 2, and re-enable it at noon on
            /// January 10, digest files will not be created for the log files delivered from noon on January 2 to
            /// noon on January 10. The same applies whenever you stop CloudTrail logging or delete a trail.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableLogFileValidation { get; set; }

            /// <summary>
            /// EventSelectors
            /// Use event selectors to further specify the management and data event settings for your trail. By
            /// default, trails created without specific event selectors will be configured to log all read and
            /// write management events, and no data events. When an event occurs in your account, CloudTrail
            /// evaluates the event selector for all trails. For each trail, if the event matches any event
            /// selector, the trail processes and logs the event. If the event doesn&#39;t match any event selector, the
            /// trail doesn&#39;t log the event.
            /// You can configure up to five event selectors for a trail.
            /// You cannot apply both event selectors and advanced event selectors to a trail.
            /// Required: No
            /// Type: List of EventSelector
            /// Update requires: No interruption
            /// </summary>
            public List<EventSelector> EventSelectors { get; set; }

            /// <summary>
            /// IncludeGlobalServiceEvents
            /// Specifies whether the trail is publishing events from global services such as IAM to the log files.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> IncludeGlobalServiceEvents { get; set; }

            /// <summary>
            /// IsLogging
            /// Whether the CloudTrail is currently logging AWS API calls.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> IsLogging { get; set; }

            /// <summary>
            /// IsMultiRegionTrail
            /// Specifies whether the trail applies only to the current region or to all regions. The default is
            /// false. If the trail exists only in the current region and this value is set to true, shadow trails
            /// (replications of the trail) will be created in the other regions. If the trail exists in all regions
            /// and this value is set to false, the trail will remain in the region where it was created, and its
            /// shadow trails in other regions will be deleted. As a best practice, consider using trails that log
            /// events in all regions.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> IsMultiRegionTrail { get; set; }

            /// <summary>
            /// KMSKeyId
            /// Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail. The value can be an
            /// alias name prefixed by &quot;alias/&quot;, a fully specified ARN to an alias, a fully specified ARN to a key,
            /// or a globally unique identifier.
            /// Examples:
            /// alias/MyAliasName arn:aws:kms:us-east-2:123456789012:alias/MyAliasName
            /// arn:aws:kms:us-east-2:123456789012:key/12345678-1234-1234-1234-123456789012
            /// 12345678-1234-1234-1234-123456789012
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KMSKeyId { get; set; }

            /// <summary>
            /// S3BucketName
            /// Specifies the name of the Amazon S3 bucket designated for publishing log files. See Amazon S3 Bucket
            /// Naming Requirements.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3BucketName { get; set; }

            /// <summary>
            /// S3KeyPrefix
            /// Specifies the Amazon S3 key prefix that comes after the name of the bucket you have designated for
            /// log file delivery. For more information, see Finding Your CloudTrail Log Files. The maximum length
            /// is 200 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

            /// <summary>
            /// SnsTopicName
            /// Specifies the name of the Amazon SNS topic defined for notification of log file delivery. The
            /// maximum length is 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SnsTopicName { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this trail.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TrailName
            /// Specifies the name of the trail. The name must meet the following requirements:
            /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (. ), underscores (_), or dashes (-)
            /// Start with a letter or number, and end with a letter or number Be between 3 and 128 characters Have
            /// no adjacent periods, underscores or dashes. Names like my-_namespace and my--namespace are invalid.
            /// Not be in IP address format (for example, 192. 168. 5. 4)
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TrailName { get; set; }

        }

        public string Type { get; } = "AWS::CloudTrail::Trail";

        public TrailProperties Properties { get; } = new TrailProperties();

    }

    public static class TrailAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SnsTopicArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SnsTopicArn");
    }
}
