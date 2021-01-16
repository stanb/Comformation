using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table Projection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-projectionobject.html
    /// </summary>
    public class Projection
    {

        /// <summary>
        /// NonKeyAttributes
        /// Represents the non-key attribute names which will be projected into the index.
        /// For local secondary indexes, the total count of NonKeyAttributes summed across all of the local
        /// secondary indexes, must not exceed 20. If you project the same attribute into two different indexes,
        /// this counts as two distinct attributes when determining the total.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NonKeyAttributes")]
        public List<Union<string, IntrinsicFunction>> NonKeyAttributes { get; set; }

        /// <summary>
        /// ProjectionType
        /// The set of attributes that are projected into the index:
        /// KEYS_ONLY - Only the index and primary keys are projected into the index. INCLUDE - In addition to
        /// the attributes described in KEYS_ONLY, the secondary index will include other non-key attributes
        /// that you specify. ALL - All of the table attributes are projected into the index.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProjectionType")]
        public Union<string, IntrinsicFunction> ProjectionType { get; set; }

    }
}
