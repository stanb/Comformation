using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// AWS::AmazonMQ::Broker
    /// A broker is a message broker environment running on Amazon MQ. It is the basic building block of Amazon MQ.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-broker.html
    /// </summary>
    public class BrokerResource : ResourceBase
    {
        public class BrokerProperties
        {
            /// <summary>
            /// SecurityGroups
            /// The list of rules (1 minimum, 125 maximum) that authorize connections to brokers.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version of the broker engine.
            /// Note For a list of supported engine versions, see: Broker Engine.
            /// Required: Yes
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// Configuration
            /// The broker configuration. If no configuration exists for a broker, Amazon MQ creates a default
            /// configuration.
            /// Note You can use AWS CloudFormation to modify—but not delete—an Amazon MQ configuration.
            /// Required: No
            /// Type: ConfigurationId
            /// Update requires: Some interruptions
            /// </summary>
			public ConfigurationId Configuration { get; set; }

            /// <summary>
            /// MaintenanceWindowStartTime
            /// The parameters that determine the WeeklyStartTime.
            /// Required: No
            /// Type: MaintenanceWindow
            /// Update requires: Replacement
            /// </summary>
			public MaintenanceWindow MaintenanceWindowStartTime { get; set; }

            /// <summary>
            /// HostInstanceType
            /// The broker&#39;s instance type. For more information, see Instance Types in the Amazon MQ Developer
            /// Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> HostInstanceType { get; set; }

            /// <summary>
            /// AutoMinorVersionUpgrade
            /// Enables automatic upgrades to new minor versions for brokers, as Apache releases the versions. The
            /// automatic upgrades occur during the maintenance window of the broker or after a manual broker
            /// reboot.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoMinorVersionUpgrade { get; set; }

            /// <summary>
            /// Users
            /// The list of all ActiveMQ usernames for the specified broker.
            /// Required: Yes
            /// Type: List of User property types
            /// Update requires: Some interruptions
            /// </summary>
			public List<User> Users { get; set; }

            /// <summary>
            /// Logs
            /// The Amazon CloudWatch Logs configuration for the broker.
            /// Required: No
            /// Type: LogsConfiguration
            /// Update requires: Some interruptions
            /// </summary>
			public LogList Logs { get; set; }

            /// <summary>
            /// SubnetIds
            /// The list of groups (2 maximum) that define which subnets and IP ranges the broker can use from
            /// different Availability Zones. A SINGLE_INSTANCE deployment requires one subnet (for example, the
            /// default subnet). An ACTIVE_STANDBY_MULTI_AZ deployment requires two subnets.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// BrokerName
            /// The name of the broker. This value must be unique in your AWS account, 1-50 characters long, must
            /// contain only letters, numbers, dashes, and underscores, and must not contain whitespaces, brackets,
            /// wildcard characters, or special characters.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BrokerName { get; set; }

            /// <summary>
            /// DeploymentMode
            /// The deployment mode of the broker. SINGLE_INSTANCE creates a single-instance broker in a single
            /// Availability Zone. ACTIVE_STANDBY_MULTI_AZ creates an active/standby broker for high availability.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentMode { get; set; }

            /// <summary>
            /// EngineType
            /// The type of broker engine.
            /// Note Currently, Amazon MQ supports only ACTIVEMQ.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EngineType { get; set; }

            /// <summary>
            /// PubliclyAccessible
            /// Enables connections from applications outside of the VPC that hosts the broker&#39;s subnets.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> PubliclyAccessible { get; set; }

        }

        public string Type { get; } = "AWS::AmazonMQ::Broker";

        public BrokerProperties Properties { get; } = new BrokerProperties();

    }

	public static class BrokerAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> BrokerId = new ResourceAttribute<Union<string, IntrinsicFunction>>("BrokerId");
	}
}
