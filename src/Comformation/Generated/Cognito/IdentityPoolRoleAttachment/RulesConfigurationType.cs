using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPoolRoleAttachment
{
    /// <summary>
    /// Amazon Cognito IdentityPoolRoleAttachment RoleMapping RulesConfiguration
    /// RulesConfiguration is a subproperty of the AWS::Cognito::IdentityPoolRoleAttachment property that defines the
    /// rules to be used for mapping users to roles.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypoolroleattachment-rolemapping-rulesconfiguration.html
    /// </summary>
    public class RulesConfigurationType
    {

        /// <summary>
        /// Rules
        /// A list of rules. You can specify up to 25 rules per identity provider.
        /// Required: Yes
        /// Type: List of Amazon Cognito IdentityPoolRoleAttachment MappingRule
        /// </summary>
        [JsonProperty("Rules")]
        public Union<List<MappingRule>, IntrinsicFunction> Rules { get; set; }

    }
}
