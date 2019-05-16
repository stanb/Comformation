using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS::OpsWorks::Stack
    /// Creates a new stack. For more information, see Create a New Stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// AgentVersion
            /// The default AWS OpsWorks Stacks agent version. You have the following options:
            /// Auto-update - Set this parameter to LATEST. AWS OpsWorks Stacks automatically installs new agent
            /// versions on the stack&#39;s instances as soon as they are available. Fixed version - Set this parameter
            /// to your preferred agent version. To update the agent version, you must edit the stack configuration
            /// and specify a new version. AWS OpsWorks Stacks then automatically installs that version on the
            /// stack&#39;s instances.
            /// The default setting is the most recent release of the agent. To specify an agent version, you must
            /// use the complete version number, not the abbreviated number shown on the console. For a list of
            /// available agent version numbers, call DescribeAgentVersions. AgentVersion cannot be set to Chef 12.
            /// 2.
            /// Note You can also specify an agent version when you create or update an instance, which overrides
            /// the stack&#39;s default setting.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AgentVersion { get; set; }

            /// <summary>
            /// Attributes
            /// One or more user-defined key-value pairs to be added to the stack attributes.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

            /// <summary>
            /// ChefConfiguration
            /// A ChefConfiguration object that specifies whether to enable Berkshelf and the Berkshelf version on
            /// Chef 11. 10 stacks. For more information, see Create a New Stack.
            /// Required: No
            /// Type: ChefConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ChefConfiguration ChefConfiguration { get; set; }

            /// <summary>
            /// CloneAppIds
            /// If you&#39;re cloning an AWS OpsWorks stack, a list of AWS OpsWorks application stack IDs from the
            /// source stack to include in the cloned stack.
            /// Required: No
            /// Type: List of String
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
            /// The configuration manager. When you create a stack we recommend that you use the configuration
            /// manager to specify the Chef version: 12, 11. 10, or 11. 4 for Linux stacks, or 12. 2 for Windows
            /// stacks. The default value for Linux stacks is currently 12.
            /// Required: No
            /// Type: StackConfigurationManager
            /// Update requires: No interruption
            /// </summary>
			public StackConfigurationManager ConfigurationManager { get; set; }

            /// <summary>
            /// CustomCookbooksSource
            /// Contains the information required to retrieve an app or cookbook from a repository. For more
            /// information, see Adding Apps or Cookbooks and Recipes.
            /// Required: No
            /// Type: Source
            /// Update requires: No interruption
            /// </summary>
			public Source CustomCookbooksSource { get; set; }

            /// <summary>
            /// CustomJson
            /// A string that contains user-defined, custom JSON. It can be used to override the corresponding
            /// default stack configuration attribute values or to pass data to recipes. The string should be in the
            /// following format:
            /// &quot;{\&quot;key1\&quot;: \&quot;value1\&quot;, \&quot;key2\&quot;: \&quot;value2\&quot;,. . . }&quot;
            /// For more information about custom JSON, see Use Custom JSON to Modify the Stack Configuration
            /// Attributes.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CustomJson { get; set; }

            /// <summary>
            /// DefaultAvailabilityZone
            /// The stack&#39;s default Availability Zone, which must be in the specified region. For more information,
            /// see Regions and Endpoints. If you also specify a value for DefaultSubnetId, the subnet must be in
            /// the same zone. For more information, see the VpcId parameter description.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultAvailabilityZone { get; set; }

            /// <summary>
            /// DefaultInstanceProfileArn
            /// The Amazon Resource Name (ARN) of an IAM profile that is the default profile for all of the stack&#39;s
            /// EC2 instances. For more information about IAM ARNs, see Using Identifiers.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultInstanceProfileArn { get; set; }

            /// <summary>
            /// DefaultOs
            /// The stack&#39;s default operating system, which is installed on every instance unless you specify a
            /// different operating system when you create the instance. You can specify one of the following.
            /// A supported Linux operating system: An Amazon Linux version, such as Amazon Linux 2018. 03, Amazon
            /// Linux 2017. 09, Amazon Linux 2017. 03, Amazon Linux 2016. 09, Amazon Linux 2016. 03, Amazon Linux
            /// 2015. 09, or Amazon Linux 2015. 03. A supported Ubuntu operating system, such as Ubuntu 16. 04 LTS,
            /// Ubuntu 14. 04 LTS, or Ubuntu 12. 04 LTS. CentOS Linux 7 Red Hat Enterprise Linux 7 A supported
            /// Windows operating system, such as Microsoft Windows Server 2012 R2 Base, Microsoft Windows Server
            /// 2012 R2 with SQL Server Express, Microsoft Windows Server 2012 R2 with SQL Server Standard, or
            /// Microsoft Windows Server 2012 R2 with SQL Server Web. A custom AMI: Custom. You specify the custom
            /// AMI you want to use when you create instances. For more information, see Using Custom AMIs.
            /// The default option is the current Amazon Linux version. For more information about supported
            /// operating systems, see AWS OpsWorks Stacks Operating Systems.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultOs { get; set; }

            /// <summary>
            /// DefaultRootDeviceType
            /// The default root device type. This value is the default for all instances in the stack, but you can
            /// override it when you create an instance. The default option is instance-store. For more information,
            /// see Storage for the Root Device.
            /// Required: No
            /// Type: String
            /// Allowed Values: ebs | instance-store
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRootDeviceType { get; set; }

            /// <summary>
            /// DefaultSshKeyName
            /// A default Amazon EC2 key pair name. The default value is none. If you specify a key pair name, AWS
            /// OpsWorks installs the public key on the instance and you can use the private key with an SSH client
            /// to log in to the instance. For more information, see Using SSH to Communicate with an Instance and
            /// Managing SSH Access. You can override this setting by specifying a different key pair, or no key
            /// pair, when you create an instance.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultSshKeyName { get; set; }

            /// <summary>
            /// DefaultSubnetId
            /// The stack&#39;s default subnet ID. All instances are launched into this subnet unless you specify
            /// another subnet ID when you create the instance. This parameter is required if you specify a value
            /// for the VpcId parameter. If you also specify a value for DefaultAvailabilityZone, the subnet must be
            /// in that zone.
            /// Required: Conditional
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
            /// Type: List of ElasticIp
            /// Update requires: No interruption
            /// </summary>
			public List<ElasticIp> ElasticIps { get; set; }

            /// <summary>
            /// HostnameTheme
            /// The stack&#39;s host name theme, with spaces replaced by underscores. The theme is used to generate host
            /// names for the stack&#39;s instances. By default, HostnameTheme is set to Layer_Dependent, which creates
            /// host names by appending integers to the layer&#39;s short name. The other themes are:
            /// Baked_Goods Clouds Europe_Cities Fruits Greek_Deities_and_Titans Legendary_creatures_from_Japan
            /// Planets_and_Moons Roman_Deities Scottish_Islands US_Cities Wild_Cats
            /// To obtain a generated host name, call GetHostNameSuggestion, which returns a host name based on the
            /// current theme.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HostnameTheme { get; set; }

            /// <summary>
            /// Name
            /// The stack name.
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
            /// Type: List of RdsDbInstance
            /// Update requires: No interruption
            /// </summary>
			public List<RdsDbInstance> RdsDbInstances { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The stack&#39;s AWS Identity and Access Management (IAM) role, which allows AWS OpsWorks Stacks to work
            /// with AWS resources on your behalf. You must set this parameter to the Amazon Resource Name (ARN) for
            /// an existing IAM role. For more information about IAM ARNs, see Using Identifiers.
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
            /// A map that contains tag keys and tag values that are attached to a stack or layer.
            /// The key cannot be empty. The key can be a maximum of 127 characters, and can contain only Unicode
            /// letters, numbers, or separators, or the following special characters: + - = . _ : / The value can be
            /// a maximum 255 characters, and contain only Unicode letters, numbers, or separators, or the following
            /// special characters: + - = . _ : / Leading and trailing white spaces are trimmed from both the key
            /// and value. A maximum of 40 tags is allowed for any resource.
            /// Required: No
            /// Type: List of Tag
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
            /// Whether to associate the AWS OpsWorks Stacks built-in security groups with the stack&#39;s layers.
            /// AWS OpsWorks Stacks provides a standard set of built-in security groups, one for each layer, which
            /// are associated with layers by default. With UseOpsworksSecurityGroups you can instead provide your
            /// own custom security groups. UseOpsworksSecurityGroups has the following settings:
            /// True - AWS OpsWorks Stacks automatically associates the appropriate built-in security group with
            /// each layer (default setting). You can associate additional security groups with a layer after you
            /// create it, but you cannot delete the built-in security group. False - AWS OpsWorks Stacks does not
            /// associate built-in security groups with layers. You must create appropriate EC2 security groups and
            /// associate a security group with each layer that you create. However, you can still manually
            /// associate a built-in security group with a layer on creation; custom security groups are required
            /// only for those layers that need custom settings.
            /// For more information, see Create a New Stack.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> UseOpsworksSecurityGroups { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC that the stack is to be launched into. The VPC must be in the stack&#39;s region. All
            /// instances are launched into this VPC. You cannot change the ID later.
            /// If your account supports EC2-Classic, the default value is no VPC. If your account does not support
            /// EC2-Classic, the default value is the default VPC for the specified region.
            /// If the VPC ID corresponds to a default VPC and you have specified either the DefaultAvailabilityZone
            /// or the DefaultSubnetId parameter only, AWS OpsWorks Stacks infers the value of the other parameter.
            /// If you specify neither parameter, AWS OpsWorks Stacks sets these parameters to the first valid
            /// Availability Zone for the specified region and the corresponding default VPC subnet ID,
            /// respectively.
            /// If you specify a nondefault VPC ID, note the following:
            /// It must belong to a VPC in your account that is in the specified region. You must specify a value
            /// for DefaultSubnetId.
            /// For more information about how to use AWS OpsWorks Stacks with a VPC, see Running a Stack in a VPC.
            /// For more information about default VPC and EC2-Classic, see Supported Platforms.
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
