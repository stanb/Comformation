using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBInstance
{
    /// <summary>
    /// AWS::RDS::DBInstance
    /// The AWS::RDS::DBInstance type creates an Amazon Relational Database Service (Amazon RDS) DB instance. For
    /// detailed information about configuring RDS DB instances, see CreateDBInstance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html
    /// </summary>
    public class DBInstanceResource : ResourceBase
    {
        public class DBInstanceProperties
        {
            /// <summary>
            /// AllocatedStorage
            /// The allocated storage size, specified in gigabytes (GB).
            /// If any value is set in the Iops parameter, AllocatedStorage must be at least 100 GB, which
            /// corresponds to the minimum Iops value of 1,000. If you increase the Iops value (in 1,000 IOPS
            /// increments), then you must also increase the AllocatedStorage value (in 100-GB increments).
            /// Required: Conditional. This property is required except when you specify the DBClusterIdentifier
            /// property or when you create a read replica from AWS CloudFormation by using the AWS::RDS::DBInstance
            /// resource. In these cases, don&#39;t specify this property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AllocatedStorage { get; set; }

            /// <summary>
            /// AllowMajorVersionUpgrade
            /// If you update the EngineVersion property to a version that&#39;s different from the DB instance&#39;s
            /// current major version, set this property to true. For more information, see ModifyDBInstance in the
            /// Amazon RDS API Reference.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Indicates that minor engine upgrades are applied automatically to the DB instance during the
            /// maintenance window. The default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon RDS API Reference.
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The name of the Availability Zone where the DB instance is located. You can&#39;t set the
            /// AvailabilityZone parameter if the MultiAZ parameter is set to true.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days during which automatic DB snapshots are retained.
            /// Important If this DB instance is deleted or replaced during an update, AWS CloudFormation deletes
            /// all automated snapshots. However, it retains manual DB snapshots.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon RDS API Reference.
            /// </summary>
			public Union<string, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// CharacterSetName
            /// For supported engines, specifies the character set to associate with the DB instance. For more
            /// information, see Appendix: Oracle Character Sets Supported in Amazon RDS in the Amazon RDS User
            /// Guide.
            /// If you specify the DBSnapshotIdentifier or SourceDBInstanceIdentifier property, don&#39;t specify this
            /// property. The value is inherited from the snapshot or source DB instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CharacterSetName { get; set; }

            /// <summary>
            /// CopyTagsToSnapshot
            /// Indicates whether to copy all of the user-defined tags from the DB instance to snapshots of the DB
            /// instance. By default, Amazon RDS doesn&#39;t copy tags to snapshots. Amazon RDS doesn&#39;t copy tags with
            /// the aws:: prefix unless it&#39;s the DB instance&#39;s final snapshot (the snapshot when you delete the DB
            /// instance).
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> CopyTagsToSnapshot { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The name of an existing DB cluster that this instance is associated with. If you specify this
            /// property, specify aurora for the Engine property and don&#39;t specify any of the following properties:
            /// AllocatedStorage, BackupRetentionPeriod, CharacterSetName, DBName, DBSecurityGroups, MasterUsername,
            /// MasterUserPassword, OptionGroupName, PreferredBackupWindow, PreferredMaintenanceWindow, Port,
            /// SourceDBInstanceIdentifier, StorageType, or VPCSecurityGroups.
            /// Amazon RDS assigns the first DB instance in the cluster as the primary, and additional DB instances
            /// as replicas.
            /// If you specify this property, the default deletion policy is Delete. Otherwise, the default deletion
            /// policy is Snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// DBInstanceClass
            /// The name of the compute and memory capacity classes of the DB instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> DBInstanceClass { get; set; }

            /// <summary>
            /// DBInstanceIdentifier
            /// A name for the DB instance. If you specify a name, AWS CloudFormation converts it to lowercase. If
            /// you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the
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
            /// DBName
            /// The name of the DB instance that was provided at the time of creation, if one was specified. This
            /// same name is returned for the life of the DB instance.
            /// Important If you specify the DBSnapshotIdentifier property, AWS CloudFormation ignores this
            /// property. If you restore DB instances from snapshots, this property doesn&#39;t apply to the MySQL,
            /// PostgreSQL, or MariaDB engines.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBName { get; set; }

            /// <summary>
            /// DBParameterGroupName
            /// The name of an existing DB parameter group or a reference to an AWS::RDS::DBParameterGroup resource
            /// created in the template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. If any of the data members of the referenced
            /// parameter group are changed during an update, the DB instance might need to be restarted, which
            /// causes some interruption. If the parameter group contains static parameters, whether they were
            /// changed or not, an update triggers a reboot.
            /// </summary>
			public Union<string, IntrinsicFunction> DBParameterGroupName { get; set; }

            /// <summary>
            /// DBSecurityGroups
            /// A list of the DB security groups to assign to the DB instance. The list can include both the name of
            /// existing DB security groups or references to AWS::RDS::DBSecurityGroup resources created in the
            /// template.
            /// If you set DBSecurityGroups, you must not set VPCSecurityGroups, and vice versa. Also, note that the
            /// EC2VpcId property exists only for backwards compatibility with older regions and is no longer
            /// recommended for providing security information to an RDS DB instance. Instead, use
            /// VPCSecurityGroups.
            /// Important If you specify this property, AWS CloudFormation sends only the following properties (if
            /// specified) to Amazon RDS during create operations: AllocatedStorage AutoMinorVersionUpgrade
            /// AvailabilityZone BackupRetentionPeriod CharacterSetName DBInstanceClass DBName DBParameterGroupName
            /// DBSecurityGroups DBSubnetGroupName Engine EngineVersion Iops LicenseModel MasterUsername
            /// MasterUserPassword MultiAZ OptionGroupName PreferredBackupWindow PreferredMaintenanceWindow If you
            /// specify this property, AWS CloudFormation sends only the following properties (if specified) to
            /// Amazon RDS during updates: AllocatedStorage AutoMinorVersionUpgrade AllowMajorVersionUpgrade
            /// BackupRetentionPeriod DBInstanceClass DBParameterGroupName DBSecurityGroups DBInstanceIdentifier
            /// EngineVersion Iops MasterUserPassword MultiAZ OptionGroupName PreferredBackupWindow
            /// PreferredMaintenanceWindow All other properties are ignored. Specify a virtual private cloud (VPC)
            /// security group if you want to submit other properties, such as StorageType, StorageEncrypted, or
            /// KmsKeyId. If you&#39;re already using the DBSecurityGroups property, you can&#39;t use these other
            /// properties by updating your DB instance to use a VPC security group. You must recreate the DB
            /// instance.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> DBSecurityGroups { get; set; }

            /// <summary>
            /// DBSnapshotIdentifier
            /// The name or Amazon Resource Name (ARN) of the DB snapshot that&#39;s used to restore the DB instance. If
            /// you&#39;re restoring from a shared manual DB snapshot, you must specify the ARN of the snapshot.
            /// By specifying this property, you can create a DB instance from the specified DB snapshot. If the
            /// DBSnapshotIdentifier property is an empty string or the AWS::RDS::DBInstance declaration has no
            /// DBSnapshotIdentifier property, AWS CloudFormation creates a new database. If the property contains a
            /// value (other than an empty string), AWS CloudFormation creates a database from the specified
            /// snapshot. If a snapshot with the specified name doesn&#39;t exist, AWS CloudFormation can&#39;t create the
            /// database and it rolls back the stack.
            /// Some DB instance properties aren&#39;t valid when you restore from a snapshot, such as the
            /// MasterUsername and MasterUserPassword properties. For information about the properties that you can
            /// specify, see the RestoreDBInstanceFromDBSnapshot action in the Amazon RDS API Reference.
            /// Important If you specify this property, AWS CloudFormation ignores the DBName property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSnapshotIdentifier { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group to associate with the DB instance. If you update this value, the new subnet group
            /// must be a subnet group in a new VPC.
            /// If there&#39;s no DB subnet group, then the instance isn&#39;t a VPC DB instance.
            /// For more information about using Amazon RDS in a VPC, see Using Amazon RDS with Amazon Virtual
            /// Private Cloud (VPC) in the Amazon Relational Database Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DeleteAutomatedBackups
            /// Indicates whether automated backups should be deleted (true) or retained (false) when you delete a
            /// DB instance. The default is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DeleteAutomatedBackups { get; set; }

            /// <summary>
            /// DeletionProtection
            /// Indicates whether the DB instance should have deletion protection enabled. The database can&#39;t be
            /// deleted when this value is set to true. If you want to delete a stack with a protected instance,
            /// update this value to false before you delete the stack.
            /// For more information, see Deleting a DB Instance.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// Domain
            /// For an Amazon RDS DB instance that&#39;s running Microsoft SQL Server, the Active Directory directory ID
            /// to create the instance in. Amazon RDS uses Windows Authentication to authenticate users that connect
            /// to the DB instance. For more information, see Using Windows Authentication with an Amazon RDS DB
            /// Instance Running Microsoft SQL Server in the Amazon RDS User Guide.
            /// If you specify this property, you must specify a SQL Server engine for the Engine property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// DomainIAMRoleName
            /// The name of an IAM role that Amazon RDS uses when calling the AWS Directory Service APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DomainIAMRoleName { get; set; }

            /// <summary>
            /// EnableCloudwatchLogsExports
            /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The values in the
            /// list depend on the DB engine being used. Log types that are excluded or removed from this list
            /// during updates are disabled. For more information, see Publishing Database Logs to Amazon CloudWatch
            /// Logs in the Amazon Relational Database Service User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> EnableCloudwatchLogsExports { get; set; }

            /// <summary>
            /// EnableIAMDatabaseAuthentication
            /// If set to true, enables mapping of AWS Identity and Access Management (IAM) accounts to database
            /// accounts.
            /// You can enable IAM database authentication for the following database engines:
            /// Amazon Aurora
            /// Not applicable. Mapping IAM accounts to database accounts is managed by the DB cluster. For more
            /// information, see CreateDBCluster.
            /// MySQL
            /// For MySQL 5. 6, minor version 5. 6. 34 or higher For MySQL 5. 7, minor version 5. 7. 16 or higher
            /// Default: false
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableIAMDatabaseAuthentication { get; set; }

            /// <summary>
            /// EnablePerformanceInsights
            /// If set to true, enables Performance Insights for the DB instance.
            /// For more information, see Using Amazon Performance Insights in the Amazon Relational Database
            /// Service User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnablePerformanceInsights { get; set; }

            /// <summary>
            /// Engine
            /// The database engine that the DB instance uses. This property is optional when you specify the
            /// DBSnapshotIdentifier property to create DB instances.
            /// For valid values, see the Engine parameter of the CreateDBInstance action in the Amazon RDS API
            /// Reference.
            /// If you specify aurora as the database engine, you must also specify the DBClusterIdentifier
            /// property.
            /// Note If you&#39;ve specified oracle-se or oracle-se1 as the database engine, you can update the database
            /// engine to oracle-se2 without the database instance being replaced. For information on the
            /// deprecation of support for Oracle version 12. 1. 0. 1, see Deprecation of Oracle 12. 1. 0. 1 in the
            /// Amazon Relational Database Service User Guide.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine that the DB instance uses.
            /// Note To prevent automatic upgrades, be sure to specify the full version number (for example, 5. 6.
            /// 13). If the default version for the database engine changes and you specify only the major version
            /// (for example, 5. 6), your DB instance will be upgraded to use the new default version. Note that the
            /// default version is not necessarily the latest supported version.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// Iops
            /// The number of I/O operations per second (IOPS) that the database provisions. The value must be equal
            /// to or greater than 1000.
            /// If you specify this property, you must follow the range of allowed ratios of your requested IOPS
            /// rate to the amount of storage that you allocate (IOPS to allocated storage). For example, you can
            /// provision an Oracle database instance with 1000 IOPS and 200 GB of storage (a ratio of 5:1), or
            /// specify 2000 IOPS with 200 GB of storage (a ratio of 10:1). For more information, see Amazon RDS
            /// Provisioned IOPS Storage to Improve Performance in the Amazon RDS User Guide.
            /// Required: Conditional. If you specify io1 for the StorageType property, you must specify this
            /// property.
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Iops { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The ARN of the AWS Key Management Service (AWS KMS) master key that&#39;s used to encrypt the DB
            /// instance, such as arn:aws:kms:us-east-1:012345678910:key/abcd1234-a123-456a-a12b-a123b4cd56ef. If
            /// you enable the StorageEncrypted property but don&#39;t specify this property, AWS CloudFormation uses
            /// the default master key. If you specify this property, you must set the StorageEncrypted property to
            /// true.
            /// If you specify the SourceDBInstanceIdentifier property, the value is inherited from the source DB
            /// instance if the read replica is created in the same region. If you specify this property when you
            /// create a read replica from an unencrypted DB instance, the read replica is encrypted.
            /// If you create an encrypted read replica in a different AWS Region, then you must specify a KMS key
            /// for the destination AWS Region. KMS encryption keys are specific to the region that they&#39;re created
            /// in, and you can&#39;t use encryption keys from one region in another region.
            /// If you specify DBSecurityGroups, AWS CloudFormation ignores this property. To specify both a
            /// security group and this property, you must use a VPC security group. For more information about
            /// Amazon RDS and VPC, see Using Amazon RDS with Amazon VPC in the Amazon RDS User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// LicenseModel
            /// The license model of the DB instance.
            /// Note If you&#39;ve specified DBSecurityGroups and then you update the license model, AWS CloudFormation
            /// replaces the underlying EC2 host. This will incur some interruptions to database availability.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> LicenseModel { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The master password for the DB instance.
            /// Note If you specify the SourceDBInstanceIdentifier or DBSnapshotIdentifier property, don&#39;t specify
            /// this property. The value is inherited from the source DB instance or snapshot.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The master user name for the DB instance.
            /// Note If you specify the SourceDBInstanceIdentifier or DBSnapshotIdentifier property, don&#39;t specify
            /// this property. The value is inherited from the source DB instance or snapshot.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// MonitoringInterval
            /// The interval, in seconds, between points when Amazon RDS collects enhanced monitoring metrics for
            /// the DB instance. To disable metrics collection, specify 0.
            /// For default and valid values, see the MonitoringInterval parameter for the CreateDBInstance action
            /// in the Amazon RDS API Reference.
            /// Required: Conditional. If you specify the MonitoringRoleArn property, specify a value other than 0
            /// for MonitoringInterval.
            /// Type: Integer
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon RDS API Reference.
            /// </summary>
			public Union<int, IntrinsicFunction> MonitoringInterval { get; set; }

            /// <summary>
            /// MonitoringRoleArn
            /// The ARN of the AWS Identity and Access Management (IAM) role that permits Amazon RDS to send
            /// enhanced monitoring metrics to Amazon CloudWatch, for example,
            /// arn:aws:iam::123456789012:role/emaccess. For information on creating a monitoring role, see To
            /// create an IAM role for Amazon RDS Enhanced Monitoring in the Amazon RDS User Guide.
            /// Required: Conditional. If you specify a value other than 0 for the MonitoringInterval property,
            /// specify a value for MonitoringRoleArn.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MonitoringRoleArn { get; set; }

            /// <summary>
            /// MultiAZ
            /// Specifies if the database instance is a multiple Availability Zone deployment. You can&#39;t set the
            /// AvailabilityZone parameter if the MultiAZ parameter is set to true. Amazon Aurora storage is
            /// replicated across all the Availability Zones and doesn&#39;t require the MultiAZ option to be set.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> MultiAZ { get; set; }

            /// <summary>
            /// OptionGroupName
            /// The option group that this DB instance is associated with.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> OptionGroupName { get; set; }

            /// <summary>
            /// PerformanceInsightsKMSKeyId
            /// The AWS KMS key identifier for encryption of Performance Insights data. The AWS KMS key ID is the
            /// Amazon Resource Name (ARN), AWS KMS key identifier, or the AWS KMS key alias for the AWS KMS
            /// encryption key.
            /// If EnablePerformanceInsights is set to false, don&#39;t specify this property.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions. When you set EnablePerformanceInsights to true, the first time
            /// you specify PerformanceInsightsKMSKeyId requires no interruption. If you update the value for
            /// PerformanceInsightsKMSKeyId with Performance Insights enabled, replacement occurs.
            /// </summary>
			public Union<string, IntrinsicFunction> PerformanceInsightsKMSKeyId { get; set; }

            /// <summary>
            /// PerformanceInsightsRetentionPeriod
            /// The amount of time, in days, to retain Performance Insights data. Valid values are 7 or 731 (2
            /// years).
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> PerformanceInsightsRetentionPeriod { get; set; }

            /// <summary>
            /// Port
            /// The port for the instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The daily time range during which automated backups are performed if automated backups are enabled,
            /// as determined by the BackupRetentionPeriod property. For valid values, see the PreferredBackupWindow
            /// parameter for the CreateDBInstance action in the Amazon RDS API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range (in UTC) during which system maintenance can occur. For valid values, see the
            /// PreferredMaintenanceWindow parameter for the CreateDBInstance action in the Amazon RDS API
            /// Reference.
            /// Note This property applies when AWS CloudFormation initially creates the DB instance. If you use AWS
            /// CloudFormation to update the DB instance, those updates are applied immediately.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption or some interruptions. For more information, see ModifyDBInstance
            /// in the Amazon RDS API Reference.
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// ProcessorFeatures
            /// The number of CPU cores and the number of threads per core for the DB instance class of the DB
            /// instance.
            /// Required: No
            /// Type: List of ProcessorFeature property types
            /// Update requires: No interruption
            /// </summary>
			public List<ProcessorFeature> ProcessorFeatures { get; set; }

            /// <summary>
            /// PromotionTier
            /// A value that specifies the order in which an Aurora Replica is promoted to the primary instance
            /// after a failure of the existing primary instance. For more information, see Fault Tolerance for an
            /// Aurora DB Cluster in the Amazon Aurora User Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> PromotionTier { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// Indicates whether the DB instance is an internet-facing instance. If you specify true, AWS
            /// CloudFormation creates an instance with a publicly resolvable DNS name, which resolves to a public
            /// IP address. If you specify false, AWS CloudFormation creates an internal instance with a DNS name
            /// that resolves to a private IP address.
            /// The default behavior value depends on your VPC setup and the database subnet group. For more
            /// information, see the PubliclyAccessible parameter in CreateDBInstance in the Amazon RDS API
            /// Reference.
            /// If this resource has a public IP address and is also in a VPC that is defined in the same template,
            /// you must use the DependsOn attribute to declare a dependency on the VPC-gateway attachment. For more
            /// information, see DependsOn Attribute.
            /// Note If you specify DBSecurityGroups, AWS CloudFormation ignores this property. To specify a
            /// security group and this property, you must use a VPC security group. For more information about
            /// Amazon RDS and VPC, see Using Amazon RDS with Amazon VPC in the Amazon RDS User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

            /// <summary>
            /// SourceDBInstanceIdentifier
            /// If you want to create a read replica DB instance, specify the ID of the source DB instance. Each DB
            /// instance can have a limited number of read replicas. For more information, see Working with Read
            /// Replicas in the Amazon Relational Database Service Developer Guide.
            /// The SourceDBInstanceIdentifier property determines whether a DB instance is a read replica. If you
            /// remove the SourceDBInstanceIdentifier property from your template and then update your stack, AWS
            /// CloudFormation deletes the read replica and creates a new DB instance (not a read replica).
            /// Important If you specify a source DB instance that uses VPC security groups, we recommend that you
            /// specify the VPCSecurityGroups property. If you don&#39;t specify the property, the read replica inherits
            /// the value of the VPCSecurityGroups property from the source DB when you create the replica. However,
            /// if you update the stack, AWS CloudFormation reverts the replica&#39;s VPCSecurityGroups property to the
            /// default value because it&#39;s not defined in the stack&#39;s template. This change might cause unexpected
            /// issues. Read replicas don&#39;t support deletion policies. AWS CloudFormation ignores any deletion
            /// policy that&#39;s associated with a read replica. If you specify SourceDBInstanceIdentifier, don&#39;t set
            /// the MultiAZ property to true, and don&#39;t specify the DBSnapshotIdentifier property. You can&#39;t deploy
            /// read replicas in multiple Availability Zones, and you can&#39;t create a read replica from a snapshot.
            /// Don&#39;t set the BackupRetentionPeriod, DBName, MasterUsername, MasterUserPassword, and
            /// PreferredBackupWindow properties. The database attributes are inherited from the source DB instance,
            /// and backups are disabled for read replicas. If the source DB instance is in a different region than
            /// the read replica, specify an ARN for a valid DB instance. For more information, see Constructing a
            /// Amazon RDS Amazon Resource Name (ARN) in the Amazon RDS User Guide. For DB instances in Amazon
            /// Aurora clusters, don&#39;t specify this property. Amazon RDS automatically assigns writer and reader DB
            /// instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceDBInstanceIdentifier { get; set; }

            /// <summary>
            /// SourceRegion
            /// The ID of the region that contains the source DB instance for the read replica.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceRegion { get; set; }

            /// <summary>
            /// StorageEncrypted
            /// Indicates whether the DB instance is encrypted.
            /// If you specify the DBClusterIdentifier, DBSnapshotIdentifier, or SourceDBInstanceIdentifier
            /// property, don&#39;t specify this property. The value is inherited from the cluster, snapshot, or source
            /// DB instance.
            /// Required: Conditional. If you specify the KmsKeyId property, you must enable encryption.
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// StorageType
            /// The storage type associated with this DB instance.
            /// For the default and valid values, see the StorageType parameter of the CreateDBInstance action in
            /// the Amazon RDS API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> StorageType { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this DB instance.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timezone
            /// The time zone of the DB instance, which you can specify to match the time zone of your applications.
            /// To see which engines support time zones, see the Timezone parameter for the CreateDBInstance action
            /// in the Amazon RDS API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Timezone { get; set; }

            /// <summary>
            /// UseDefaultProcessorFeatures
            /// </summary>
			public Union<bool, IntrinsicFunction> UseDefaultProcessorFeatures { get; set; }

            /// <summary>
            /// VPCSecurityGroups
            /// A list of the VPC security group IDs to assign to the DB instance. The list can include both the
            /// physical IDs of existing VPC security groups and references to AWS::EC2::SecurityGroup resources
            /// created in the template.
            /// If you set VPCSecurityGroups, you must not set DBSecurityGroups, and vice versa.
            /// Important You can migrate a DB instance in your stack from an RDS DB security group to a VPC
            /// security group, but keep the following in mind: You can&#39;t revert to using an RDS security group
            /// after you establish a VPC security group membership. When you migrate your DB instance to VPC
            /// security groups, if your stack update rolls back because the DB instance update fails or because an
            /// update fails in another AWS CloudFormation resource, the rollback fails because it can&#39;t revert to
            /// an RDS security group. To use the properties that are available when you use a VPC security group,
            /// you must recreate the DB instance. If you don&#39;t, AWS CloudFormation submits only the property values
            /// that are listed in the DBSecurityGroups property. To avoid this situation, migrate your DB instance
            /// to using VPC security groups only when that is the only change in your stack template.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VPCSecurityGroups { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBInstance";

        public DBInstanceProperties Properties { get; } = new DBInstanceProperties();

    }

	public static class DBInstanceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Address = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Address");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint_Port = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint", "Port");
	}
}
