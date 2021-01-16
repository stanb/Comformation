using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain MasterUserOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-masteruseroptions.html
    /// </summary>
    public class MasterUserOptions
    {

        /// <summary>
        /// MasterUserARN
        /// ARN for the master user. Only specify if InternalUserDatabaseEnabled is false in
        /// AdvancedSecurityOptions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterUserARN")]
        public Union<string, IntrinsicFunction> MasterUserARN { get; set; }

        /// <summary>
        /// MasterUserName
        /// Username for the master user. Only specify if InternalUserDatabaseEnabled is true in
        /// AdvancedSecurityOptions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterUserName")]
        public Union<string, IntrinsicFunction> MasterUserName { get; set; }

        /// <summary>
        /// MasterUserPassword
        /// Password for the master user. Only specify if InternalUserDatabaseEnabled is true in
        /// AdvancedSecurityOptions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterUserPassword")]
        public Union<string, IntrinsicFunction> MasterUserPassword { get; set; }

    }
}
