using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBInstance
{
    /// <summary>
    /// AWS::Neptune::DBInstance
    /// The AWS::Neptune::DBInstance type creates an Neptune DB instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html
    /// </summary>
    public class DBInstanceResource : ResourceBase
    {
        public class DBInstanceProperties
        {
            /// <summary>
            /// DBParameterGroupName
            /// The name of an existing DB parameter group or a reference to an AWS::Neptune::DBParameterGroup
            /// resource created in the template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. If any of the data members of the referenced
            /// parameter group are changed during an update, the DB instance might need to be restarted, which
            /// causes some interruption. If the parameter group contains static parameters, whether they were
            /// changed or not, an update triggers a reboot.
            /// </summary>
			public Union<string, IntrinsicFunction> DBParameterGroupName { get; set; }

            /// <summary>
            /// DBInstanceClass
            /// The name of the compute and memory capacity classes of the DB instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceClass { get; set; }

            /// <summary>
            /// AllowMajorVersionUpgrade
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The name of an existing DB cluster that this instance is associated with.
            /// Neptune assigns the first DB instance in the cluster as the primary, and additional DB instances as
            /// replicas.
            /// If you specify this property, the default deletion policy is Delete. Otherwise, the default deletion
            /// policy is Snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The name of the Availability Zone where the DB instance is located. You can't set the
            /// AvailabilityZone parameter if the MultiAZ parameter is set to true.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur. For valid values, see the
            /// PreferredMaintenanceWindow parameter for the CreateDBInstance action in the .
            /// Note This property applies when AWS CloudFormation initially creates the DB instance. If you use AWS
            /// CloudFormation to update the DB instance, those updates are applied immediately.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the .
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor engine upgrades are applied automatically to the DB instance during the
            /// maintenance window. The default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption or some interruptions.
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group to associate with the DB instance. If you update this value, the new subnet group
            /// must be a subnet group in a new VPC.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DBInstanceIdentifier
            /// A name for the DB instance. If you specify a name, AWS CloudFormation converts it to lowercase. If
            /// you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the
            /// DB instance. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceIdentifier { get; set; }

            /// <summary>
            /// DBSnapshotIdentifier
            /// The name or Amazon Resource Name (ARN) of the DB snapshot that's used to restore the DB instance. If
            /// you're restoring from a shared manual DB snapshot, you must specify the ARN of the snapshot.
            /// By specifying this property, you can create a DB instance from the specified DB snapshot. If the
            /// DBSnapshotIdentifier property is an empty string or the AWS::Neptune::DBInstance declaration has no
            /// DBSnapshotIdentifier property, AWS CloudFormation creates a new database. If the property contains a
            /// value (other than an empty string), AWS CloudFormation creates a database from the specified
            /// snapshot. If a snapshot with the specified name doesn't exist, AWS CloudFormation can't create the
            /// database and it rolls back the stack.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSnapshotIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this DB instance.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Neptune::DBInstance";
        
        public DBInstanceProperties Properties { get; } = new DBInstanceProperties();
    }

	public static class DBInstanceAttributes
	{
        public static readonly ResourceAttribute<string> Endpoint = new ResourceAttribute<string>("Endpoint");
        public static readonly ResourceAttribute<string> Port = new ResourceAttribute<string>("Port");
	}
}
