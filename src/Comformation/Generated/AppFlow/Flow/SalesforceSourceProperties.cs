using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow SalesforceSourceProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html
    /// </summary>
    public class SalesforceSourceProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Salesforce flow source.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

        /// <summary>
        /// EnableDynamicFieldUpdate
        /// The flag that enables dynamic fetching of new (recently added) fields in the Salesforce objects
        /// while running a flow.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableDynamicFieldUpdate")]
        public Union<bool, IntrinsicFunction> EnableDynamicFieldUpdate { get; set; }

        /// <summary>
        /// IncludeDeletedRecords
        /// Indicates whether Amazon AppFlow includes deleted files in the flow run.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeDeletedRecords")]
        public Union<bool, IntrinsicFunction> IncludeDeletedRecords { get; set; }

    }
}
