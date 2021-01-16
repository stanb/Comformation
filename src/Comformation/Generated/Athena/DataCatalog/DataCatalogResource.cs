using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.DataCatalog
{
    /// <summary>
    /// AWS::Athena::DataCatalog
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-datacatalog.html
    /// </summary>
    public class DataCatalogResource : ResourceBase
    {
        public class DataCatalogProperties
        {
            /// <summary>
            /// Name
            /// The name of the data catalog. The catalog name must be unique for the AWS account and can use a
            /// maximum of 128 alphanumeric, underscore, at sign, or hyphen characters.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// A description of the data catalog.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Parameters
            /// Specifies the Lambda function or functions to use for the data catalog. The mapping used depends on
            /// the catalog type.
            /// The HIVE data catalog type uses the following syntax. The metadata-function parameter is required.
            /// The sdk-version parameter is optional and defaults to the currently supported version.
            /// metadata-function=lambda_arn, sdk-version=version_number The LAMBDA data catalog type uses one of
            /// the following sets of required parameters, but not both. When one Lambda function processes metadata
            /// and another Lambda function reads data, the following syntax is used. Both parameters are required.
            /// metadata-function=lambda_arn, record-function=lambda_arn A composite Lambda function that processes
            /// both metadata and data uses the following syntax. function=lambda_arn The GLUE type has no
            /// parameters.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// An optional list of comma separated tags (key-value pairs) that are custom attributes for the data
            /// catalog.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of data catalog: LAMBDA for a federated catalog, GLUE for AWS Glue Catalog, or HIVE for an
            /// external hive metastore.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::Athena::DataCatalog";

        public DataCatalogProperties Properties { get; } = new DataCatalogProperties();

    }
}
