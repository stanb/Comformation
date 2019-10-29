using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Job
{
    /// <summary>
    /// AWS::Glue::Job JobCommand
    /// Specifies code executed when a job is run.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-job-jobcommand.html
    /// </summary>
    public class JobCommand
    {

        /// <summary>
        /// PythonVersion
        /// The Python version being used to execute a Python shell job. Allowed values are 2 or 3.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PythonVersion")]
        public Union<string, IntrinsicFunction> PythonVersion { get; set; }

        /// <summary>
        /// ScriptLocation
        /// Specifies the Amazon Simple Storage Service (Amazon S3) path to a script that executes a job
        /// (required).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScriptLocation")]
        public Union<string, IntrinsicFunction> ScriptLocation { get; set; }

        /// <summary>
        /// Name
        /// The name of the job command. For an Apache Spark ETL job, this must be glueetl. For a Python shell
        /// job, it must be pythonshell.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
