using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table BillingMode
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-billingmode.html
    /// </summary>
    public class BillingMode
    {

        /// <summary>
        /// Mode
        /// The billing mode for the table:
        /// On-demand mode - ON_DEMAND Provisioned mode - PROVISIONED Note If you choose PROVISIONED mode, then
        /// you also need to specify provisioned throughput (read and write capacity) for the table.
        /// Valid values: ON_DEMAND | PROVISIONED
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// ProvisionedThroughput
        /// The provisioned read capacity and write capacity for the table. For more information, see
        /// Provisioned Throughput Capacity Mode in the Amazon Keyspaces Developer Guide.
        /// Required: No
        /// Type: ProvisionedThroughput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProvisionedThroughput")]
        public ProvisionedThroughput ProvisionedThroughput { get; set; }

    }
}
