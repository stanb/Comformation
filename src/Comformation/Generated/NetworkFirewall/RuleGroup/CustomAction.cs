using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup CustomAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-customaction.html
    /// </summary>
    public class CustomAction
    {

        /// <summary>
        /// ActionName
        /// The descriptive name of the custom action. You can&#39;t change the name of a custom action after you
        /// create it.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z0-9]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionName")]
        public Union<string, IntrinsicFunction> ActionName { get; set; }

        /// <summary>
        /// ActionDefinition
        /// The custom action associated with the action name.
        /// Required: Yes
        /// Type: ActionDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionDefinition")]
        public ActionDefinition ActionDefinition { get; set; }

    }
}
