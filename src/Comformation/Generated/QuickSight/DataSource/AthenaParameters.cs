using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource AthenaParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-athenaparameters.html
    /// </summary>
    public class AthenaParameters
    {

        /// <summary>
        /// WorkGroup
        /// The workgroup that Amazon Athena uses.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WorkGroup")]
        public Union<string, IntrinsicFunction> WorkGroup { get; set; }

    }
}
