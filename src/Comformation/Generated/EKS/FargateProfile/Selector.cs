using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.FargateProfile
{
    /// <summary>
    /// AWS::EKS::FargateProfile Selector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-fargateprofile-selector.html
    /// </summary>
    public class Selector
    {

        /// <summary>
        /// Namespace
        /// The Kubernetes namespace that the selector should match.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// Labels
        /// The Kubernetes labels that the selector should match. A pod must contain all of the labels that are
        /// specified in the selector for it to be considered a match.
        /// Required: No
        /// Type: List of Label
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Labels")]
        public List<Label> Labels { get; set; }

    }
}
