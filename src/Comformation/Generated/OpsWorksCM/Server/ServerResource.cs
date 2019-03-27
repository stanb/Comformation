using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorksCM.Server
{
    /// <summary>
    /// AWS::OpsWorksCM::Server
    /// The AWS::OpsWorksCM::Server resource creates an AWS OpsWorks for Chef Automate or AWS OpsWorks for Puppet
    /// Enterprise configuration management server. For more information, see Create a Chef Automate Server in AWS
    /// CloudFormation or Create a Puppet Enterprise Master in AWS CloudFormation in the AWS OpsWorks User Guide, and
    /// CreateServer in the AWS OpsWorks CM API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworkscm-server.html
    /// </summary>
    public class ServerResource : ResourceBase
    {
        public class ServerProperties
        {
            /// <summary>
            /// KeyPair
            /// The key pair associated with the server.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyPair { get; set; }

            /// <summary>
            /// EngineVersion
            /// The engine version of the server. For a Chef server, the valid value for EngineVersion is 12. For a
            /// Puppet server, the valid value is 2017.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The service role ARN used to create the server.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// DisableAutomatedBackup
            /// Enable or disable scheduled backups. Valid values are true or false. The default value is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableAutomatedBackup { get; set; }

            /// <summary>
            /// BackupId
            /// If you specify this field, AWS OpsWorks CM creates the server by using the backup represented by
            /// BackupId.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BackupId { get; set; }

            /// <summary>
            /// EngineModel
            /// The engine model of the server. Valid values include Monolithic for Puppet and Single for Chef.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineModel { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// The preferred maintenance period specified for the server.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// AssociatePublicIpAddress
            /// Associate a public IP address with the server. Valid values are true or false. The default value is
            /// true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> AssociatePublicIpAddress { get; set; }

            /// <summary>
            /// InstanceProfileArn
            /// The instance profile ARN of the server.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceProfileArn { get; set; }

            /// <summary>
            /// PreferredBackupWindow
            /// The preferred backup period specified for the server.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredBackupWindow { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The security group IDs for the server, as specified in the AWS CloudFormation stack. These might not
            /// be the same security groups that are shown for the server in the Amazon EC2 console.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// SubnetIds
            /// The subnet IDs specified in a createServer() request.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// ServerName
            /// The name of the server.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServerName { get; set; }

            /// <summary>
            /// EngineAttributes
            /// In a createServer() request, EngineAttributes contains the administrator credentials to access the
            /// configuration management server. These credentials are not stored by AWS OpsWorks CM.
            /// Attributes accepted in a createServer request for Chef Automate: CHEF_PIVOTAL_KEY: A base64-encoded
            /// RSA public key. When no CHEF_PIVOTAL_KEY is set, a private key is generated by AWS OpsWorks for Chef
            /// Automate and returned in the response. The corresponding private key is required to access the Chef
            /// API.
            /// Attributes accepted in a createServer request for Puppet Enterprise: PUPPET_ADMIN_PASSWORD: An
            /// administrator password that you can use to sign in to the Puppet Enterprise console after the server
            /// is online. The password must use between 8 and 32 ASCII characters. PUPPET_R10K_REMOTE: The r10k
            /// remote is the URL of your control repository (for example, ssh://git@your. git-repo.
            /// com:user/control-repo. git). Specifying an r10k remote opens TCP port 8170. PUPPET_R10K_PRIVATE_KEY:
            /// If you are using a private Git repository, add PUPPET_R10K_PRIVATE_KEY to specify a PEM-encoded
            /// private SSH key.
            /// Required: No
            /// Type: List of EngineAttribute property types
            /// Update requires: Replacement
            /// </summary>
			public List<EngineAttribute> EngineAttributes { get; set; }

            /// <summary>
            /// BackupRetentionCount
            /// The number of automated backups that you want to keep. Whenever a new backup is created, AWS
            /// OpsWorks CM deletes the oldest backups if this number is exceeded. The default value is 1.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> BackupRetentionCount { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type for the server, as specified in the AWS CloudFormation stack. This might not be
            /// the same instance type that is shown for the server in the Amazon EC2 console.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Engine
            /// The configuration management engine to use. Valid values are Chef or Puppet.
            /// Required: No
            /// Type: String
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
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
