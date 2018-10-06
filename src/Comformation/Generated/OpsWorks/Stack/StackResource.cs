using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS::OpsWorks::Stack
    /// Creates an AWS OpsWorks stack. An AWS OpsWorks stack represents a set of instances that you want to manage
    /// collectively, typically because they have a common purpose such as serving PHP applications.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// AgentVersion
            /// The AWS OpsWorks agent version that you want to use. The agent communicates with the service and
            /// handles tasks such as initiating Chef runs in response to lifecycle events. For valid values, see
            /// the AgentVersion parameter for the CreateStack action in the AWS OpsWorks Stacks API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AgentVersion { get; set; }

            /// <summary>
            /// Attributes
            /// One or more user-defined key-value pairs to be added to the stack attributes bag.
            /// Required: No
            /// Type: A list of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

            /// <summary>
            /// ChefConfiguration
            /// Describes the Chef configuration. For more information, see the CreateStack ChefConfiguration
            /// parameter in the AWS OpsWorks Stacks API Reference.
            /// Note To enable Berkshelf, you must select a Chef version in the ConfigurationManager property that
            /// supports Berkshelf.
            /// Required: No
            /// Type: AWS OpsWorks ChefConfiguration Type
            /// Update requires: No interruption
            /// </summary>
			public ChefConfiguration ChefConfiguration { get; set; }

            /// <summary>
            /// CloneAppIds
            /// If you&#39;re cloning an AWS OpsWorks stack, a list of AWS OpsWorks application stack IDs from the
            /// source stack to include in the cloned stack.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CloneAppIds { get; set; }

            /// <summary>
            /// ClonePermissions
            /// If you&#39;re cloning an AWS OpsWorks stack, indicates whether to clone the source stack&#39;s permissions.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> ClonePermissions { get; set; }

            /// <summary>
            /// ConfigurationManager
            /// Describes the configuration manager. When you create a stack, you use the configuration manager to
            /// specify the Chef version. For supported Chef versions, see the CreateStack ConfigurationManager
            /// parameter in the AWS OpsWorks Stacks API Reference.
            /// Required: No
            /// Type: AWS OpsWorks StackConfigurationManager Type
            /// Update requires: No interruption
            /// </summary>
			public StackConfigurationManager ConfigurationManager { get; set; }

            /// <summary>
            /// CustomCookbooksSource
            /// Contains the information required to retrieve a cookbook from a repository.
            /// Required: No
            /// Type: AWS OpsWorks Source Type
            /// Update requires: No interruption
            /// </summary>
			public Source CustomCookbooksSource { get; set; }

            /// <summary>
            /// CustomJson
            /// A user-defined custom JSON object. The custom JSON is used to override the corresponding default
            /// stack configuration JSON values. For more information, see CreateStack in the AWS OpsWorks Stacks
            /// API Reference.
            /// Important AWS CloudFormation submits all JSON attributes as strings, including any Boolean or number
            /// attributes. If you have recipes that expect booleans or numbers, you must modify the recipes to
            /// accept strings and to interpret those strings as booleans or numbers.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CustomJson { get; set; }

            /// <summary>
            /// DefaultAvailabilityZone
            /// The stack&#39;s default Availability Zone, which must be in the specified region.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultAvailabilityZone { get; set; }

            /// <summary>
            /// DefaultInstanceProfileArn
            /// The Amazon Resource Name (ARN) of an IAM instance profile that is the default profile for all of the
            /// stack&#39;s Amazon EC2 instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultInstanceProfileArn { get; set; }

            /// <summary>
            /// DefaultOs
            /// The stack&#39;s default operating system. For more information, see CreateStack in the AWS OpsWorks
            /// Stacks API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultOs { get; set; }

            /// <summary>
            /// DefaultRootDeviceType
            /// The default root device type. This value is used by default for all instances in the stack, but you
            /// can override it when you create an instance. For more information, see CreateStack in the AWS
            /// OpsWorks Stacks API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRootDeviceType { get; set; }

            /// <summary>
            /// DefaultSshKeyName
            /// A default SSH key for the stack instances. You can override this value when you create or update an
            /// instance.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultSshKeyName { get; set; }

            /// <summary>
            /// DefaultSubnetId
            /// The stack&#39;s default subnet ID. All instances are launched into this subnet unless you specify
            /// another subnet ID when you create the instance.
            /// Required: Conditional. If you specify the VpcId property, you must specify this property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultSubnetId { get; set; }

            /// <summary>
            /// EcsClusterArn
            /// The Amazon Resource Name (ARN) of the Amazon Elastic Container Service (Amazon ECS) cluster to
            /// register with the AWS OpsWorks stack.
            /// Note If you specify a cluster that&#39;s registered with another AWS OpsWorks stack, AWS CloudFormation
            /// deregisters the existing association before registering the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EcsClusterArn { get; set; }

            /// <summary>
            /// ElasticIps
            /// A list of Elastic IP addresses to register with the AWS OpsWorks stack.
            /// Note If you specify an IP address that&#39;s registered with another AWS OpsWorks stack, AWS
            /// CloudFormation deregisters the existing association before registering the IP address.
            /// Required: No
            /// Type: List of AWS OpsWorks Stack ElasticIp
            /// Update requires: No interruption
            /// </summary>
			public List<ElasticIp> ElasticIps { get; set; }

            /// <summary>
            /// HostnameTheme
            /// The stack&#39;s host name theme, with spaces replaced by underscores. The theme is used to generate host
            /// names for the stack&#39;s instances. For more information, see CreateStack in the AWS OpsWorks Stacks
            /// API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HostnameTheme { get; set; }

            /// <summary>
            /// Name
            /// The name of the AWS OpsWorks stack.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RdsDbInstances
            /// The Amazon Relational Database Service (Amazon RDS) DB instance to register with the AWS OpsWorks
            /// stack.
            /// Note If you specify a DB instance that&#39;s registered with another AWS OpsWorks stack, AWS
            /// CloudFormation deregisters the existing association before registering the DB instance.
            /// Required: No
            /// Type: List of AWS OpsWorks Stack RdsDbInstance
            /// Update requires: No interruption
            /// </summary>
			public List<RdsDbInstance> RdsDbInstances { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The AWS Identity and Access Management (IAM) role that AWS OpsWorks uses to work with AWS resources
            /// on your behalf. You must specify an Amazon Resource Name (ARN) for an existing IAM role.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// SourceStackId
            /// If you&#39;re cloning an AWS OpsWorks stack, the stack ID of the source AWS OpsWorks stack to clone.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceStackId { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this AWS OpsWorks stack. Use
            /// tags to manage your resources.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// UseCustomCookbooks
            /// Whether the stack uses custom cookbooks.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> UseCustomCookbooks { get; set; }

            /// <summary>
            /// UseOpsworksSecurityGroups
            /// Whether to associate the AWS OpsWorks built-in security groups with the stack&#39;s layers.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> UseOpsworksSecurityGroups { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC that the stack is to be launched into, which must be in the specified region. All
            /// instances are launched into this VPC. If you specify this property, you must specify the
            /// DefaultSubnetId property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::Stack";
        
        public StackProperties Properties { get; } = new StackProperties();

    }
}
