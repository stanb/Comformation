using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model ContainerDefinition
    /// Describes the container, as part of model definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html
    /// </summary>
    public class ContainerDefinition
    {

        /// <summary>
        /// ContainerHostname
        /// This parameter is ignored for models that contain only a PrimaryContainer.
        /// When a ContainerDefinition is part of an inference pipeline, the value of ths parameter uniquely
        /// identifies the container for the purposes of logging and metrics. For information, see Use Logs and
        /// Metrics to Monitor an Inference Pipeline. If you don&#39;t specify a value for this parameter for a
        /// ContainerDefinition that is part of an inference pipeline, a unique name is automatically assigned
        /// based on the position of the ContainerDefinition in the pipeline. If you specify a value for the
        /// ContainerHostName for any ContainerDefinition that is part of an inference pipeline, you must
        /// specify a value for the ContainerHostName parameter of every ContainerDefinition in that pipeline.
        /// Required: No
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerHostname")]
        public Union<string, IntrinsicFunction> ContainerHostname { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to set in the Docker container. Each key and value in the Environment
        /// string to string map can have length of up to 1024. We support up to 16 entries in the map.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Environment")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Environment { get; set; }

        /// <summary>
        /// ModelDataUrl
        /// The S3 path where the model artifacts, which result from model training, are stored. This path must
        /// point to a single gzip compressed tar archive (. tar. gz suffix). The S3 path is required for Amazon
        /// SageMaker built-in algorithms, but not if you use your own algorithms. For more information on
        /// built-in algorithms, see Common Parameters.
        /// If you provide a value for this parameter, Amazon SageMaker uses AWS Security Token Service to
        /// download model artifacts from the S3 path you provide. AWS STS is activated in your IAM user account
        /// by default. If you previously deactivated AWS STS for a region, you need to reactivate AWS STS for
        /// that region. For more information, see Activating and Deactivating AWS STS in an AWS Region in the
        /// AWS Identity and Access Management User Guide.
        /// Important If you use a built-in algorithm to create a model, Amazon SageMaker requires that you
        /// provide a S3 path to the model artifacts in ModelDataUrl.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelDataUrl")]
        public Union<string, IntrinsicFunction> ModelDataUrl { get; set; }

        /// <summary>
        /// Image
        /// The Amazon EC2 Container Registry (Amazon ECR) path where inference code is stored. If you are using
        /// your own custom algorithm instead of an algorithm provided by Amazon SageMaker, the inference code
        /// must meet Amazon SageMaker requirements. Amazon SageMaker supports both registry/repository[:tag]
        /// and registry/repository[@digest] image path formats. For more information, see Using Your Own
        /// Algorithms with Amazon SageMaker
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Pattern: [\S]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

    }
}
