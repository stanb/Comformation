using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS Glue Job JobCommand
    /// The JobCommand property type specifies code that executes an AWS Glue job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-jobcommand.html
    /// </summary>
    public class JobCommand
    {

        /// <summary>
        /// ScriptLocation
        /// The location of a script that executes a job.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScriptLocation")]
        public Union<string, IntrinsicFunction> ScriptLocation { get; set; }

        /// <summary>
        /// Name
        /// The name of the job command.
        /// Required: Yes
        /// Type: String
        /// Valid values: glueetl
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
