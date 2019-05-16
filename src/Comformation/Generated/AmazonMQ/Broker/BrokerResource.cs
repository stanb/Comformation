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
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// EngineVersion
            /// The version of the broker engine. For a list of supported engine versions, see Engine in the Amazon
            /// MQ Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// Configuration
            /// A list of information about the configuration.
            /// Required: No
            /// Type: ConfigurationId
            /// Update requires: No interruption
            /// </summary>
			public ConfigurationId Configuration { get; set; }

            /// <summary>
            /// MaintenanceWindowStartTime
            /// The scheduled time period relative to UTC during which Amazon MQ begins to apply pending updates or
            /// patches to the broker. .
            /// Required: No
            /// Type: MaintenanceWindow
            /// Update requires: Replacement
            /// </summary>
			public MaintenanceWindow MaintenanceWindowStartTime { get; set; }

            /// <summary>
            /// HostInstanceType
            /// The broker&#39;s instance type.
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
            /// The list of ActiveMQ users (persons or applications) who can access queues and topics. This value
            /// can contain only alphanumeric characters, dashes, periods, underscores, and tildes (- . _ ~). This
            /// value must be 2-100 characters long.
            /// Required: Yes
            /// Type: List of User
            /// Update requires: No interruption
            /// </summary>
			public List<User> Users { get; set; }

            /// <summary>
            /// Logs
            /// Enables Amazon CloudWatch logging for brokers.
            /// Required: No
            /// Type: LogList
            /// Update requires: No interruption
            /// </summary>
			public LogList Logs { get; set; }

            /// <summary>
            /// SubnetIds
            /// The list of groups (2 maximum) that define which subnets and IP ranges the broker can use from
            /// different Availability Zones. A SINGLE_INSTANCE deployment requires one subnet (for example, the
            /// default subnet). An ACTIVE_STANDBY_MULTI_AZ deployment requires two subnets.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// BrokerName
            /// The name of the broker. This value must be unique in your AWS account, 1-50 characters long, must
            /// contain only letters, numbers, dashes, and underscores, and must not contain white spaces, brackets,
            /// wildcard characters, or special characters.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BrokerName { get; set; }

            /// <summary>
            /// DeploymentMode
            /// The deployment mode of the broker.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentMode { get; set; }

            /// <summary>
            /// EngineType
            /// The type of broker engine. Note: Currently, Amazon MQ supports only ACTIVEMQ.
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

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
			public List<TagsEntry> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AmazonMQ::Broker";

        public BrokerProperties Properties { get; } = new BrokerProperties();

    }

	public static class BrokerAttributes
	{
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> IpAddresses = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("IpAddresses");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> OpenWireEndpoints = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("OpenWireEndpoints");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> ConfigurationRevision = new ResourceAttribute<Union<int, IntrinsicFunction>>("ConfigurationRevision");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> StompEndpoints = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("StompEndpoints");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> MqttEndpoints = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("MqttEndpoints");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> AmqpEndpoints = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("AmqpEndpoints");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationId");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> WssEndpoints = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("WssEndpoints");
	}
}
