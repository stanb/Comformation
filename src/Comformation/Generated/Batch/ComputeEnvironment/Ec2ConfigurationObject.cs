using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment Ec2ConfigurationObject
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ec2configurationobject.html
    /// </summary>
    public class Ec2ConfigurationObject
    {

        /// <summary>
        /// ImageIdOverride
        /// The AMI ID used for instances launched in the compute environment that match the image type. This
        /// setting overrides the imageId set in the computeResource object.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageIdOverride")]
        public Union<string, IntrinsicFunction> ImageIdOverride { get; set; }

        /// <summary>
        /// ImageType
        /// The image type to match with the instance type to select an AMI. If the imageIdOverride parameter
        /// isn&#39;t specified, then a recent Amazon ECS-optimized AMI is used.
        /// ECS_AL2 Amazon Linux 2− Default for all AWS Graviton-based instance families (for example, C6g, M6g,
        /// R6g, and T4g) and can be used for all non-GPU instance types. ECS_AL2_NVIDIA Amazon Linux 2
        /// (GPU)−Default for all GPU instance families (for example P4 and G4) and can be used for all non-AWS
        /// Graviton-based instance types. ECS_AL1 Amazon Linux−Default for all non-GPU, non-AWS Graviton
        /// instance families. Amazon Linux is reaching the end-of-life of standard support. For more
        /// information, see Amazon Linux AMI.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageType")]
        public Union<string, IntrinsicFunction> ImageType { get; set; }

    }
}
