using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Job
{
    /// <summary>
    /// AWS::DataBrew::Job OutputFormatOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputformatoptions.html
    /// </summary>
    public class OutputFormatOptions
    {

        /// <summary>
        /// Csv
        /// Represents a set of options that define the structure of comma-separated value (CSV) job output.
        /// Required: No
        /// Type: CsvOutputOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Csv")]
        public CsvOutputOptions Csv { get; set; }

    }
}
