using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table ProvisionedThroughput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-provisionedthroughput.html
    /// </summary>
    public class ProvisionedThroughput
    {

        /// <summary>
        /// ReadCapacityUnits
        /// The amount of read capacity that&#39;s provisioned for the table. For more information, see Read/Write
        /// Capacity Mode in the Amazon Keyspaces Developer Guide.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadCapacityUnits")]
        public Union<int, IntrinsicFunction> ReadCapacityUnits { get; set; }

        /// <summary>
        /// WriteCapacityUnits
        /// The amount of write capacity that&#39;s provisioned for the table. For more information, see Read/Write
        /// Capacity Mode in the Amazon Keyspaces Developer Guide.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriteCapacityUnits")]
        public Union<int, IntrinsicFunction> WriteCapacityUnits { get; set; }

    }
}
