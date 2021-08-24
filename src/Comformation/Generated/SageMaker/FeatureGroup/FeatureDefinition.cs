using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.FeatureGroup
{
    /// <summary>
    /// AWS::SageMaker::FeatureGroup FeatureDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-featuregroup-featuredefinition.html
    /// </summary>
    public class FeatureDefinition
    {

        /// <summary>
        /// FeatureName
        /// The name of a feature. The type must be a string. FeatureName cannot be any of the following:
        /// is_deleted, write_time, api_invocation_time.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[a-zA-Z0-9]([-_]*[a-zA-Z0-9]){0,63}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FeatureName")]
        public Union<string, IntrinsicFunction> FeatureName { get; set; }

        /// <summary>
        /// FeatureType
        /// The value type of a feature. Valid values are Integral, Fractional, or String.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Fractional | Integral | String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FeatureType")]
        public Union<string, IntrinsicFunction> FeatureType { get; set; }

    }
}
