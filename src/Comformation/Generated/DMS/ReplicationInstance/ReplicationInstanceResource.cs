using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.ReplicationInstance
{
    /// <summary>
    /// AWS::DMS::ReplicationInstance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html
    /// </summary>
    public class ReplicationInstanceResource : ResourceBase
    {
        public class ReplicationInstanceProperties
        {
            /// <summary>
            /// ReplicationInstanceIdentifier
            /// The replication instance identifier. This parameter is stored as a lowercase string.
            /// Constraints:
            /// Must contain 1-63 alphanumeric characters or hyphens. First character must be a letter. Can&#39;t end
            /// with a hyphen or contain two consecutive hyphens.
            /// Example: myrepinstance
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ReplicationInstanceIdentifier { get; set; }

            /// <summary>
            /// EngineVersion
            /// The engine version number of the replication instance.
            /// If an engine version number is not specified when a replication instance is created, the default is
            /// the latest engine version available.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// KmsKeyId
            /// An AWS KMS key identifier that is used to encrypt the data on the replication instance.
            /// If you don&#39;t specify a value for the KmsKeyId parameter, then AWS DMS uses your default encryption
            /// key.
            /// AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different
            /// default encryption key for each AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone that the replication instance will be created in.
            /// The default value is a random, system-chosen Availability Zone in the endpoint&#39;s AWS Region, for
            /// example: us-east-1d
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// Default: A 30-minute window selected at random from an 8-hour block of time per AWS Region,
            /// occurring on a random day of the week.
            /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// A value that indicates whether minor engine upgrades are applied automatically to the replication
            /// instance during the maintenance window. This parameter defaults to true.
            /// Default: true
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// ReplicationSubnetGroupIdentifier
            /// A subnet group to associate with the replication instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReplicationSubnetGroupIdentifier { get; set; }

            /// <summary>
            /// AllocatedStorage
            /// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AllocatedStorage { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// Specifies the VPC security group to be used with the replication instance. The VPC security group
            /// must work with the VPC containing the replication instance.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// AllowMajorVersionUpgrade
            /// Indicates that major version upgrades are allowed. Changing this parameter does not result in an
            /// outage, and the change is asynchronously applied as soon as possible.
            /// This parameter must be set to true when specifying a value for the EngineVersion parameter that is a
            /// different major version than the replication instance&#39;s current version.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// ReplicationInstanceClass
            /// The compute and memory capacity of the replication instance as defined for the specified replication
            /// instance class. For example to specify the instance class dms. c4. large, set this parameter to
            /// &quot;dms. c4. large&quot;.
            /// For more information on the settings and capacities for the available replication instance classes,
            /// see Selecting the right AWS DMS replication instance for your migration.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ReplicationInstanceClass { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// Specifies the accessibility options for the replication instance. A value of true represents an
            /// instance with a public IP address. A value of false represents an instance with a private IP
            /// address. The default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

            /// <summary>
            /// MultiAZ
            /// Specifies whether the replication instance is a Multi-AZ deployment. You can&#39;t set the
            /// AvailabilityZone parameter if the Multi-AZ parameter is set to true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> MultiAZ { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags to be assigned to the replication instance.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DMS::ReplicationInstance";

        public ReplicationInstanceProperties Properties { get; } = new ReplicationInstanceProperties();

    }

    public static class ReplicationInstanceAttributes
    {
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> ReplicationInstancePublicIpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("ReplicationInstancePublicIpAddresses");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> ReplicationInstancePrivateIpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("ReplicationInstancePrivateIpAddresses");
    }
}
