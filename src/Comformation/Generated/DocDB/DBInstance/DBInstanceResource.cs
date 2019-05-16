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
            /// The compute and memory capacity of the DB instance; for example, db. m4. large. If you change the
            /// class of an instance there can be some interruption in the cluster&#39;s service.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceClass { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The identifier of the DB cluster that the instance will belong to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Amazon EC2 Availability Zone that the DB instance is created in.
            /// Default: A random, system-chosen Availability Zone in the endpoint&#39;s AWS Region.
            /// Example: us-east-1d
            /// Constraint: The AvailabilityZone parameter can&#39;t be specified if the MultiAZ parameter is set to
            /// true. The specified Availability Zone must be in the same AWS Region as the current endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The time range each week during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region, occurring on a random day of the week.
            /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor engine upgrades are applied automatically to the DB instance during the
            /// maintenance window.
            /// Default: true
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// DBInstanceIdentifier
            /// The DB instance identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain from 1 to 63 letters, numbers, or hyphens. The first character must be a letter. Cannot
            /// end with a hyphen or contain two consecutive hyphens.
            /// Example: mydbinstance
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceIdentifier { get; set; }

            /// <summary>
            /// Tags
            /// The tags to be assigned to the DB instance.
            /// Required: No
            /// Type: List of Tag
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
