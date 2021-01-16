using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis AlternatePathHint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-alternatepathhint.html
    /// </summary>
    public class AlternatePathHint
    {

        /// <summary>
        /// ComponentId
        /// The ID of the component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentId")]
        public Union<string, IntrinsicFunction> ComponentId { get; set; }

        /// <summary>
        /// ComponentArn
        /// The Amazon Resource Name (ARN) of the component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentArn")]
        public Union<string, IntrinsicFunction> ComponentArn { get; set; }

    }
}
