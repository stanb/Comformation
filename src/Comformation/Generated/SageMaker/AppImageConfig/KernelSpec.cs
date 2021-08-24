using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.AppImageConfig
{
    /// <summary>
    /// AWS::SageMaker::AppImageConfig KernelSpec
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelspec.html
    /// </summary>
    public class KernelSpec
    {

        /// <summary>
        /// DisplayName
        /// The display name of the kernel.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisplayName")]
        public Union<string, IntrinsicFunction> DisplayName { get; set; }

        /// <summary>
        /// Name
        /// The name of the Jupyter kernel in the image. This value is case sensitive.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
