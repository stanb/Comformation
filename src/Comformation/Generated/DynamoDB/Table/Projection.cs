using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table Projection
    /// Represents attributes that are copied (projected) from the table into an index. These are in addition to the
    /// primary key attributes and index key attributes, which are automatically projected.
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
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NonKeyAttributes")]
        public List<Union<string, IntrinsicFunction>> NonKeyAttributes { get; set; }

        /// <summary>
        /// ProjectionType
        /// The set of attributes that are projected into the index:
        /// KEYS_ONLY - Only the index and primary keys are projected into the index. INCLUDE - Only the
        /// specified table attributes are projected into the index. The list of projected attributes is in
        /// NonKeyAttributes. ALL - All of the table attributes are projected into the index.
        /// Required: No
        /// Type: String
        /// Allowed Values: ALL | INCLUDE | KEYS_ONLY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProjectionType")]
        public Union<string, IntrinsicFunction> ProjectionType { get; set; }

    }
}
