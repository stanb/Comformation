using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FIS.ExperimentTemplate
{
    /// <summary>
    /// AWS::FIS::ExperimentTemplate ExperimentTemplateTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html
    /// </summary>
    public class ExperimentTemplateTarget
    {

        /// <summary>
        /// ResourceType
        /// The AWS resource type. The resource type must be supported for the specified action.
        /// Required: Yes
        /// Type: String
        /// Maximum: 64
        /// Pattern: [\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceType")]
        public Union<string, IntrinsicFunction> ResourceType { get; set; }

        /// <summary>
        /// ResourceArns
        /// The Amazon Resource Names (ARNs) of the resources.
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceArns")]
        public List<Union<string, IntrinsicFunction>> ResourceArns { get; set; }

        /// <summary>
        /// ResourceTags
        /// The tags for the target resources.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ResourceTags { get; set; }

        /// <summary>
        /// Filters
        /// The filters to apply to identify target resources using specific attributes.
        /// Required: No
        /// Type: List of ExperimentTemplateTargetFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filters")]
        public List<ExperimentTemplateTargetFilter> Filters { get; set; }

        /// <summary>
        /// SelectionMode
        /// Scopes the identified resources to a specific count of the resources at random, or a percentage of
        /// the resources. All identified resources are included in the target.
        /// ALL - Run the action on all identified targets. This is the default. COUNT(n) - Run the action on
        /// the specified number of targets, chosen from the identified targets at random. For example, COUNT(1)
        /// selects one of the targets. PERCENT(n) - Run the action on the specified percentage of targets,
        /// chosen from the identified targets at random. For example, PERCENT(25) selects 25% of the targets.
        /// Required: Yes
        /// Type: String
        /// Maximum: 64
        /// Pattern: [\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectionMode")]
        public Union<string, IntrinsicFunction> SelectionMode { get; set; }

    }
}
