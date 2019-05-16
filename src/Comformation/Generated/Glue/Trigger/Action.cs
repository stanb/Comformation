using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger Action
    /// Defines an action to be initiated by a trigger.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// JobName
        /// The name of a job to be executed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

        /// <summary>
        /// Arguments
        /// The job arguments used when this trigger fires. For this job run, they replace the default arguments
        /// set in the job definition itself.
        /// You can specify arguments here that your own job-execution script consumes, as well as arguments
        /// that AWS Glue itself consumes.
        /// For information about how to specify and consume your own Job arguments, see the Calling AWS Glue
        /// APIs in Python topic in the developer guide.
        /// For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special
        /// Parameters Used by AWS Glue topic in the developer guide.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arguments")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Arguments { get; set; }

    }
}
