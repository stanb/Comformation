using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DataQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::DataQualityJobDefinition DataQualityAppSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html
    /// </summary>
    public class DataQualityAppSpecification
    {

        /// <summary>
        /// ContainerArguments
        /// The arguments to send to the container that the monitoring job runs.
        /// Required: No
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerArguments")]
        public List<Union<string, IntrinsicFunction>> ContainerArguments { get; set; }

        /// <summary>
        /// ContainerEntrypoint
        /// The entrypoint for a container used to run a monitoring job.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ContainerEntrypoint")]
        public List<Union<string, IntrinsicFunction>> ContainerEntrypoint { get; set; }

        /// <summary>
        /// ImageUri
        /// The container image that the data quality monitoring job runs.
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

    }
}
