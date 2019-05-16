using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer
    /// Creates a layer. For more information, see How to Create a Layer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html
    /// </summary>
    public class LayerResource : ResourceBase
    {
        public class LayerProperties
        {
            /// <summary>
            /// Attributes
            /// One or more user-defined key-value pairs to be added to the stack attributes.
            /// To create a cluster layer, set the EcsClusterArn attribute to the cluster&#39;s ARN.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

            /// <summary>
            /// AutoAssignElasticIps
            /// Whether to automatically assign an Elastic IP address to the layer&#39;s instances. For more
            /// information, see How to Edit a Layer.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoAssignElasticIps { get; set; }

            /// <summary>
            /// AutoAssignPublicIps
            /// For stacks that are running in a VPC, whether to automatically assign a public IP address to the
            /// layer&#39;s instances. For more information, see How to Edit a Layer.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AutoAssignPublicIps { get; set; }

            /// <summary>
            /// CustomInstanceProfileArn
            /// The ARN of an IAM profile to be used for the layer&#39;s EC2 instances. For more information about IAM
            /// ARNs, see Using Identifiers.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CustomInstanceProfileArn { get; set; }

            /// <summary>
            /// CustomJson
            /// A JSON-formatted string containing custom stack configuration and deployment attributes to be
            /// installed on the layer&#39;s instances. For more information, see Using Custom JSON. This feature is
            /// supported as of version 1. 7. 42 of the AWS CLI.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CustomJson { get; set; }

            /// <summary>
            /// CustomRecipes
            /// A LayerCustomRecipes object that specifies the layer custom recipes.
            /// Required: No
            /// Type: Recipes
            /// Update requires: No interruption
            /// </summary>
			public Recipes CustomRecipes { get; set; }

            /// <summary>
            /// CustomSecurityGroupIds
            /// An array containing the layer custom security group IDs.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CustomSecurityGroupIds { get; set; }

            /// <summary>
            /// EnableAutoHealing
            /// Whether to disable auto healing for the layer.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableAutoHealing { get; set; }

            /// <summary>
            /// InstallUpdatesOnBoot
            /// Whether to install operating system and package updates when the instance boots. The default value
            /// is true. To control when updates are installed, set this value to false. You must then update your
            /// instances manually by using CreateDeployment to run the update_dependencies stack command or by
            /// manually running yum (Amazon Linux) or apt-get (Ubuntu) on the instances.
            /// Note To ensure that your instances have the latest security updates, we strongly recommend using the
            /// default value of true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> InstallUpdatesOnBoot { get; set; }

            /// <summary>
            /// LifecycleEventConfiguration
            /// A LifeCycleEventConfiguration object that you can use to configure the Shutdown event to specify an
            /// execution timeout and enable or disable Elastic Load Balancer connection draining.
            /// Required: No
            /// Type: LifecycleEventConfiguration
            /// Update requires: No interruption
            /// </summary>
			public LifecycleEventConfiguration LifecycleEventConfiguration { get; set; }

            /// <summary>
            /// LoadBasedAutoScaling
            /// The load-based scaling configuration for the AWS OpsWorks layer.
            /// Required: No
            /// Type: LoadBasedAutoScaling
            /// Update requires: No interruption
            /// </summary>
			public LoadBasedAutoScaling LoadBasedAutoScaling { get; set; }

            /// <summary>
            /// Name
            /// The layer name, which is used by the console.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Packages
            /// An array of Package objects that describes the layer packages.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Packages { get; set; }

            /// <summary>
            /// Shortname
            /// For custom layers only, use this parameter to specify the layer&#39;s short name, which is used
            /// internally by AWS OpsWorks Stacks and by Chef recipes. The short name is also used as the name for
            /// the directory where your app files are installed. It can have a maximum of 200 characters, which are
            /// limited to the alphanumeric characters, &#39;-&#39;, &#39;_&#39;, and &#39;. &#39;.
            /// The built-in layers&#39; short names are defined by AWS OpsWorks Stacks. For more information, see the
            /// Layer Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Shortname { get; set; }

            /// <summary>
            /// StackId
            /// The layer stack ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// Tags
            /// Specifies one or more sets of tags (key–value pairs) to associate with this AWS OpsWorks layer. Use
            /// tags to manage your resources.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The layer type. A stack cannot have more than one built-in layer of the same type. It can have any
            /// number of custom layers. Built-in layers are not available in Chef 12 stacks.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: aws-flow-ruby | custom | db-master | ecs-cluster | java-app | lb | memcached |
            /// monitoring-master | nodejs-app | php-app | rails-app | web
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// UseEbsOptimizedInstances
            /// Whether to use Amazon EBS-optimized instances.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> UseEbsOptimizedInstances { get; set; }

            /// <summary>
            /// VolumeConfigurations
            /// A VolumeConfigurations object that describes the layer&#39;s Amazon EBS volumes.
            /// Required: No
            /// Type: List of VolumeConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<VolumeConfiguration> VolumeConfigurations { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::Layer";

        public LayerProperties Properties { get; } = new LayerProperties();

    }
}
