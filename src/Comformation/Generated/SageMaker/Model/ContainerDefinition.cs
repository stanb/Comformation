using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model ContainerDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html
    /// </summary>
    public class ContainerDefinition
    {

        /// <summary>
        /// ImageConfig
        /// Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from
        /// your Amazon Virtual Private Cloud (VPC). For information about storing containers in a private
        /// Docker registry, see Use a Private Docker Registry for Real-Time Inference Containers
        /// Required: No
        /// Type: ImageConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageConfig")]
        public ImageConfig ImageConfig { get; set; }

        /// <summary>
        /// ContainerHostname
        /// This parameter is ignored for models that contain only a PrimaryContainer.
        /// When a ContainerDefinition is part of an inference pipeline, the value of the parameter uniquely
        /// identifies the container for the purposes of logging and metrics. For information, see Use Logs and
        /// Metrics to Monitor an Inference Pipeline. If you don&#39;t specify a value for this parameter for a
        /// ContainerDefinition that is part of an inference pipeline, a unique name is automatically assigned
        /// based on the position of the ContainerDefinition in the pipeline. If you specify a value for the
        /// ContainerHostName for any ContainerDefinition that is part of an inference pipeline, you must
        /// specify a value for the ContainerHostName parameter of every ContainerDefinition in that pipeline.
        /// Required: No
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerHostname")]
        public Union<string, IntrinsicFunction> ContainerHostname { get; set; }

        /// <summary>
        /// ModelPackageName
        /// The name or Amazon Resource Name (ARN) of the model package to use to create the model.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 176
        /// Pattern:
        /// (arn:aws[a-z\-]*:sagemaker:[a-z0-9\-]*:[0-9]{12}:[a-z\-]*\/)?([a-zA-Z0-9]([a-zA-Z0-9-]){0,62})(?&amp;lt;!-)(\/[0-9]{1,5})?$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelPackageName")]
        public Union<string, IntrinsicFunction> ModelPackageName { get; set; }

        /// <summary>
        /// Mode
        /// Whether the container hosts a single model or multiple models.
        /// Required: No
        /// Type: String
        /// Allowed values: MultiModel | SingleModel
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

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
        /// Note The model artifacts must be in an S3 bucket that is in the same region as the model or endpoint
        /// you are creating.
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
        /// The path where inference code is stored. This can be either in Amazon EC2 Container Registry or in a
        /// Docker registry that is accessible from the same VPC that you configure for your endpoint. If you
        /// are using your own custom algorithm instead of an algorithm provided by Amazon SageMaker, the
        /// inference code must meet Amazon SageMaker requirements. Amazon SageMaker supports both
        /// registry/repository[:tag] and registry/repository[@digest] image path formats. For more information,
        /// see Using Your Own Algorithms with Amazon SageMaker
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Pattern: [\S]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// MultiModelConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: MultiModelConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MultiModelConfig")]
        public MultiModelConfig MultiModelConfig { get; set; }

    }
}
