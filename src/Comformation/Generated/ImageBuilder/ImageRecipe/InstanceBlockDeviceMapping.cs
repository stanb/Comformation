using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe InstanceBlockDeviceMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-instanceblockdevicemapping.html
    /// </summary>
    public class InstanceBlockDeviceMapping
    {

        /// <summary>
        /// DeviceName
        /// 		
        /// The device to which these mappings apply.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeviceName")]
        public Union<string, IntrinsicFunction> DeviceName { get; set; }

        /// <summary>
        /// VirtualName
        /// Manages the instance ephemeral devices.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VirtualName")]
        public Union<string, IntrinsicFunction> VirtualName { get; set; }

        /// <summary>
        /// NoDevice
        /// Enter an empty string to remove a mapping from the parent image.
        /// The following is an example of an empty string value in the NoDevice field.
        /// NoDevice:&quot;&quot;
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NoDevice")]
        public Union<string, IntrinsicFunction> NoDevice { get; set; }

        /// <summary>
        /// Ebs
        /// 		
        /// Use to manage Amazon EBS-specific configuration for this mapping.
        /// 	
        /// Required: No
        /// Type: EbsInstanceBlockDeviceSpecification
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ebs")]
        public EbsInstanceBlockDeviceSpecification Ebs { get; set; }

    }
}
