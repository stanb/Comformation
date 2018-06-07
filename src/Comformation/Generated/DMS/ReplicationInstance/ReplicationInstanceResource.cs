using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.ReplicationInstance
{
    /// <summary>
    /// AWS::DMS::ReplicationInstance
    /// The AWS::DMS::ReplicationInstance resource creates an AWS DMS replication instance.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html
    /// </summary>
    public class ReplicationInstanceResource : ResourceBase
    {
        public class ReplicationInstanceProperties
        {
            /// <summary>
            /// ReplicationInstanceIdentifier
            /// A name for the replication instance. If you specify a name, AWS CloudFormation converts it to lower
            /// case. If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that
            /// ID for the replication instance identifier. For more information, see Name Type.
            /// Constraints:
            /// Must contain from 1 to 63 alphanumeric characters or hyphens. First character must be a letter.
            /// Cannot end with a hyphen or contain two consecutive hyphens.
            /// Example: myrepinstance
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-replicationinstanceidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationInstanceIdentifier { get; set; }

            /// <summary>
            /// EngineVersion
            /// The engine version number of the replication instance.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-engineversion
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The KMS key identifier that will be used to encrypt the content on the replication instance. If you
            /// do not specify a value for the KmsKeyId parameter, then AWS DMS will use your default encryption
            /// key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a
            /// different default encryption key for each AWS region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-kmskeyid
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The EC2 Availability Zone that the replication instance will be created in. The default value is a
            /// random, system-chosen Availability Zone in the endpoint's region.
            /// Example: us-east-1d
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-availabilityzone
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// Default: A 30-minute window selected at random from an 8-hour block of time per region, occurring on
            /// a random day of the week.
            /// Valid Values: Mon, Tue, Wed, Thu, Fri, Sat, Sun
            /// Constraints: Minimum 30-minute window
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-preferredmaintenancewindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor engine upgrades will be applied automatically to the replication instance
            /// during the maintenance window.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-autominorversionupgrade
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// ReplicationSubnetGroupIdentifier
            /// A subnet group to associate with the replication instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-replicationsubnetgroupidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSubnetGroupIdentifier { get; set; }

            /// <summary>
            /// AllocatedStorage
            /// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-allocatedstorage
            /// </summary>
			public Union<int, IntrinsicFunction> AllocatedStorage { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// Specifies the VPC security group to be used with the replication instance. The VPC security group
            /// must work with the VPC containing the replication instance.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-vpcsecuritygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-allowmajorversionupgrade
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// ReplicationInstanceClass
            /// The compute and memory capacity of the replication instance as specified by the replication instance
            /// class.
            /// Valid Values: dms. t2. micro, dms. t2. small, dms. t2. medium , dms. t2. large, dms. c4. large, dms.
            /// c4. xlarge, dms. c4. 2xlarge, dms. c4. 4xlarge
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-replicationinstanceclass
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationInstanceClass { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// Specifies the accessibility options for the replication instance. A value of true represents an
            /// instance with a public IP address. A value of false represents an instance with a private IP
            /// address. The default value is true .
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-publiclyaccessible
            /// </summary>
			public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

            /// <summary>
            /// MultiAZ
            /// Specifies if the replication instance is a Multi-AZ deployment. You cannot set the AvailabilityZone
            /// parameter if the MultiAZ parameter is set to true .
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-multiaz
            /// </summary>
			public Union<bool, IntrinsicFunction> MultiAZ { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the DMS endpoint.
            /// Required: No
            /// Type: List of resource tags in key-value format
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationinstance.html#cfn-dms-replicationinstance-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::DMS::ReplicationInstance";
        
        public ReplicationInstanceProperties Properties { get; } = new ReplicationInstanceProperties();
    }

	public static class ReplicationInstanceAttributes
	{
        public static readonly ResourceAttribute<List<string>> ReplicationInstancePublicIpAddresses = new ResourceAttribute<List<string>>("ReplicationInstancePublicIpAddresses");
        public static readonly ResourceAttribute<List<string>> ReplicationInstancePrivateIpAddresses = new ResourceAttribute<List<string>>("ReplicationInstancePrivateIpAddresses");
	}
}
