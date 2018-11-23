using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// Amazon SageMaker Model ContainerDefinition
    /// The ContainerDefinition property type specifies the definition of the container for a model.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html
    /// </summary>
    public class ContainerDefinition
    {

        /// <summary>
        /// ContainerHostname
        /// The DNS host name for the container after Amazon SageMaker deploys it.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerHostname")]
        public Union<string, IntrinsicFunction> ContainerHostname { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to set in the Docker container. Each key and value in the Environment
        /// string to string map can have length of up to 1024. We support up to 16 entries in the map.
        /// Required: No
        /// Type: JSON object
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Environment")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Environment { get; set; }

        /// <summary>
        /// ModelDataUrl
        /// The S3 path where the model artifacts, which result from model training, are stored. This path must
        /// point to a single gzip compressed tar archive (. tar. gz suffix)
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelDataUrl")]
        public Union<string, IntrinsicFunction> ModelDataUrl { get; set; }

        /// <summary>
        /// Image
        /// The Amazon EC2 Container Registry (Amazon ECR) path where inference code is stored. If you are using
        /// your own custom algorithm instead of an algorithm provided by Amazon SageMaker, the inference code
        /// must meet Amazon SageMaker requirements. For more information, see Using Your Own Algorithms with
        /// Amazon SageMaker
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

    }
}
