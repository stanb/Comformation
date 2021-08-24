using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorksCM.Server
{
    /// <summary>
    /// AWS::OpsWorksCM::Server
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworkscm-server.html
    /// </summary>
    public class ServerResource : ResourceBase
    {
        public class ServerProperties
        {
            /// <summary>
            /// KeyPair
            /// The Amazon EC2 key pair to set for the instance. This parameter is optional; if desired, you may
            /// specify this parameter to connect to your instances by using SSH.
            /// Required: No
            /// Type: String
            /// Maximum: 10000
            /// Pattern: . *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyPair { get; set; }

            /// <summary>
            /// EngineVersion
            /// The major release version of the engine that you want to use. For a Chef server, the valid value for
            /// EngineVersion is currently 2. For a Puppet server, valid values are 2019 or 2017.
            /// Required: No
            /// Type: String
            /// Maximum: 10000
            /// Pattern: (?s). *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The service role that the AWS OpsWorks CM service backend uses to work with your account. Although
            /// the AWS OpsWorks management console typically creates the service role for you, if you are using the
            /// AWS CLI or API commands, run the service-role-creation. yaml AWS CloudFormation template, located at
            /// https://s3. amazonaws. com/opsworks-cm-us-east-1-prod-default-assets/misc/opsworks-cm-roles. yaml.
            /// This template creates a CloudFormation stack that includes the service role and instance profile
            /// that you need.
            /// Required: Yes
            /// Type: String
            /// Maximum: 10000
            /// Pattern: arn:aws:iam::[0-9]{12}:role/. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// DisableAutomatedBackup
            /// Enable or disable scheduled backups. Valid values are true or false. The default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DisableAutomatedBackup { get; set; }

            /// <summary>
            /// BackupId
            /// If you specify this field, AWS OpsWorks CM creates the server by using the backup represented by
            /// BackupId.
            /// Required: No
            /// Type: String
            /// Maximum: 79
            /// Pattern: [a-zA-Z][a-zA-Z0-9\-\. \:]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BackupId { get; set; }

            /// <summary>
            /// EngineModel
            /// The engine model of the server. Valid values in this release include Monolithic for Puppet and
            /// Single for Chef.
            /// Required: No
            /// Type: String
            /// Maximum: 10000
            /// Pattern: (?s). *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineModel { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The start time for a one-hour period each week during which AWS OpsWorks CM performs maintenance on
            /// the instance. Valid values must be specified in the following format: DDD:HH:MM. MM must be
            /// specified as 00. The specified time is in coordinated universal time (UTC). The default value is a
            /// random one-hour period on Tuesday, Wednesday, or Friday. See TimeWindowDefinition for more
            /// information.
            /// Example: Mon:08:00, which represents a start time of every Monday at 08:00 UTC. (8:00 a. m. )
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AssociatePublicIpAddress
            /// Associate a public IP address with a server that you are launching. Valid values are true or false.
            /// The default value is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

            /// <summary>
            /// InstanceProfileArn
            /// The ARN of the instance profile that your Amazon EC2 instances use.
            /// Required: Yes
            /// Type: String
            /// Maximum: 10000
            /// Pattern: arn:aws:iam::[0-9]{12}:instance-profile/. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceProfileArn { get; set; }

            /// <summary>
            /// CustomCertificate
            /// Supported on servers running Chef Automate 2. 0 only. A PEM-formatted HTTPS certificate. The value
            /// can be be a single, self-signed certificate, or a certificate chain. If you specify a custom
            /// certificate, you must also specify values for CustomDomain and CustomPrivateKey. The following are
            /// requirements for the CustomCertificate value:
            /// You can provide either a self-signed, custom certificate, or the full certificate chain. The
            /// certificate must be a valid X509 certificate, or a certificate chain in PEM format. The certificate
            /// must be valid at the time of upload. A certificate can&#39;t be used before its validity period begins
            /// (the certificate&#39;s NotBefore date), or after it expires (the certificate&#39;s NotAfter date). The
            /// certificate’s common name or subject alternative names (SANs), if present, must match the value of
            /// CustomDomain. The certificate must match the value of CustomPrivateKey.
            /// Required: No
            /// Type: String
            /// Maximum: 2097152
            /// Pattern: (?s)\s*-----BEGIN CERTIFICATE-----. +-----END CERTIFICATE-----\s*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomCertificate { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The start time for a one-hour period during which AWS OpsWorks CM backs up application-level data on
            /// your server if automated backups are enabled. Valid values must be specified in one of the following
            /// formats:
            /// HH:MM for daily backups DDD:HH:MM for weekly backups
            /// MM must be specified as 00. The specified time is in coordinated universal time (UTC). The default
            /// value is a random, daily start time.
            /// Example: 08:00, which represents a daily start time of 08:00 UTC.
            /// Example: Mon:08:00, which represents a start time of every Monday at 08:00 UTC. (8:00 a. m. )
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of security group IDs to attach to the Amazon EC2 instance. If you add this parameter, the
            /// specified security groups must be within the VPC that is specified by SubnetIds.
            /// If you do not specify this parameter, AWS OpsWorks CM creates one new security group that uses TCP
            /// ports 22 and 443, open to 0. 0. 0. 0/0 (everyone).
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SubnetIds
            /// The IDs of subnets in which to launch the server EC2 instance.
            /// Amazon EC2-Classic customers: This field is required. All servers must run within a VPC. The VPC
            /// must have &quot;Auto Assign Public IP&quot; enabled.
            /// EC2-VPC customers: This field is optional. If you do not specify subnet IDs, your EC2 instances are
            /// created in a default subnet that is selected by Amazon EC2. If you specify subnet IDs, the VPC must
            /// have &quot;Auto Assign Public IP&quot; enabled.
            /// For more information about supported Amazon EC2 platforms, see Supported Platforms.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// CustomDomain
            /// Supported on servers running Chef Automate 2. 0 only. An optional public endpoint of a server, such
            /// as https://aws. my-company. com. To access the server, create a CNAME DNS record in your preferred
            /// DNS service that points the custom domain to the endpoint that is generated when the server is
            /// created (the value of the CreateServer Endpoint attribute). You cannot access the server by using
            /// the generated Endpoint value if the server is using a custom domain. If you specify a custom domain,
            /// you must also specify values for CustomCertificate and CustomPrivateKey.
            /// Required: No
            /// Type: String
            /// Maximum: 253
            /// Pattern: ^(((?!-)[A-Za-z0-9-]{0,62}[A-Za-z0-9])\. )+((?!-)[A-Za-z0-9-]{1,62}[A-Za-z0-9])$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomDomain { get; set; }

            /// <summary>
            /// CustomPrivateKey
            /// Supported on servers running Chef Automate 2. 0 only. A private key in PEM format for connecting to
            /// the server by using HTTPS. The private key must not be encrypted; it cannot be protected by a
            /// password or passphrase. If you specify a custom private key, you must also specify values for
            /// CustomDomain and CustomCertificate.
            /// Required: No
            /// Type: String
            /// Maximum: 4096
            /// Pattern: (?ms)\s*^-----BEGIN (?-s:. *)PRIVATE KEY-----$. *?^-----END (?-s:. *)PRIVATE KEY-----$\s*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CustomPrivateKey { get; set; }

            /// <summary>
            /// ServerName
            /// The name of the server. The server name must be unique within your AWS account, within each region.
            /// Server names must start with a letter; then letters, numbers, or hyphens (-) are allowed, up to a
            /// maximum of 40 characters.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 40
            /// Pattern: [a-zA-Z][a-zA-Z0-9\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerName { get; set; }

            /// <summary>
            /// EngineAttributes
            /// Optional engine attributes on a specified server.
            /// Attributes accepted in a Chef createServer request: CHEF_AUTOMATE_PIVOTAL_KEY: A base64-encoded RSA
            /// public key. The corresponding private key is required to access the Chef API. When no
            /// CHEF_AUTOMATE_PIVOTAL_KEY is set, a private key is generated and returned in the response. When you
            /// are specifying the value of CHEF_AUTOMATE_PIVOTAL_KEY as a parameter in the AWS CloudFormation
            /// console, you must add newline (\n) characters at the end of each line of the pivotal key value.
            /// CHEF_AUTOMATE_ADMIN_PASSWORD: The password for the administrative user in the Chef Automate
            /// web-based dashboard. The password length is a minimum of eight characters, and a maximum of 32. The
            /// password can contain letters, numbers, and special characters (!/@#$%^&amp;amp;+=_). The password must
            /// contain at least one lower case letter, one upper case letter, one number, and one special
            /// character. When no CHEF_AUTOMATE_ADMIN_PASSWORD is set, one is generated and returned in the
            /// response.
            /// Attributes accepted in a Puppet createServer request: PUPPET_ADMIN_PASSWORD: To work with the Puppet
            /// Enterprise console, a password must use ASCII characters. PUPPET_R10K_REMOTE: The r10k remote is the
            /// URL of your control repository (for example, ssh://git@your. git-repo. com:user/control-repo. git).
            /// Specifying an r10k remote opens TCP port 8170. PUPPET_R10K_PRIVATE_KEY: If you are using a private
            /// Git repository, add PUPPET_R10K_PRIVATE_KEY to specify a PEM-encoded private SSH key.
            /// Required: No
            /// Type: List of EngineAttribute
            /// Update requires: No interruption
            /// </summary>
            public List<EngineAttribute> EngineAttributes { get; set; }

            /// <summary>
            /// BackupRetentionCount
            /// The number of automated backups that you want to keep. Whenever a new backup is created, AWS
            /// OpsWorks CM deletes the oldest backups if this number is exceeded. The default value is 1.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> BackupRetentionCount { get; set; }

            /// <summary>
            /// InstanceType
            /// The Amazon EC2 instance type to use. For example, m5. large.
            /// Required: Yes
            /// Type: String
            /// Maximum: 10000
            /// Pattern: (?s). *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Tags
            /// A map that contains tag keys and tag values to attach to an AWS OpsWorks for Chef Automate or
            /// OpsWorks for Puppet Enterprise server.
            /// The key cannot be empty. The key can be a maximum of 127 characters, and can contain only Unicode
            /// letters, numbers, or separators, or the following special characters: + - = . _ : / @ The value can
            /// be a maximum 255 characters, and contain only Unicode letters, numbers, or separators, or the
            /// following special characters: + - = . _ : / @ Leading and trailing spaces are trimmed from both the
            /// key and value. A maximum of 50 user-applied tags is allowed for any AWS OpsWorks CM server.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Engine
            /// The configuration management engine to use. Valid values include ChefAutomate and Puppet.
            /// Required: No
            /// Type: String
            /// Maximum: 10000
            /// Pattern: (?s). *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Engine { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorksCM::Server";

        public ServerProperties Properties { get; } = new ServerProperties();

    }

    public static class ServerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
