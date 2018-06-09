using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-timeout.html
    /// </summary>
    public class Timeout
    {

        /// <summary>
        /// AttemptDurationSeconds
        /// </summary>
        [JsonProperty("AttemptDurationSeconds")]
        public Union<int, IntrinsicFunction> AttemptDurationSeconds { get; set; }

    }
}
