using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// AWS::Cognito::IdentityPoolRoleAttachment RulesConfigurationType
    /// RulesConfigurationType is a subproperty of the RoleMapping property that defines the rules to be used for
    /// mapping users to roles.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rulesconfigurationtype.html
    /// </summary>
    public class RulesConfigurationType
    {

        /// <summary>
        /// Rules
        /// A list of rules. You can specify up to 25 rules per identity provider.
        /// Required: Yes
        /// Type: List of MappingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<MappingRule> Rules { get; set; }

    }
}
