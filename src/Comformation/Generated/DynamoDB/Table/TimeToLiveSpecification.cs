using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table TimeToLiveSpecification
    /// The TimeToLiveSpecification property specifies the Time to Live (TTL) settings for an AWS::DynamoDB::Table
    /// resource. It is expressed as an attribute on the items in the table. For more information, see
    /// UpdateTimeToLive in the Amazon DynamoDB API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-timetolivespecification.html
    /// </summary>
    public class TimeToLiveSpecification
    {

        /// <summary>
        /// AttributeName
        /// The name of the TTL attribute that stores the expiration time for items in the table. The name can
        /// be 1–255 characters long, and has no character restrictions.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// Enabled
        /// Indicates whether to enable (by specifying true) or disable (by specifying false) TTL on the table.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
