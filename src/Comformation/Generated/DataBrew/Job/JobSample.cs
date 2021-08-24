using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job JobSample
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-jobsample.html
    /// </summary>
    public class JobSample
    {

        /// <summary>
        /// Mode
        /// A value that determines whether the profile job is run on the entire dataset or a specified number
        /// of rows. This value must be one of the following:
        /// FULL_DATASET - The profile job is run on the entire dataset. CUSTOM_ROWS - The profile job is run on
        /// the number of rows specified in the Size parameter.
        /// Required: No
        /// Type: String
        /// Allowed values: CUSTOM_ROWS | FULL_DATASET
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// Size
        /// The Size parameter is only required when the mode is CUSTOM_ROWS. The profile job is run on the
        /// specified number of rows. The maximum value for size is Long. MAX_VALUE.
        /// Long. MAX_VALUE = 9223372036854775807
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

    }
}
