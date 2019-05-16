using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS::Glue::Job ExecutionProperty
    /// An execution property of a job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-executionproperty.html
    /// </summary>
    public class ExecutionProperty
    {

        /// <summary>
        /// MaxConcurrentRuns
        /// The maximum number of concurrent runs allowed for the job. The default is 1. An error is returned
        /// when this threshold is reached. The maximum value you can specify is controlled by a service limit.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConcurrentRuns")]
        public Union<double, IntrinsicFunction> MaxConcurrentRuns { get; set; }

    }
}
