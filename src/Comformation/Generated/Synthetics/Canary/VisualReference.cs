using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary VisualReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-visualreference.html
    /// </summary>
    public class VisualReference
    {

        /// <summary>
        /// BaseCanaryRunId
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseCanaryRunId")]
        public Union<string, IntrinsicFunction> BaseCanaryRunId { get; set; }

        /// <summary>
        /// BaseScreenshots
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of BaseScreenshot
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseScreenshots")]
        public List<BaseScreenshot> BaseScreenshots { get; set; }

    }
}
