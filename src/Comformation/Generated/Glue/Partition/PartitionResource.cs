using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition
    /// The AWS::Glue::Partition resource creates an AWS Glue partition, which represents a slice of table data. For
    /// more information, see CreatePartition Action and Partition Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-partition.html
    /// </summary>
    public class PartitionResource : ResourceBase
    {
        public class PartitionProperties
        {
            /// <summary>
            /// TableName
            /// The name of the metadata table to create the partition in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the catalog database to create the partition in. It must match the single-line string
            /// pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// CatalogId
            /// The ID of the data catalog to create the catalog object in. Currently, this should be the AWS
            /// account ID.
            /// Note To specify the account ID, you can use the Ref intrinsic function with the AWS::AccountId
            /// pseudo parameter—for example !Ref AWS::AccountId.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

            /// <summary>
            /// PartitionInput
            /// The metadata of the partition.
            /// Required: Yes
            /// Type: PartitionInput
            /// Update requires: Some interruptions
            /// </summary>
			public PartitionInput PartitionInput { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Partition";

        public PartitionProperties Properties { get; } = new PartitionProperties();

    }
}
