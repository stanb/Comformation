using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset FilesLimit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html
    /// </summary>
    public class FilesLimit
    {

        /// <summary>
        /// MaxFiles
        /// The number of Amazon S3 files to select.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxFiles")]
        public Union<int, IntrinsicFunction> MaxFiles { get; set; }

        /// <summary>
        /// OrderedBy
        /// A criteria to use for Amazon S3 files sorting before their selection. By default uses
        /// LAST_MODIFIED_DATE as a sorting criteria. Currently it&#39;s the only allowed value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrderedBy")]
        public Union<string, IntrinsicFunction> OrderedBy { get; set; }

        /// <summary>
        /// Order
        /// A criteria to use for Amazon S3 files sorting before their selection. By default uses DESCENDING
        /// order, i. e. most recent files are selected first. Anotherpossible value is ASCENDING.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Order")]
        public Union<string, IntrinsicFunction> Order { get; set; }

    }
}
