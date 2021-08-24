using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.AppImageConfig
{
    /// <summary>
    /// AWS::SageMaker::AppImageConfig KernelGatewayImageConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelgatewayimageconfig.html
    /// </summary>
    public class KernelGatewayImageConfig
    {

        /// <summary>
        /// FileSystemConfig
        /// The Amazon Elastic File System (EFS) storage configuration for a SageMaker image.
        /// Required: No
        /// Type: FileSystemConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileSystemConfig")]
        public FileSystemConfig FileSystemConfig { get; set; }

        /// <summary>
        /// KernelSpecs
        /// The specification of the Jupyter kernels in the image.
        /// Required: Yes
        /// Type: List of KernelSpec
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KernelSpecs")]
        public List<KernelSpec> KernelSpecs { get; set; }

    }
}
