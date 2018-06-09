using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table StreamSpecification
    /// StreamSpecification is a property of the AWS::DynamoDB::Table resource that defines the settings of a DynamoDB
    /// table&#39;s stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-streamspecification.html
    /// </summary>
    public class StreamSpecification
    {

        /// <summary>
        /// StreamViewType
        /// Determines the information that the stream captures when an item in the table is modified. For valid
        /// values, see StreamSpecification in the Amazon DynamoDB API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StreamViewType")]
        public Union<string, IntrinsicFunction> StreamViewType { get; set; }

    }
}
