using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset LateDataRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedatarule.html
    /// </summary>
    public class LateDataRule
    {

        /// <summary>
        /// RuleConfiguration
        /// The information needed to configure the late data rule.
        /// Required: Yes
        /// Type: LateDataRuleConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleConfiguration")]
        public LateDataRuleConfiguration RuleConfiguration { get; set; }

        /// <summary>
        /// RuleName
        /// The name of the late data rule.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z0-9_]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleName")]
        public Union<string, IntrinsicFunction> RuleName { get; set; }

    }
}
