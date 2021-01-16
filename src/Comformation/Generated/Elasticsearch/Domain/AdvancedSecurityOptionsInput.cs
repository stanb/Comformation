using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain AdvancedSecurityOptionsInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-advancedsecurityoptionsinput.html
    /// </summary>
    public class AdvancedSecurityOptionsInput
    {

        /// <summary>
        /// Enabled
        /// True to enable fine-grained access control.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// InternalUserDatabaseEnabled
        /// True to enable the internal user database.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InternalUserDatabaseEnabled")]
        public Union<bool, IntrinsicFunction> InternalUserDatabaseEnabled { get; set; }

        /// <summary>
        /// MasterUserOptions
        /// Specifies information about the master user.
        /// Required: No
        /// Type: MasterUserOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterUserOptions")]
        public MasterUserOptions MasterUserOptions { get; set; }

    }
}
