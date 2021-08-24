using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable PointInTimeRecoverySpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-pointintimerecoveryspecification.html
    /// </summary>
    public class PointInTimeRecoverySpecification
    {

        /// <summary>
        /// PointInTimeRecoveryEnabled
        /// Indicates whether point in time recovery is enabled (true) or disabled (false) on the table.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PointInTimeRecoveryEnabled")]
        public Union<bool, IntrinsicFunction> PointInTimeRecoveryEnabled { get; set; }

    }
}
