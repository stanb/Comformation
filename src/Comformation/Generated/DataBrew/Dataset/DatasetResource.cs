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
            /// FormatOptions
            /// Options that define how DataBrew interprets the data in the dataset.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> FormatOptions { get; set; }

            /// <summary>
            /// Input
            /// Information on how DataBrew can find the dataset, in either the AWS Glue Data Catalog or Amazon S3.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Input { get; set; }

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
