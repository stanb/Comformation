using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.Group
{
    /// <summary>
    /// AWS::Greengrass::Group GroupVersion
    /// A group version in AWS IoT Greengrass, 		 which references of a core definition version, device definition
    /// version, subscription definition version, and other version types 				 that contain the components you want to
    /// deploy to a Greengrass core device. 		The group version must reference a core definition version that contains
    /// one core. 		Other version types are optionally included, depending on your business need.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html
    /// </summary>
    public class GroupVersion
    {

        /// <summary>
        /// LoggerDefinitionVersionArn
        /// The ARN of the logger definition version that contains the loggers you want to deploy with the group
        /// version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LoggerDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> LoggerDefinitionVersionArn { get; set; }

        /// <summary>
        /// DeviceDefinitionVersionArn
        /// The ARN of the device definition version that contains the devices you want to deploy with the group
        /// version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeviceDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> DeviceDefinitionVersionArn { get; set; }

        /// <summary>
        /// FunctionDefinitionVersionArn
        /// The ARN of the function definition version that contains the functions you want to deploy with the
        /// group version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FunctionDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> FunctionDefinitionVersionArn { get; set; }

        /// <summary>
        /// CoreDefinitionVersionArn
        /// The ARN of the core definition version that contains the core you want to deploy with the group
        /// version. 				 Currently, the core definition version can contain only one core.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CoreDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> CoreDefinitionVersionArn { get; set; }

        /// <summary>
        /// ResourceDefinitionVersionArn
        /// The ARN of the resource definition version that contains the resources you want to deploy with the
        /// group version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ResourceDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> ResourceDefinitionVersionArn { get; set; }

        /// <summary>
        /// ConnectorDefinitionVersionArn
        /// The Amazon Resource Name (ARN) of the connector definition version that contains the connectors you
        /// want to deploy with the group version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConnectorDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> ConnectorDefinitionVersionArn { get; set; }

        /// <summary>
        /// SubscriptionDefinitionVersionArn
        /// The ARN of the subscription definition version that contains the subscriptions you want to deploy
        /// with the group version.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubscriptionDefinitionVersionArn")]
        public Union<string, IntrinsicFunction> SubscriptionDefinitionVersionArn { get; set; }

    }
}
