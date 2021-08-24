using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html
    /// </summary>
    public class DatasetResource : ResourceBase
    {
        public class DatasetProperties
        {
            /// <summary>
            /// Name
            /// The unique name of the dataset.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Format
            /// The file format of a dataset that is created from an Amazon S3 file or folder.
            /// Required: No
            /// Type: String
            /// Allowed values: CSV | EXCEL | JSON | PARQUET
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Format { get; set; }

            /// <summary>
            /// FormatOptions
            /// A set of options that define how DataBrew interprets the data in the dataset.
            /// Required: No
            /// Type: FormatOptions
            /// Update requires: No interruption
            /// </summary>
            public FormatOptions FormatOptions { get; set; }

            /// <summary>
            /// Input
            /// Information on how DataBrew can find the dataset, in either the AWS Glue Data Catalog or Amazon S3.
            /// Required: Yes
            /// Type: Input
            /// Update requires: No interruption
            /// </summary>
            public Input Input { get; set; }

            /// <summary>
            /// PathOptions
            /// A set of options that defines how DataBrew interprets an Amazon S3 path of the dataset.
            /// Required: No
            /// Type: PathOptions
            /// Update requires: No interruption
            /// </summary>
            public PathOptions PathOptions { get; set; }

            /// <summary>
            /// Tags
            /// Metadata tags that have been applied to the dataset.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataBrew::Dataset";

        public DatasetProperties Properties { get; } = new DatasetProperties();

    }
}
