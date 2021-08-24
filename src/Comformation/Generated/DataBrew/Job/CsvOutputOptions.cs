using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job CsvOutputOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-csvoutputoptions.html
    /// </summary>
    public class CsvOutputOptions
    {

        /// <summary>
        /// Delimiter
        /// A single character that specifies the delimiter used to create CSV job output.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

    }
}
