using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition ModelExplainabilityAppSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification.html
    /// </summary>
    public class ModelExplainabilityAppSpecification
    {

        /// <summary>
        /// ImageUri
        /// The container image to be run by the model explainability job.
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
        /// JSON formatted S3 file that defines explainability parameters. For more information on this JSON
        /// configuration file, see Configure model explainability parameters.
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
