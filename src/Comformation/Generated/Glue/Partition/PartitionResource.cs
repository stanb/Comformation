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
            /// The name of the metadata table in which the partition is to be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the catalog database in which to create the partition.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// CatalogId
            /// The AWS account ID of the catalog in which the partion is to be created.
            /// Note To specify the account ID, you can use the Ref intrinsic function with the AWS::AccountId
            /// pseudo parameter. For example: !Ref AWS::AccountId
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

            /// <summary>
            /// PartitionInput
            /// The structure used to create and update a partition.
            /// Required: Yes
            /// Type: PartitionInput
            /// Update requires: No interruption
            /// </summary>
			public PartitionInput PartitionInput { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Partition";

        public PartitionProperties Properties { get; } = new PartitionProperties();

    }
}
