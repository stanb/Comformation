using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBInstance
{
    /// <summary>
    /// AWS::RDS::DBInstance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html
    /// </summary>
    public class DBInstanceResource : ResourceBase
    {
        public class DBInstanceProperties
        {
            /// <summary>
            /// AllocatedStorage
            /// The amount of storage (in gigabytes) to be initially allocated for the database instance.
            /// Note If any value is set in the Iops parameter, AllocatedStorage must be at least 100 GiB, which
            /// corresponds to the minimum Iops value of 1,000. If you increase the Iops value (in 1,000 IOPS
            /// increments), then you must also increase the AllocatedStorage value (in 100-GiB increments).
            /// Amazon Aurora
            /// Not applicable. Aurora cluster volumes automatically grow as the amount of data in your database
            /// increases, though you are only charged for the space that you use in an Aurora cluster volume.
            /// MySQL
            /// Constraints to the amount of storage for each storage type are the following:
            /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. Provisioned IOPS storage
            /// (io1): Must be an integer from 100 to 65536. Magnetic storage (standard): Must be an integer from 5
            /// to 3072.
            /// MariaDB
            /// Constraints to the amount of storage for each storage type are the following:
            /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. Provisioned IOPS storage
            /// (io1): Must be an integer from 100 to 65536. Magnetic storage (standard): Must be an integer from 5
            /// to 3072.
            /// PostgreSQL
            /// Constraints to the amount of storage for each storage type are the following:
            /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. Provisioned IOPS storage
            /// (io1): Must be an integer from 100 to 65536. Magnetic storage (standard): Must be an integer from 5
            /// to 3072.
            /// Oracle
            /// Constraints to the amount of storage for each storage type are the following:
            /// General Purpose (SSD) storage (gp2): Must be an integer from 20 to 65536. Provisioned IOPS storage
            /// (io1): Must be an integer from 100 to 65536. Magnetic storage (standard): Must be an integer from 10
            /// to 3072.
            /// SQL Server
            /// Constraints to the amount of storage for each storage type are the following:
            /// General Purpose (SSD) storage (gp2): Enterprise and Standard editions: Must be an integer from 200
            /// to 16384. Web and Express editions: Must be an integer from 20 to 16384. Provisioned IOPS storage
            /// (io1): Enterprise and Standard editions: Must be an integer from 200 to 16384. Web and Express
            /// editions: Must be an integer from 100 to 16384. Magnetic storage (standard): Enterprise and Standard
            /// editions: Must be an integer from 200 to 1024. Web and Express editions: Must be an integer from 20
            /// to 1024.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AllocatedStorage { get; set; }

            /// <summary>
            /// AllowMajorVersionUpgrade
            /// A value that indicates whether major version upgrades are allowed. Changing this parameter doesn&#39;t
            /// result in an outage and the change is asynchronously applied as soon as possible.
            /// Constraints: Major version upgrades must be allowed when specifying a value for the EngineVersion
            /// parameter that is a different major version than the DB instance&#39;s current version.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowMajorVersionUpgrade { get; set; }

            /// <summary>
            /// AssociatedRoles
            /// The AWS Identity and Access Management (IAM) roles associated with the DB instance.
            /// Required: No
            /// Type: List of DBInstanceRole
            /// Update requires: No interruption
            /// </summary>
            public List<DBInstanceRole> AssociatedRoles { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// A value that indicates whether minor engine upgrades are applied automatically to the DB instance
            /// during the maintenance window. By default, minor engine upgrades are applied automatically.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// The Availability Zone (AZ) where the database will be created. For information on AWS Regions and
            /// Availability Zones, see Regions and Availability Zones.
            /// Default: A random, system-chosen Availability Zone in the endpoint&#39;s AWS Region.
            /// Example: us-east-1d
            /// Constraint: The AvailabilityZone parameter can&#39;t be specified if the DB instance is a Multi-AZ
            /// deployment. The specified Availability Zone must be in the same AWS Region as the current endpoint.
            /// Note If you&#39;re creating a DB instance in an RDS on VMware environment, specify the identifier of the
            /// custom Availability Zone to create the DB instance in. For more information about RDS on VMware, see
            /// the RDS on VMware User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// BackupRetentionPeriod
            /// The number of days for which automated backups are retained. Setting this parameter to a positive
            /// number enables backups. Setting this parameter to 0 disables automated backups.
            /// Amazon Aurora
            /// Not applicable. The retention period for automated backups is managed by the DB cluster.
            /// Default: 1
            /// Constraints:
            /// Must be a value from 0 to 35 Can&#39;t be set to 0 if the DB instance is a source to Read Replicas
            /// Required: No
            /// Type: Integer
            /// Update requires: Some interruptions
            /// </summary>
            public Union<int, IntrinsicFunction> BackupRetentionPeriod { get; set; }

            /// <summary>
            /// CACertificateIdentifier
            /// The identifier of the CA certificate for this DB instance.
            /// Note Specifying or updating this property triggers a reboot.
            /// For more information about CA certificate identifiers for RDS DB engines, see Rotating Your SSL/TLS
            /// Certificate in the Amazon RDS User Guide.
            /// For more information about CA certificate identifiers for Aurora DB engines, see Rotating Your
            /// SSL/TLS Certificate in the Amazon Aurora User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CACertificateIdentifier { get; set; }

            /// <summary>
            /// CharacterSetName
            /// For supported engines, indicates that the DB instance should be associated with the specified
            /// character set.
            /// Amazon Aurora
            /// Not applicable. The character set is managed by the DB cluster. For more information, see
            /// AWS::RDS::DBCluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CharacterSetName { get; set; }

            /// <summary>
            /// CopyTagsToSnapshot
            /// A value that indicates whether to copy tags from the DB instance to snapshots of the DB instance. By
            /// default, tags are not copied.
            /// Amazon Aurora
            /// Not applicable. Copying tags to snapshots is managed by the DB cluster. Setting this value for an
            /// Aurora DB instance has no effect on the DB cluster setting.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> CopyTagsToSnapshot { get; set; }

            /// <summary>
            /// DBClusterIdentifier
            /// The identifier of the DB cluster that the instance will belong to.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBClusterIdentifier { get; set; }

            /// <summary>
            /// DBInstanceClass
            /// The compute and memory capacity of the DB instance, for example, db. m4. large. Not all DB instance
            /// classes are available in all AWS Regions, or for all database engines.
            /// For the full list of DB instance classes, and availability for your engine, see DB Instance Class in
            /// the Amazon RDS User Guide. For more information about DB instance class pricing and AWS Region
            /// support for DB instance classes, see Amazon RDS Pricing.
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
            /// The meaning of this parameter differs according to the database engine you use.
            /// Important If you specify the DBSnapshotIdentifier property, AWS CloudFormation ignores this
            /// property. If you restore DB instances from snapshots, this property doesn&#39;t apply to the MySQL,
            /// PostgreSQL, or MariaDB engines.
            /// MySQL
            /// The name of the database to create when the DB instance is created. If this parameter is not
            /// specified, no database is created in the DB instance.
            /// Constraints:
            /// Must contain 1 to 64 letters or numbers. Can&#39;t be a word reserved by the specified database engine
            /// MariaDB
            /// The name of the database to create when the DB instance is created. If this parameter is not
            /// specified, no database is created in the DB instance.
            /// Constraints:
            /// Must contain 1 to 64 letters or numbers. Can&#39;t be a word reserved by the specified database engine
            /// PostgreSQL
            /// The name of the database to create when the DB instance is created. If this parameter is not
            /// specified, the default postgres database is created in the DB instance.
            /// Constraints:
            /// Must contain 1 to 63 letters, numbers, or underscores. Must begin with a letter or an underscore.
            /// Subsequent characters can be letters, underscores, or digits (0-9). Can&#39;t be a word reserved by the
            /// specified database engine
            /// Oracle
            /// The Oracle System ID (SID) of the created DB instance. If you specify null, the default value ORCL
            /// is used. You can&#39;t specify the string NULL, or any other reserved word, for DBName.
            /// Default: ORCL
            /// Constraints:
            /// Can&#39;t be longer than 8 characters
            /// SQL Server
            /// Not applicable. Must be null.
            /// Amazon Aurora MySQL
            /// The name of the database to create when the primary DB instance of the Aurora MySQL DB cluster is
            /// created. If this parameter isn&#39;t specified for an Aurora MySQL DB cluster, no database is created in
            /// the DB cluster.
            /// Constraints:
            /// It must contain 1 to 64 alphanumeric characters. It can&#39;t be a word reserved by the database engine.
            /// Amazon Aurora PostgreSQL
            /// The name of the database to create when the primary DB instance of the Aurora PostgreSQL DB cluster
            /// is created. If this parameter isn&#39;t specified for an Aurora PostgreSQL DB cluster, a database named
            /// postgres is created in the DB cluster.
            /// Constraints:
            /// It must contain 1 to 63 alphanumeric characters. It must begin with a letter or an underscore.
            /// Subsequent characters can be letters, underscores, or digits (0 to 9). It can&#39;t be a word reserved
            /// by the database engine.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBName { get; set; }

            /// <summary>
            /// DBParameterGroupName
            /// The name of an existing DB parameter group or a reference to an AWS::RDS::DBParameterGroup resource
            /// created in the template.
            /// To list all of the available DB parameter group names, use the following command:
            /// aws rds describe-db-parameter-groups --query &quot;DBParameterGroups[]. DBParameterGroupName&quot; --output
            /// text
            /// Note If any of the data members of the referenced parameter group are changed during an update, the
            /// DB instance might need to be restarted, which causes some interruption. If the parameter group
            /// contains static parameters, whether they were changed or not, an update triggers a reboot.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
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
            /// MasterUserPassword MultiAZ OptionGroupName PreferredBackupWindow PreferredMaintenanceWindow All
            /// other properties are ignored. Specify a virtual private cloud (VPC) security group if you want to
            /// submit other properties, such as StorageType, StorageEncrypted, or KmsKeyId. If you&#39;re already using
            /// the DBSecurityGroups property, you can&#39;t use these other properties by updating your DB instance to
            /// use a VPC security group. You must recreate the DB instance.
            /// Required: No
            /// Type: List of String
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
            /// After you restore a DB instance with a DBSnapshotIdentifier property, you must specify the same
            /// DBSnapshotIdentifier property for any future updates to the DB instance. When you specify this
            /// property for an update, the DB instance is not restored from the DB snapshot again, and the data in
            /// the database is not changed. However, if you don&#39;t specify the DBSnapshotIdentifier property, an
            /// empty DB instance is created, and the original DB instance is deleted. If you specify a property
            /// that is different from the previous snapshot restore property, a new DB instance is restored from
            /// the specified DBSnapshotIdentifier property, and the original DB instance is deleted.
            /// If you specify the DBSnapshotIdentifier property to restore a DB instance (as opposed to specifying
            /// it for DB instance updates), then don&#39;t specify the following properties:
            /// AllocatedStorage BackupRetentionPeriod CharacterSetName DBClusterIdentifier DBName DBSecurityGroups
            /// DeleteAutomatedBackups EnablePerformanceInsights EngineVersion KmsKeyId MasterUsername
            /// MasterUserPassword MaxAllocatedStorage MonitoringInterval MonitoringRoleArn
            /// PerformanceInsightsKMSKeyId PerformanceInsightsRetentionPeriod PreferredBackupWindow
            /// PreferredMaintenanceWindow PromotionTier SourceDBInstanceIdentifier SourceRegion StorageEncrypted
            /// Timezone
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBSnapshotIdentifier { get; set; }

            /// <summary>
            /// DBSubnetGroupName
            /// A DB subnet group to associate with the DB instance. If you update this value, the new subnet group
            /// must be a subnet group in a new VPC.
            /// If there&#39;s no DB subnet group, then the DB instance isn&#39;t a VPC DB instance.
            /// For more information about using Amazon RDS in a VPC, see Using Amazon RDS with Amazon Virtual
            /// Private Cloud (VPC) in the Amazon Relational Database Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DeleteAutomatedBackups
            /// 	
            /// A value that indicates whether to remove automated backups immediately after the DB instance is
            /// deleted. This parameter isn&#39;t case-sensitive. The default is to remove automated backups immediately
            /// after the DB instance is deleted.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeleteAutomatedBackups { get; set; }

            /// <summary>
            /// DeletionProtection
            /// A value that indicates whether the DB instance has deletion protection enabled. The database can&#39;t
            /// be deleted when deletion protection is enabled. By default, deletion protection is disabled. For
            /// more information, see Deleting a DB Instance.
            /// Amazon Aurora
            /// Not applicable. You can enable or disable deletion protection for the DB cluster. For more
            /// information, see CreateDBCluster. DB instances in a DB cluster can be deleted even when deletion
            /// protection is enabled for the DB cluster.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeletionProtection { get; set; }

            /// <summary>
            /// Domain
            /// The Active Directory directory ID to create the DB instance in. Currently, only MySQL, Microsoft SQL
            /// Server, Oracle, and PostgreSQL DB instances can be created in an Active Directory Domain.
            /// For more information, see Kerberos Authentication in the Amazon RDS User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Domain { get; set; }

            /// <summary>
            /// DomainIAMRoleName
            /// Specify the name of the IAM role to be used when making API calls to the Directory Service.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DomainIAMRoleName { get; set; }

            /// <summary>
            /// EnableCloudwatchLogsExports
            /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The values in the
            /// list depend on the DB engine being used. For more information, see Publishing Database Logs to
            /// Amazon CloudWatch Logs in the Amazon Relational Database Service User Guide.
            /// Amazon Aurora
            /// Not applicable. CloudWatch Logs exports are managed by the DB cluster.
            /// MariaDB
            /// Possible values are audit, error, general, and slowquery.
            /// Microsoft SQL Server
            /// Possible values are agent and error.
            /// MySQL
            /// Possible values are audit, error, general, and slowquery.
            /// Oracle
            /// Possible values are alert, audit, listener, and trace.
            /// PostgreSQL
            /// Possible values are postgresql and upgrade.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EnableCloudwatchLogsExports { get; set; }

            /// <summary>
            /// EnableIAMDatabaseAuthentication
            /// A value that indicates whether to enable mapping of AWS Identity and Access Management (IAM)
            /// accounts to database accounts. By default, mapping is disabled.
            /// This setting doesn&#39;t apply to Amazon Aurora. Mapping AWS IAM accounts to database accounts is
            /// managed by the DB cluster.
            /// For more information, see IAM Database Authentication for MySQL and PostgreSQL in the Amazon RDS
            /// User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableIAMDatabaseAuthentication { get; set; }

            /// <summary>
            /// EnablePerformanceInsights
            /// A value that indicates whether to enable Performance Insights for the DB instance.
            /// For more information, see Using Amazon Performance Insights in the Amazon Relational Database
            /// Service User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnablePerformanceInsights { get; set; }

            /// <summary>
            /// Engine
            /// The name of the database engine that you want to use for this DB instance.
            /// Note If you don&#39;t specify a value for the DBParameterGroupName property, the default
            /// DBParameterGroup for the specified engine is used.
            /// Valid Values:
            /// aurora (for MySQL 5. 6-compatible Aurora) aurora-mysql (for MySQL 5. 7-compatible Aurora)
            /// aurora-postgresql mariadb mysql oracle-ee oracle-se2 oracle-se1 oracle-se postgres sqlserver-ee
            /// sqlserver-se sqlserver-ex sqlserver-web
            /// Required: Conditional
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version number of the database engine to use.
            /// For a list of valid engine versions, use the DescribeDBEngineVersions action.
            /// The following are the database engines and links to information about the major and minor versions
            /// that are available with Amazon RDS. Not every database engine is available for every AWS Region.
            /// Amazon Aurora
            /// Not applicable. The version number of the database engine to be used by the DB instance is managed
            /// by the DB cluster.
            /// MariaDB
            /// See MariaDB on Amazon RDS Versions in the Amazon RDS User Guide.
            /// Microsoft SQL Server
            /// See Microsoft SQL Server Versions on Amazon RDS in the Amazon RDS User Guide.
            /// MySQL
            /// See MySQL on Amazon RDS Versions in the Amazon RDS User Guide.
            /// Oracle
            /// See Oracle Database Engine Release Notes in the Amazon RDS User Guide.
            /// PostgreSQL
            /// See Supported PostgreSQL Database Versions in the Amazon RDS User Guide.
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
            /// provision an Oracle database instance with 1000 IOPS and 200 GiB of storage (a ratio of 5:1), or
            /// specify 2000 IOPS with 200 GiB of storage (a ratio of 10:1). For more information, see Amazon RDS
            /// Provisioned IOPS Storage to Improve Performance in the Amazon RDS User Guide.
            /// Note If you specify io1 for the StorageType property, then you must also specify the Iops property.
            /// Required: No
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
            /// instance if the Read Replica is created in the same region.
            /// If you create an encrypted Read Replica in a different AWS Region, then you must specify a KMS key
            /// for the destination AWS Region. KMS encryption keys are specific to the region that they&#39;re created
            /// in, and you can&#39;t use encryption keys from one region in another region.
            /// If you specify DBSecurityGroups, AWS CloudFormation ignores this property. To specify both a
            /// security group and this property, you must use a VPC security group. For more information about
            /// Amazon RDS and VPC, see Using Amazon RDS with Amazon VPC in the Amazon RDS User Guide.
            /// Amazon Aurora
            /// Not applicable. The KMS key identifier is managed by the DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// LicenseModel
            /// License model information for this DB instance.
            /// Valid values: license-included | bring-your-own-license | general-public-license
            /// Note If you&#39;ve specified DBSecurityGroups and then you update the license model, AWS CloudFormation
            /// replaces the underlying DB instance. This will incur some interruptions to database availability.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LicenseModel { get; set; }

            /// <summary>
            /// MasterUserPassword
            /// The password for the master user. The password can include any printable ASCII character except &quot;/&quot;,
            /// &quot;&quot;&quot;, or &quot;@&quot;.
            /// Amazon Aurora
            /// Not applicable. The password for the master user is managed by the DB cluster.
            /// MariaDB
            /// Constraints: Must contain from 8 to 41 characters.
            /// Microsoft SQL Server
            /// Constraints: Must contain from 8 to 128 characters.
            /// MySQL
            /// Constraints: Must contain from 8 to 41 characters.
            /// Oracle
            /// Constraints: Must contain from 8 to 30 characters.
            /// PostgreSQL
            /// Constraints: Must contain from 8 to 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

            /// <summary>
            /// MasterUsername
            /// The master user name for the DB instance.
            /// Note If you specify the SourceDBInstanceIdentifier or DBSnapshotIdentifier property, don&#39;t specify
            /// this property. The value is inherited from the source DB instance or snapshot.
            /// Amazon Aurora
            /// Not applicable. The name for the master user is managed by the DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MasterUsername { get; set; }

            /// <summary>
            /// MaxAllocatedStorage
            /// The upper limit to which Amazon RDS can automatically scale the storage of the DB instance.
            /// For more information about this setting, including limitations that apply to it, see Managing
            /// capacity automatically with Amazon RDS storage autoscaling in the Amazon RDS User Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxAllocatedStorage { get; set; }

            /// <summary>
            /// MonitoringInterval
            /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected for the DB
            /// instance. To disable collecting Enhanced Monitoring metrics, specify 0. The default is 0.
            /// If MonitoringRoleArn is specified, then you must also set MonitoringInterval to a value other than
            /// 0.
            /// Valid Values: 0, 1, 5, 10, 15, 30, 60
            /// Required: No
            /// Type: Integer
            /// Update requires: Some interruptions
            /// </summary>
            public Union<int, IntrinsicFunction> MonitoringInterval { get; set; }

            /// <summary>
            /// MonitoringRoleArn
            /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to Amazon CloudWatch
            /// Logs. For example, arn:aws:iam:123456789012:role/emaccess. For information on creating a monitoring
            /// role, go to Setting Up and Enabling Enhanced Monitoring in the Amazon RDS User Guide.
            /// If MonitoringInterval is set to a value other than 0, then you must supply a MonitoringRoleArn
            /// value.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MonitoringRoleArn { get; set; }

            /// <summary>
            /// MultiAZ
            /// Specifies whether the database instance is a multiple Availability Zone deployment. You can&#39;t set
            /// the AvailabilityZone parameter if the MultiAZ parameter is set to true. Amazon Aurora storage is
            /// replicated across all the Availability Zones and doesn&#39;t require the MultiAZ option to be set.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Some interruptions
            /// </summary>
            public Union<bool, IntrinsicFunction> MultiAZ { get; set; }

            /// <summary>
            /// OptionGroupName
            /// Indicates that the DB instance should be associated with the specified option group.
            /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, can&#39;t be removed from an
            /// option group. Also, that option group can&#39;t be removed from a DB instance once it is associated with
            /// a DB instance.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> OptionGroupName { get; set; }

            /// <summary>
            /// PerformanceInsightsKMSKeyId
            /// The AWS KMS key identifier for encryption of Performance Insights data.
            /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the AWS KMS customer
            /// master key (CMK).
            /// If you do not specify a value for PerformanceInsightsKMSKeyId, then Amazon RDS uses your default
            /// CMK. There is a default CMK for your AWS account. Your AWS account has a different default CMK for
            /// each AWS Region.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
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
            /// The port number on which the database accepts connections.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The daily time range during which automated backups are created if automated backups are enabled,
            /// using the BackupRetentionPeriod parameter. For more information, see The Backup Window in the Amazon
            /// RDS User Guide.
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region. To see the time blocks available, see Adjusting the Preferred DB Instance Maintenance Window
            /// in the Amazon RDS User Guide.
            /// Constraints:
            /// Must be in the format hh24:mi-hh24:mi. Must be in Universal Coordinated Time (UTC). Must not
            /// conflict with the preferred maintenance window. Must be at least 30 minutes.
            /// Amazon Aurora
            /// Not applicable. The daily time range for creating automated backups is managed by the DB cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time
            /// (UTC).
            /// Format: ddd:hh24:mi-ddd:hh24:mi
            /// The default is a 30-minute window selected at random from an 8-hour block of time for each AWS
            /// Region, occurring on a random day of the week. To see the time blocks available, see Adjusting the
            /// Preferred DB Instance Maintenance Window in the Amazon RDS User Guide.
            /// Note This property applies when AWS CloudFormation initially creates the DB instance. If you use AWS
            /// CloudFormation to update the DB instance, those updates are applied immediately.
            /// Constraints: Minimum 30-minute window.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// ProcessorFeatures
            /// The number of CPU cores and the number of threads per core for the DB instance class of the DB
            /// instance.
            /// Required: No
            /// Type: List of ProcessorFeature
            /// Update requires: No interruption
            /// </summary>
            public List<ProcessorFeature> ProcessorFeatures { get; set; }

            /// <summary>
            /// PromotionTier
            /// A value that specifies the order in which an Aurora Replica is promoted to the primary instance
            /// after a failure of the existing primary instance. For more information, see Fault Tolerance for an
            /// Aurora DB Cluster in the Amazon Aurora User Guide.
            /// Default: 1
            /// Valid Values: 0 - 15
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
            /// If you want to create a Read Replica DB instance, specify the ID of the source DB instance. Each DB
            /// instance can have a limited number of Read Replicas. For more information, see Working with Read
            /// Replicas in the Amazon Relational Database Service Developer Guide.
            /// The SourceDBInstanceIdentifier property determines whether a DB instance is a Read Replica. If you
            /// remove the SourceDBInstanceIdentifier property from your template and then update your stack, AWS
            /// CloudFormation deletes the Read Replica and creates a new DB instance (not a Read Replica).
            /// Important If you specify a source DB instance that uses VPC security groups, we recommend that you
            /// specify the VPCSecurityGroups property. If you don&#39;t specify the property, the Read Replica inherits
            /// the value of the VPCSecurityGroups property from the source DB when you create the replica. However,
            /// if you update the stack, AWS CloudFormation reverts the replica&#39;s VPCSecurityGroups property to the
            /// default value because it&#39;s not defined in the stack&#39;s template. This change might cause unexpected
            /// issues. Read Replicas don&#39;t support deletion policies. AWS CloudFormation ignores any deletion
            /// policy that&#39;s associated with a Read Replica. If you specify SourceDBInstanceIdentifier, don&#39;t
            /// specify the DBSnapshotIdentifier property. You can&#39;t create a Read Replica from a snapshot. Don&#39;t
            /// set the BackupRetentionPeriod, DBName, MasterUsername, MasterUserPassword, and PreferredBackupWindow
            /// properties. The database attributes are inherited from the source DB instance, and backups are
            /// disabled for Read Replicas. If the source DB instance is in a different region than the Read
            /// Replica, specify the source region in SourceRegion, and specify an ARN for a valid DB instance in
            /// SourceDBInstanceIdentifier. For more information, see Constructing a Amazon RDS Amazon Resource Name
            /// (ARN) in the Amazon RDS User Guide. For DB instances in Amazon Aurora clusters, don&#39;t specify this
            /// property. Amazon RDS automatically assigns writer and reader DB instances.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceDBInstanceIdentifier { get; set; }

            /// <summary>
            /// SourceRegion
            /// The ID of the region that contains the source DB instance for the Read Replica.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SourceRegion { get; set; }

            /// <summary>
            /// StorageEncrypted
            /// A value that indicates whether the DB instance is encrypted. By default, it isn&#39;t encrypted.
            /// Amazon Aurora
            /// Not applicable. The encryption for DB instances is managed by the DB cluster.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> StorageEncrypted { get; set; }

            /// <summary>
            /// StorageType
            /// Specifies the storage type to be associated with the DB instance.
            /// Valid values: standard | gp2 | io1
            /// The standard value is also known as magnetic.
            /// If you specify io1, you must also include a value for the Iops parameter.
            /// Default: io1 if the Iops parameter is specified, otherwise standard
            /// For more information, see Amazon RDS DB Instance Storage in the Amazon RDS User Guide.
            /// Note This setting doesn&#39;t apply to Amazon Aurora.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> StorageType { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the DB instance.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Timezone
            /// The time zone of the DB instance. The time zone parameter is currently supported only by Microsoft
            /// SQL Server.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Timezone { get; set; }

            /// <summary>
            /// UseDefaultProcessorFeatures
            /// A value that indicates whether the DB instance class of the DB instance uses its default processor
            /// features.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> UseDefaultProcessorFeatures { get; set; }

            /// <summary>
            /// VPCSecurityGroups
            /// A list of the VPC security group IDs to assign to the DB instance. The list can include both the
            /// physical IDs of existing VPC security groups and references to AWS::EC2::SecurityGroup resources
            /// created in the template.
            /// If you plan to update the resource, don&#39;t specify VPC security groups in a shared VPC.
            /// If you set VPCSecurityGroups, you must not set DBSecurityGroups, and vice versa.
            /// Important You can migrate a DB instance in your stack from an RDS DB security group to a VPC
            /// security group, but keep the following in mind: You can&#39;t revert to using an RDS security group
            /// after you establish a VPC security group membership. When you migrate your DB instance to VPC
            /// security groups, if your stack update rolls back because the DB instance update fails or because an
            /// update fails in another AWS CloudFormation resource, the rollback fails because it can&#39;t revert to
            /// an RDS security group. To use the properties that are available when you use a VPC security group,
            /// you must recreate the DB instance. If you don&#39;t, AWS CloudFormation submits only the property values
            /// that are listed in the DBSecurityGroups property.
            /// To avoid this situation, migrate your DB instance to using VPC security groups only when that is the
            /// only change in your stack template.
            /// Amazon Aurora
            /// Not applicable. The associated list of EC2 VPC security groups is managed by the DB cluster.
            /// Required: No
            /// Type: List of String
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
