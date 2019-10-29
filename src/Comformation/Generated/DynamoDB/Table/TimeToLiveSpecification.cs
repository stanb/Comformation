using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table TimeToLiveSpecification
    /// Represents the settings used to enable or disable Time to Live (TTL) for the specified table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-timetolivespecification.html
    /// </summary>
    public class TimeToLiveSpecification
    {

        /// <summary>
        /// AttributeName
        /// The name of the TTL attribute used to store the expiration time for items in the table.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
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
