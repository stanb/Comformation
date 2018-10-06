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
            /// Task Settings for AWS Database Migration Service Tasks in the AWS Database Migration Service User
            /// Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskSettings { get; set; }

            /// <summary>
            /// TableMappings
            /// The JSON that contains additional parameter values.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TableMappings { get; set; }

            /// <summary>
            /// ReplicationTaskIdentifier
            /// The ARN string that uniquely identifies the endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationTaskIdentifier { get; set; }

            /// <summary>
            /// SourceEndpointArn
            /// The ARN string that uniquely identifies the endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceEndpointArn { get; set; }

            /// <summary>
            /// MigrationType
            /// The migration type.
            /// Valid Values: full-load, cdc, full-load-and-cdc
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MigrationType { get; set; }

            /// <summary>
            /// TargetEndpointArn
            /// The ARN string that uniquely identifies the endpoint.
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
            /// The tags that you want to attach to the migration task.
            /// Required: No
            /// Type: List of resource tags in key-value format
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// CdcStartTime
            /// The start time for the Change Data Capture (CDC) operation.
            /// Required: No
            /// Type: Number, epoch value in milliseconds
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> CdcStartTime { get; set; }

        }
    
        public string Type { get; } = "AWS::DMS::ReplicationTask";
        
        public ReplicationTaskProperties Properties { get; } = new ReplicationTaskProperties();

    }
}
