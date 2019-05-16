using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.ReplicationTask
{
    /// <summary>
    /// AWS::DMS::ReplicationTask
    /// The AWS::DMS::ReplicationTask resource creates an AWS DMS replication task.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationtask.html
    /// </summary>
    public class ReplicationTaskResource : ResourceBase
    {
        public class ReplicationTaskProperties
        {
            /// <summary>
            /// ReplicationTaskSettings
            /// Settings for the task, such as target metadata settings. For a complete list of task settings, see
            /// Task Settings for AWS Database Migration Service Tasks in the AWS Database Migration User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskSettings { get; set; }

            /// <summary>
            /// TableMappings
            /// When using the AWS CLI or boto3, provide the path of the JSON file that contains the table mappings.
            /// Precede the path with &quot;file://&quot;. When working with the DMS API, provide the JSON as the parameter
            /// value.
            /// For example, --table-mappings file://mappingfile. json
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TableMappings { get; set; }

            /// <summary>
            /// ReplicationTaskIdentifier
            /// The replication task identifier.
            /// Constraints:
            /// Must contain from 1 to 255 alphanumeric characters or hyphens. First character must be a letter.
            /// Cannot end with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskIdentifier { get; set; }

            /// <summary>
            /// SourceEndpointArn
            /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceEndpointArn { get; set; }

            /// <summary>
            /// MigrationType
            /// The migration type.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: cdc | full-load | full-load-and-cdc
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MigrationType { get; set; }

            /// <summary>
            /// TargetEndpointArn
            /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TargetEndpointArn { get; set; }

            /// <summary>
            /// ReplicationInstanceArn
            /// The Amazon Resource Name (ARN) of the replication instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationInstanceArn { get; set; }

            /// <summary>
            /// Tags
            /// Tags to be added to the replication instance.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// CdcStartTime
            /// Indicates the start time for a change data capture (CDC) operation.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> CdcStartTime { get; set; }

        }

        public string Type { get; } = "AWS::DMS::ReplicationTask";

        public ReplicationTaskProperties Properties { get; } = new ReplicationTaskProperties();

    }
}
