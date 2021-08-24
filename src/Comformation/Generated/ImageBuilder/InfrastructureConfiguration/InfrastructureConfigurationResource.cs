using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.InfrastructureConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::InfrastructureConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-infrastructureconfiguration.html
    /// </summary>
    public class InfrastructureConfigurationResource : ResourceBase
    {
        public class InfrastructureConfigurationProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the infrastructure configuration.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// InstanceTypes
            /// 		
            /// The instance types of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> InstanceTypes { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// 		
            /// The security group IDs of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// Logging
            /// 		
            /// The logging configuration defines where Image Builder uploads your logs.
            /// 	
            /// Required: No
            /// Type: Logging
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Logging { get; set; }

            /// <summary>
            /// SubnetId
            /// 		
            /// The subnet ID of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// KeyPair
            /// 		
            /// The Amazon EC2 key pair of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KeyPair { get; set; }

            /// <summary>
            /// TerminateInstanceOnFailure
            /// 		
            /// The terminate instance on failure configuration of the infrastructure 			configuration.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> TerminateInstanceOnFailure { get; set; }

            /// <summary>
            /// InstanceProfileName
            /// 		
            /// The instance profile of the infrastructure configuration.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[\w+=,. @-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceProfileName { get; set; }

            /// <summary>
            /// SnsTopicArn
            /// 		
            /// The Amazon Resource Name (ARN) of the SNS topic for the infrastructure 			configuration.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

            /// <summary>
            /// ResourceTags
            /// 		
            /// The tags attached to the resource created by Image Builder.
            /// 	
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> ResourceTags { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The tags of the infrastructure configuration.
            /// 	
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::InfrastructureConfiguration";

        public InfrastructureConfigurationProperties Properties { get; } = new InfrastructureConfigurationProperties();

    }

    public static class InfrastructureConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
