using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-attributedef
            /// </summary>
			public Union<List<AttributeDefinition>, IntrinsicFunction> AttributeDefinitions { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-gsi
            /// </summary>
			public Union<List<GlobalSecondaryIndex>, IntrinsicFunction> GlobalSecondaryIndexes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-keyschema
            /// </summary>
			public Union<List<KeySchema>, IntrinsicFunction> KeySchema { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-lsi
            /// </summary>
			public Union<List<LocalSecondaryIndex>, IntrinsicFunction> LocalSecondaryIndexes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-pointintimerecoveryspecification
            /// </summary>
			public Union<PointInTimeRecoverySpecification, IntrinsicFunction> PointInTimeRecoverySpecification { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-provisionedthroughput
            /// </summary>
			public Union<ProvisionedThroughput, IntrinsicFunction> ProvisionedThroughput { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ssespecification
            /// </summary>
			public Union<SSESpecification, IntrinsicFunction> SSESpecification { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-streamspecification
            /// </summary>
			public Union<StreamSpecification, IntrinsicFunction> StreamSpecification { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tablename
            /// </summary>
			public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-timetolivespecification
            /// </summary>
			public Union<TimeToLiveSpecification, IntrinsicFunction> TimeToLiveSpecification { get; set; }

        }
    
        public string Type { get; } = "AWS::DynamoDB::Table";
        
        public TableProperties Properties { get; } = new TableProperties();
    }

	public static class TableAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> StreamArn = new ResourceAttribute<string>("StreamArn");
	}
}
