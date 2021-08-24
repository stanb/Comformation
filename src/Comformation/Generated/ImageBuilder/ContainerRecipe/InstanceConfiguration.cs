using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ContainerRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ContainerRecipe InstanceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceconfiguration.html
    /// </summary>
    public class InstanceConfiguration
    {

        /// <summary>
        /// Image
        /// 		
        /// The AMI ID to use as the base image for a container build and test instance. If not specified,
        /// 			Image Builder will use the appropriate ECS-optimized AMI as a base image.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// BlockDeviceMappings
        /// 		
        /// Defines the block devices to attach for building an instance from this Image Builder AMI.
        /// 	
        /// Required: No
        /// Type: List of InstanceBlockDeviceMapping
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BlockDeviceMappings")]
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings { get; set; }

    }
}
