using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBInstance
{
    /// <summary>
    /// AWS::Neptune::DBInstance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html
    /// </summary>
    public class DBInstanceResource : ResourceBase
    {
        public class DBInstanceProperties
        {
            /// <summary>
            /// DBParameterGroupName
            /// The name of an existing DB parameter group or a reference to an AWS::Neptune::DBParameterGroup
            /// resource created in the template. If any of the data members of the referenced parameter group are
            /// changed during an update, the DB instance might need to be restarted, which causes some
            /// interruption. If the parameter group contains static parameters, whether they were changed or not,
            /// an update triggers a reboot.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DBParameterGroupName { get; set; }

            /// <summary>
            /// DBInstanceClass
            /// Contains the name of the compute and memory capacity class of the DB instance.
            /// If you update this property, some interruptions may occur.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DBInstanceClass { get; set; }

            /// <summary>
            /// AllowMajorVersionUpgrade
            /// Indicates that major version upgrades are allowed. Changing this parameter doesn&#39;t result in an
            /// outage and the change is asynchronously applied as soon as possible. This parameter must be set to
            /// true when specifying a value for the EngineVersion parameter that is a different major version than
            /// the DB instance&#39;s current version.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// If the DB instance is a member of a DB cluster, contains the name of the DB cluster that the DB
            /// instance is a member of.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// Specifies the name of the Availability Zone the DB instance is located in.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// Specifies the weekly time range during which system maintenance can occur, in Universal Coordinated
            /// Time (UTC).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor version patches are applied automatically.
            /// When updating this property, some interruptions may occur.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group to associate with the DB instance. If you update this value, the new subnet group
            /// must be a subnet group in a new virtual private cloud (VPC).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DBInstanceIdentifier
            /// Contains a user-supplied database identifier. This identifier is the unique key that identifies a DB
            /// instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBInstanceIdentifier { get; set; }

            /// <summary>
            /// DBSnapshotIdentifier
            /// This parameter is not supported.
            /// AWS::Neptune::DBInstance does not support restoring from snapshots.
            /// AWS::Neptune::DBCluster does support restoring from snapshots.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBSnapshotIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this DB instance.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Neptune::DBInstance";

        public DBInstanceProperties Properties { get; } = new DBInstanceProperties();

    }

    public static class DBInstanceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Port");
    }
}
