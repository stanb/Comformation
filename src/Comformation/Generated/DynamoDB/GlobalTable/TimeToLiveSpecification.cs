using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable TimeToLiveSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-timetolivespecification.html
    /// </summary>
    public class TimeToLiveSpecification
    {

        /// <summary>
        /// AttributeName
        /// The name of the attribute used to store the expiration time for items in the table.
        /// Currently, you cannot directly change the attribute name used to evaluate time to live. In order to
        /// do so, you must first disable time to live, and then re-enable it with the new attribute name. It
        /// can take up to one hour for changes to time to live to take effect. If you attempt to modify time to
        /// live within that time window, your stack operation might be delayed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// Enabled
        /// Indicates whether TTL is to be enabled (true) or disabled (false) on the table.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
