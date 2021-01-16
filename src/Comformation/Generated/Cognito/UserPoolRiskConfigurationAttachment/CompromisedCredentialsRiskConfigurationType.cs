using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment CompromisedCredentialsRiskConfigurationType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-compromisedcredentialsriskconfigurationtype.html
    /// </summary>
    public class CompromisedCredentialsRiskConfigurationType
    {

        /// <summary>
        /// Actions
        /// The compromised credentials risk configuration actions.
        /// Required: Yes
        /// Type: CompromisedCredentialsActionsType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public CompromisedCredentialsActionsType Actions { get; set; }

        /// <summary>
        /// EventFilter
        /// Perform the action for these events. The default is to perform all events if no event filter is
        /// specified.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventFilter")]
        public List<Union<string, IntrinsicFunction>> EventFilter { get; set; }

    }
}
