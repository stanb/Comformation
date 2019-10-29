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
            /// Overall settings for the task, in JSON format. For more information, see Task Settings in the AWS
            /// Database Migration User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskSettings { get; set; }

            /// <summary>
            /// TableMappings
            /// The table mappings for the task, in JSON format. For more information, see Table Mapping in the AWS
            /// Database Migration User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TableMappings { get; set; }

            /// <summary>
            /// CdcStartPosition
            /// Indicates when you want a change data capture (CDC) operation to start. Use either CdcStartPosition
            /// or CdcStartTime to specify when you want a CDC operation to start. Specifying both values results in
            /// an error.
            /// The value can be in date, checkpoint, or LSN/SCN format.
            /// Date Example: --cdc-start-position “2018-03-08T12:12:12”
            /// Checkpoint Example: --cdc-start-position &quot;checkpoint:V1#27#mysql-bin-changelog.
            /// 157832:1975:-1:2002:677883278264080:mysql-bin-changelog. 157832:1876#0#0#*#0#93&quot;
            /// LSN Example: --cdc-start-position “mysql-bin-changelog. 000024:373”
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CdcStartPosition { get; set; }

            /// <summary>
            /// ReplicationTaskIdentifier
            /// An identifier for the replication task.
            /// Constraints:
            /// Must contain from 1 to 255 alphanumeric characters or hyphens. First character must be a letter.
            /// Cannot end with a hyphen or contain two consecutive hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskIdentifier { get; set; }

            /// <summary>
            /// CdcStopPosition
            /// Indicates when you want a change data capture (CDC) operation to stop. The value can be either
            /// server time or commit time.
            /// Server time example: --cdc-stop-position “server_time:3018-02-09T12:12:12”
            /// Commit time example: --cdc-stop-position “commit_time: 3018-02-09T12:12:12 “
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CdcStopPosition { get; set; }

            /// <summary>
            /// SourceEndpointArn
            /// An Amazon Resource Name (ARN) that uniquely identifies the source endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceEndpointArn { get; set; }

            /// <summary>
            /// MigrationType
            /// The migration type. Valid values: full-load | cdc | full-load-and-cdc
            /// Required: Yes
            /// Type: String
            /// Allowed Values: cdc | full-load | full-load-and-cdc
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MigrationType { get; set; }

            /// <summary>
            /// TargetEndpointArn
            /// An Amazon Resource Name (ARN) that uniquely identifies the target endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TargetEndpointArn { get; set; }

            /// <summary>
            /// ReplicationInstanceArn
            /// The Amazon Resource Name (ARN) of a replication instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationInstanceArn { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags to be assigned to the replication task.
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
