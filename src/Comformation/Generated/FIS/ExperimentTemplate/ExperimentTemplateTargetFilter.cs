using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FIS.ExperimentTemplate
{
    /// <summary>
    /// AWS::FIS::ExperimentTemplate ExperimentTemplateTargetFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetargetfilter.html
    /// </summary>
    public class ExperimentTemplateTargetFilter
    {

        /// <summary>
        /// Path
        /// The attribute path for the filter.
        /// Required: Yes
        /// Type: String
        /// Maximum: 256
        /// Pattern: [\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Values
        /// The attribute values for the filter.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
