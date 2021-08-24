using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ContainerRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ContainerRecipe EbsInstanceBlockDeviceSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html
    /// </summary>
    public class EbsInstanceBlockDeviceSpecification
    {

        /// <summary>
        /// Encrypted
        /// 		
        /// Use to configure device encryption.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Encrypted")]
        public Union<bool, IntrinsicFunction> Encrypted { get; set; }

        /// <summary>
        /// DeleteOnTermination
        /// 		
        /// Use to configure delete on termination of the associated device.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeleteOnTermination")]
        public Union<bool, IntrinsicFunction> DeleteOnTermination { get; set; }

        /// <summary>
        /// Iops
        /// 		
        /// Use to configure device IOPS.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 100
        /// Maximum: 10000
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Iops")]
        public Union<int, IntrinsicFunction> Iops { get; set; }

        /// <summary>
        /// KmsKeyId
        /// 		
        /// Use to configure the KMS key to use when encrypting the device.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// SnapshotId
        /// 		
        /// The snapshot that defines the device contents.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SnapshotId")]
        public Union<string, IntrinsicFunction> SnapshotId { get; set; }

        /// <summary>
        /// VolumeSize
        /// 		
        /// Use to override the device&#39;s volume size.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 16000
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeSize")]
        public Union<int, IntrinsicFunction> VolumeSize { get; set; }

        /// <summary>
        /// VolumeType
        /// 		
        /// Use to override the device&#39;s volume type.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: gp2 | gp3 | io1 | io2 | sc1 | st1 | standard
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumeType")]
        public Union<string, IntrinsicFunction> VolumeType { get; set; }

    }
}
