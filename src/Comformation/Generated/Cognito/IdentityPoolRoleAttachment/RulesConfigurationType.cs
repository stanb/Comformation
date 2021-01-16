using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment RulesConfigurationType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rulesconfigurationtype.html
    /// </summary>
    public class RulesConfigurationType
    {

        /// <summary>
        /// Rules
        /// The rules. You can specify up to 25 rules per identity provider.
        /// Required: Yes
        /// Type: List of MappingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<MappingRule> Rules { get; set; }

    }
}
