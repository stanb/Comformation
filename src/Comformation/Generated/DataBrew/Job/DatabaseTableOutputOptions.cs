using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job DatabaseTableOutputOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databasetableoutputoptions.html
    /// </summary>
    public class DatabaseTableOutputOptions
    {

        /// <summary>
        /// TempDirectory
        /// Represents an Amazon S3 location (bucket name and object key) where DataBrew can store intermediate
        /// results.
        /// Required: No
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TempDirectory")]
        public S3Location TempDirectory { get; set; }

        /// <summary>
        /// TableName
        /// A prefix for the name of a table DataBrew will create in the database.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

    }
}
