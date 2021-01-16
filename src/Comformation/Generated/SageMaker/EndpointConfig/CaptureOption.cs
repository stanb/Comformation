using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig CaptureOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-captureoption.html
    /// </summary>
    public class CaptureOption
    {

        /// <summary>
        /// CaptureMode
        /// Specifies whether the endpoint captures input data or output data.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Input | Output
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CaptureMode")]
        public Union<string, IntrinsicFunction> CaptureMode { get; set; }

    }
}
