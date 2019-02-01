using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DocDB.DBInstance
{
    /// <summary>
    /// AWS::DocDB::DBInstance
    /// The AWS::DocDB::DBInstance Amazon DocumentDB (with MongoDB compatibility) resource describes a DBInstance. For
    /// more information, see DBInstance in the Amazon DocumentDB Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbinstance.html
    /// </summary>
    public class DBInstanceResource : ResourceBase
    {
        public class DBInstanceProperties
        {
            /// <summary>
            /// DBInstanceClass
            /// Contains the name of the compute and memory capacity class of the DB instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceClass { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// Specifies the DB cluster this DB instance is a member of.
            /// Required: Yes
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
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// DBInstanceIdentifier
            /// The unique identifier for this DB instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// A list of up to 50 tags. A tag is metadata assigned to an Amazon DocumentDB (with MongoDB
            /// compatibility) resource consisting of a key-value pair.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DocDB::DBInstance";

        public DBInstanceProperties Properties { get; } = new DBInstanceProperties();

    }

	public static class DBInstanceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Port");
	}
}
