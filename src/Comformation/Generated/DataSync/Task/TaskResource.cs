using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.Task
{
    /// <summary>
    /// AWS::DataSync::Task
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-task.html
    /// </summary>
    public class TaskResource : ResourceBase
    {
        public class TaskProperties
        {
            /// <summary>
            /// Excludes
            /// A list of filter rules that determines which files to exclude from a task. The list should contain a
            /// single filter string that consists of the patterns to exclude. The patterns are delimited by &quot;|&quot;
            /// (that is, a pipe), for example, &quot;/folder1|/folder2&quot;.
            /// Required: No
            /// Type: List of FilterRule
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<FilterRule> Excludes { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents the tag that you want to add to the resource. The value can be an
            /// empty string.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// CloudWatchLogGroupArn
            /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that is used to monitor and log
            /// events in the task.
            /// For more information about how to use CloudWatch Logs with DataSync, see Monitoring Your Task in the
            /// AWS DataSync User Guide.
            /// For more information about these groups, see Working with Log Groups and Log Streams in the Amazon
            /// CloudWatch Logs User Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 562
            /// Pattern:
            /// ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):logs:[a-z\-0-9]*:[0-9]{12}:log-group:([^:\*]*)(:\*)?$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CloudWatchLogGroupArn { get; set; }

            /// <summary>
            /// DestinationLocationArn
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationLocationArn { get; set; }

            /// <summary>
            /// Name
            /// The name of a task. This value is a text reference that is used to identify the task in the console.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9\s+=. _:@/-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Options
            /// The set of configuration options that control the behavior of a single execution of the task that
            /// occurs when you call StartTaskExecution. You can configure these options to preserve metadata such
            /// as user ID (UID) and group ID (GID), file permissions, data integrity verification, and so on.
            /// For each individual task execution, you can override these options by specifying the OverrideOptions
            /// before starting the task execution. For more information, see the API_StartTaskExecution operation.
            /// Required: No
            /// Type: Options
            /// Update requires: No interruption
            /// </summary>
            public Options Options { get; set; }

            /// <summary>
            /// Schedule
            /// Specifies a schedule used to periodically transfer files from a source to a destination location.
            /// The schedule should be specified in UTC time. For more information, see task-scheduling.
            /// Required: No
            /// Type: TaskSchedule
            /// Update requires: No interruption
            /// </summary>
            public TaskSchedule Schedule { get; set; }

            /// <summary>
            /// SourceLocationArn
            /// The Amazon Resource Name (ARN) of the source location for the task.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern:
            /// ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):datasync:[a-z\-0-9]+:[0-9]{12}:location/loc-[0-9a-z]{17}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceLocationArn { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::Task";

        public TaskProperties Properties { get; } = new TaskProperties();

    }

    public static class TaskAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TaskArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TaskArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ErrorCode = new ResourceAttribute<Union<string, IntrinsicFunction>>("ErrorCode");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ErrorDetail = new ResourceAttribute<Union<string, IntrinsicFunction>>("ErrorDetail");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> SourceNetworkInterfaceArns = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("SourceNetworkInterfaceArns");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> DestinationNetworkInterfaceArns = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("DestinationNetworkInterfaceArns");
    }
}
