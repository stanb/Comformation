using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer
    /// Creates an AWS OpsWorks layer. A layer defines, for example, which packages and applications are installed and
    /// how they are configured.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html
    /// </summary>
    public class LayerResource : ResourceBase
    {
        public class LayerProperties
        {
            /// <summary>
            /// Attributes
            /// One or more user-defined key-value pairs to be added to the stack attributes bag.
            /// Required: No
            /// Type: A list of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Attributes { get; set; }

            /// <summary>
            /// AutoAssignElasticIps
            /// Whether to automatically assign an Elastic IP address to Amazon EC2 instances in this layer.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoAssignElasticIps { get; set; }

            /// <summary>
            /// AutoAssignPublicIps
            /// For AWS OpsWorks stacks that are running in a VPC, whether to automatically assign a public IP
            /// address to Amazon EC2 instances in this layer.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoAssignPublicIps { get; set; }

            /// <summary>
            /// CustomInstanceProfileArn
            /// The Amazon Resource Name (ARN) of an IAM instance profile that is to be used for the Amazon EC2
            /// instances in this layer.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CustomInstanceProfileArn { get; set; }

            /// <summary>
            /// CustomJson
            /// A custom stack configuration and deployment attributes that AWS OpsWorks installs on the layer's
            /// instances. For more information, see the CustomJson parameter for the CreateLayer action in the AWS
            /// OpsWorks Stacks API Reference.
            /// Required: No
            /// Type: JSON object
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CustomJson { get; set; }

            /// <summary>
            /// CustomRecipes
            /// Custom event recipes for this layer.
            /// Required: No
            /// Type: AWS OpsWorks Recipes Type
            /// Update requires: No interruption
            /// </summary>
			public Union<Recipes, IntrinsicFunction> CustomRecipes { get; set; }

            /// <summary>
            /// CustomSecurityGroupIds
            /// Custom security group IDs for this layer.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> CustomSecurityGroupIds { get; set; }

            /// <summary>
            /// EnableAutoHealing
            /// Whether to automatically heal Amazon EC2 instances that have become disconnected or timed out.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableAutoHealing { get; set; }

            /// <summary>
            /// InstallUpdatesOnBoot
            /// Whether to install operating system and package updates when the instance boots.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> InstallUpdatesOnBoot { get; set; }

            /// <summary>
            /// LifecycleEventConfiguration
            /// The lifecycle events for the AWS OpsWorks layer.
            /// Required: No
            /// Type: AWS OpsWorks Layer LifeCycleConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<LifecycleEventConfiguration, IntrinsicFunction> LifecycleEventConfiguration { get; set; }

            /// <summary>
            /// LoadBasedAutoScaling
            /// The load-based scaling configuration for the AWS OpsWorks layer.
            /// Required: No
            /// Type: AWS OpsWorks LoadBasedAutoScaling Type
            /// Update requires: No interruption
            /// </summary>
			public Union<LoadBasedAutoScaling, IntrinsicFunction> LoadBasedAutoScaling { get; set; }

            /// <summary>
            /// Name
            /// The AWS OpsWorks layer name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Packages
            /// The packages for this layer.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Packages { get; set; }

            /// <summary>
            /// Shortname
            /// The layer short name, which is used internally by AWS OpsWorks and by Chef recipes. The short name
            /// is also used as the name for the directory where your app files are installed.
            /// The name can have a maximum of 200 characters, which are limited to the alphanumeric characters,
            /// '-', '_', and '. '.
            /// Important If you update a property that requires the layer to be replaced, you must specify a new
            /// short name. You cannot have multiple layers with the same short name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Shortname { get; set; }

            /// <summary>
            /// StackId
            /// The ID of the AWS OpsWorks stack that this layer will be associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this AWS OpsWorks layer. Use
            /// tags to manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Type
            /// The layer type. A stack cannot have more than one layer of the same type, except for the custom
            /// type. You can have any number of custom types. For more information, see CreateLayer in the AWS
            /// OpsWorks Stacks API Reference.
            /// Important If you update a property that requires the layer to be replaced, you must specify a new
            /// type unless you have a custom type. You can have any number of custom types.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// UseEbsOptimizedInstances
            /// </summary>
			public Union<bool, IntrinsicFunction> UseEbsOptimizedInstances { get; set; }

            /// <summary>
            /// VolumeConfigurations
            /// Describes the Amazon EBS volumes for this layer.
            /// Required: No
            /// Type: A list of AWS OpsWorks VolumeConfiguration Type
            /// Update requires: Some interruptions
            /// </summary>
			public Union<List<VolumeConfiguration>, IntrinsicFunction> VolumeConfigurations { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::Layer";
        
        public LayerProperties Properties { get; } = new LayerProperties();
    }
}
