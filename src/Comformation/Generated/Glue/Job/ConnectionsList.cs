using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS::Glue::Job ConnectionsList
    /// Specifies the connections used by a job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-connectionslist.html
    /// </summary>
    public class ConnectionsList
    {

        /// <summary>
        /// Connections
        /// A list of connections used by the job.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Connections")]
        public List<Union<string, IntrinsicFunction>> Connections { get; set; }

    }
}
