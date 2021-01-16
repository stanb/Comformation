using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition ModelBiasAppSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasappspecification.html
    /// </summary>
    public class ModelBiasAppSpecification
    {

        /// <summary>
        /// ImageUri
        /// The container image to be run by the model bias job.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageUri")]
        public Union<string, IntrinsicFunction> ImageUri { get; set; }

        /// <summary>
        /// ConfigUri
        /// JSON formatted S3 file that defines bias parameters. For more information on this JSON configuration
        /// file, see Configure bias parameters.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConfigUri")]
        public Union<string, IntrinsicFunction> ConfigUri { get; set; }

    }
}
