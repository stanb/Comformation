using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource AclConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-aclconfiguration.html
    /// </summary>
    public class AclConfiguration
    {

        /// <summary>
        /// AllowedGroupsColumnName
        /// A list of groups, separated by semi-colons, that filters a query response based on user context. The
        /// document is only returned to users that are in one of the groups specified in the UserContext field
        /// of the Query operation.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedGroupsColumnName")]
        public Union<string, IntrinsicFunction> AllowedGroupsColumnName { get; set; }

    }
}
