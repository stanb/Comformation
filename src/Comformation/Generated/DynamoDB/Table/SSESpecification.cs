using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// DynamoDB SSESpecification
    /// The SSESpecification property is part of the AWS::DynamoDB::Table resource that specifies the settings to
    /// enable server-side encryption.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// SSEEnabled
        /// Whether server-side encryption is enabled or not.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

    }
}
