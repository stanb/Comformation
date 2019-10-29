using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table StreamSpecification
    /// Represents the DynamoDB Streams configuration for a table in DynamoDB.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-streamspecification.html
    /// </summary>
    public class StreamSpecification
    {

        /// <summary>
        /// StreamViewType
        /// When an item in the table is modified, StreamViewType determines what information is written to the
        /// stream for this table. Valid values for StreamViewType are:
        /// KEYS_ONLY - Only the key attributes of the modified item are written to the stream. NEW_IMAGE - The
        /// entire item, as it appears after it was modified, is written to the stream. OLD_IMAGE - The entire
        /// item, as it appeared before it was modified, is written to the stream. NEW_AND_OLD_IMAGES - Both the
        /// new and the old item images of the item are written to the stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamViewType")]
        public Union<string, IntrinsicFunction> StreamViewType { get; set; }

    }
}
