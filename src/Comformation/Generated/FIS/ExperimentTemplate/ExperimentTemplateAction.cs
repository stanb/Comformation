using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FIS.ExperimentTemplate
{
    /// <summary>
    /// AWS::FIS::ExperimentTemplate ExperimentTemplateAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html
    /// </summary>
    public class ExperimentTemplateAction
    {

        /// <summary>
        /// ActionId
        /// The ID of the action. The format of the action ID is: aws:service-name:action-type.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Pattern: [\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionId")]
        public Union<string, IntrinsicFunction> ActionId { get; set; }

        /// <summary>
        /// Description
        /// A description for the action.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: [\s\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Parameters
        /// The parameters for the action, if applicable.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

        /// <summary>
        /// Targets
        /// The targets for the action.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Targets")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Targets { get; set; }

        /// <summary>
        /// StartAfter
        /// The name of the action that must be completed before the current action starts. Omit this parameter
        /// to run the action at the start of the experiment.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartAfter")]
        public List<Union<string, IntrinsicFunction>> StartAfter { get; set; }

    }
}
