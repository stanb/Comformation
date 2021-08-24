using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet IngestionWaitPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-ingestionwaitpolicy.html
    /// </summary>
    public class IngestionWaitPolicy
    {

        /// <summary>
        /// WaitForSpiceIngestion
        /// Wait for SPICE ingestion to finish to mark dataset creation or update as successful. Default (true).
        /// Applicable only when DataSetImportMode mode is set to SPICE.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitForSpiceIngestion")]
        public Union<bool, IntrinsicFunction> WaitForSpiceIngestion { get; set; }

        /// <summary>
        /// IngestionWaitTimeInHours
        /// The maximum time (in hours) to wait for Ingestion to complete. Default timeout is 36 hours.
        /// Applicable only when DataSetImportMode mode is set to SPICE and WaitForSpiceIngestion is set to
        /// true.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IngestionWaitTimeInHours")]
        public Union<double, IntrinsicFunction> IngestionWaitTimeInHours { get; set; }

    }
}
