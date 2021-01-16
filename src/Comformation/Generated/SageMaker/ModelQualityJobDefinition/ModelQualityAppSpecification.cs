using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelQualityJobDefinition ModelQualityAppSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html
    /// </summary>
    public class ModelQualityAppSpecification
    {

        /// <summary>
        /// ContainerArguments
        /// An array of arguments for the container used to run the monitoring job.
        /// Required: No
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerArguments")]
        public List<Union<string, IntrinsicFunction>> ContainerArguments { get; set; }

        /// <summary>
        /// ContainerEntrypoint
        /// Specifies the entrypoint for a container that the monitoring job runs.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerEntrypoint")]
        public List<Union<string, IntrinsicFunction>> ContainerEntrypoint { get; set; }

        /// <summary>
        /// ImageUri
        /// The address of the container image that the monitoring job runs.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageUri")]
        public Union<string, IntrinsicFunction> ImageUri { get; set; }

        /// <summary>
        /// PostAnalyticsProcessorSourceUri
        /// An Amazon S3 URI to a script that is called after analysis has been performed. Applicable only for
        /// the built-in (first party) containers.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PostAnalyticsProcessorSourceUri")]
        public Union<string, IntrinsicFunction> PostAnalyticsProcessorSourceUri { get; set; }

        /// <summary>
        /// RecordPreprocessorSourceUri
        /// An Amazon S3 URI to a script that is called per row prior to running analysis. It can base64 decode
        /// the payload and convert it into a flatted json so that the built-in container can use the converted
        /// data. Applicable only for the built-in (first party) containers.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RecordPreprocessorSourceUri")]
        public Union<string, IntrinsicFunction> RecordPreprocessorSourceUri { get; set; }

        /// <summary>
        /// ProblemType
        /// The machine learning problem type of the model that the monitoring job monitors.
        /// Required: Yes
        /// Type: String
        /// Allowed values: BinaryClassification | MulticlassClassification | Regression
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ProblemType")]
        public Union<string, IntrinsicFunction> ProblemType { get; set; }

    }
}
