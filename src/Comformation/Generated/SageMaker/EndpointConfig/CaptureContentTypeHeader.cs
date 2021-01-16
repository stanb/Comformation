using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig CaptureContentTypeHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig-capturecontenttypeheader.html
    /// </summary>
    public class CaptureContentTypeHeader
    {

        /// <summary>
        /// JsonContentTypes
        /// A list of the JSON content types of the data that the endpoint captures. For the endpoint to capture
        /// the data, you must also specify the content type when you invoke the endpoint.
        /// Required: No
        /// Type: List of String
        /// Maximum: 10
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("JsonContentTypes")]
        public List<Union<string, IntrinsicFunction>> JsonContentTypes { get; set; }

        /// <summary>
        /// CsvContentTypes
        /// A list of the CSV content types of the data that the endpoint captures. For the endpoint to capture
        /// the data, you must also specify the content type when you invoke the endpoint.
        /// Required: No
        /// Type: List of String
        /// Maximum: 10
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CsvContentTypes")]
        public List<Union<string, IntrinsicFunction>> CsvContentTypes { get; set; }

    }
}
