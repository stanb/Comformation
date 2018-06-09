using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS Glue Job ExecutionProperty
    /// The ExecutionProperty property type specifies the maximum number of concurrent runs allowed for an AWS Glue
    /// job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-executionproperty.html
    /// </summary>
    public class ExecutionProperty
    {

        /// <summary>
        /// MaxConcurrentRuns
        /// The maximum number of concurrent runs that are allowed for the job.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConcurrentRuns")]
        public Union<double, IntrinsicFunction> MaxConcurrentRuns { get; set; }

    }
}
