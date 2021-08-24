using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet S3Source
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-s3source.html
    /// </summary>
    public class S3Source
    {

        /// <summary>
        /// DataSourceArn
        /// The Amazon Resource Name (ARN) for the data source.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataSourceArn")]
        public Union<string, IntrinsicFunction> DataSourceArn { get; set; }

        /// <summary>
        /// InputColumns
        /// A physical table type for an S3 data source.
        /// Note For non-JSON files, only STRING data types are supported in input columns.
        /// Required: Yes
        /// Type: List of InputColumn
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputColumns")]
        public List<InputColumn> InputColumns { get; set; }

        /// <summary>
        /// UploadSettings
        /// Information about the format for the S3 source file or files.
        /// Required: No
        /// Type: UploadSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UploadSettings")]
        public UploadSettings UploadSettings { get; set; }

    }
}
