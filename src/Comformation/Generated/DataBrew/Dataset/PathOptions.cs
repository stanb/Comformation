using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset PathOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html
    /// </summary>
    public class PathOptions
    {

        /// <summary>
        /// FilesLimit
        /// If provided, this structure imposes a limit on a number of files that should be selected.
        /// Required: No
        /// Type: FilesLimit
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilesLimit")]
        public FilesLimit FilesLimit { get; set; }

        /// <summary>
        /// LastModifiedDateCondition
        /// If provided, this structure defines a date range for matching Amazon S3 objects based on their
        /// LastModifiedDate attribute in Amazon S3.
        /// Required: No
        /// Type: FilterExpression
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastModifiedDateCondition")]
        public FilterExpression LastModifiedDateCondition { get; set; }

        /// <summary>
        /// Parameters
        /// A structure that maps names of parameters used in the Amazon S3 path of a dataset to their
        /// definitions.
        /// Required: No
        /// Type: List of PathParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public List<PathParameter> Parameters { get; set; }

    }
}
