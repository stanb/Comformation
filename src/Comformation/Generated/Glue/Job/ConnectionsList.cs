using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS Glue Job ConnectionsList
    /// The ConnectionsList property type specifies the connections that are used by an AWS Glue job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-connectionslist.html
    /// </summary>
    public class ConnectionsList
    {

        /// <summary>
        /// Connections
        /// A list of UTF-8 strings that specifies the connections that are used by the job.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Connections")]
        public List<Union<string, IntrinsicFunction>> Connections { get; set; }

    }
}
