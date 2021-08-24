using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration SalesforceSourceProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-salesforcesourceproperties.html
    /// </summary>
    public class SalesforceSourceProperties
    {

        /// <summary>
        /// Object
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

        /// <summary>
        /// EnableDynamicFieldUpdate
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableDynamicFieldUpdate")]
        public Union<bool, IntrinsicFunction> EnableDynamicFieldUpdate { get; set; }

        /// <summary>
        /// IncludeDeletedRecords
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeDeletedRecords")]
        public Union<bool, IntrinsicFunction> IncludeDeletedRecords { get; set; }

    }
}
