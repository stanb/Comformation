using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSet
{
    /// <summary>
    /// AWS::QuickSight::DataSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html
    /// </summary>
    public class DataSetResource : ResourceBase
    {
        public class DataSetProperties
        {
            /// <summary>
            /// AwsAccountId
            /// 		
            /// The AWS account; ID.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// ColumnGroups
            /// 		
            /// Groupings of columns that work together in certain QuickSight features. Currently, only geospatial
            /// hierarchy is supported.
            /// 	
            /// Required: No
            /// Type: List of ColumnGroup
            /// Maximum: 8
            /// Update requires: No interruption
            /// </summary>
            public List<ColumnGroup> ColumnGroups { get; set; }

            /// <summary>
            /// ColumnLevelPermissionRules
            /// A set of one or more definitions of a ColumnLevelPermissionRule .
            /// Required: No
            /// Type: List of ColumnLevelPermissionRule
            /// Update requires: No interruption
            /// </summary>
            public List<ColumnLevelPermissionRule> ColumnLevelPermissionRules { get; set; }

            /// <summary>
            /// DataSetId
            /// 		
            /// An ID for the dataset that you want to create. This ID is unique per AWS Region; for each AWS
            /// account;.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DataSetId { get; set; }

            /// <summary>
            /// FieldFolders
            /// 		
            /// The folder that contains fields and nested subfolders for your dataset.
            /// 	
            /// Required: No
            /// Type: Map of FieldFolder
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, FieldFolder> FieldFolders { get; set; }

            /// <summary>
            /// ImportMode
            /// 		
            /// Indicates whether you want to import the data into SPICE.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: DIRECT_QUERY | SPICE
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImportMode { get; set; }

            /// <summary>
            /// LogicalTableMap
            /// 		
            /// Configures the combination and transformation of the data from the physical tables.
            /// 	
            /// Required: No
            /// Type: Map of LogicalTable
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, LogicalTable> LogicalTableMap { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The display name for the dataset.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// 		
            /// A list of resource permissions on the dataset.
            /// 	
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// PhysicalTableMap
            /// 		
            /// Declares the physical tables that are available in the underlying data sources.
            /// 	
            /// Required: No
            /// Type: Map of PhysicalTable
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, PhysicalTable> PhysicalTableMap { get; set; }

            /// <summary>
            /// RowLevelPermissionDataSet
            /// 		
            /// The row-level security configuration for the data that you want to create.
            /// 	
            /// Required: No
            /// Type: RowLevelPermissionDataSet
            /// Update requires: No interruption
            /// </summary>
            public RowLevelPermissionDataSet RowLevelPermissionDataSet { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Contains a map of the key-value pairs for the resource tag or tags assigned to the dataset.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// IngestionWaitPolicy
            /// The wait policy to use when creating or updating a Dataset. The default is to wait for SPICE
            /// ingestion to finish with timeout of 36 hours.
            /// Required: No
            /// Type: IngestionWaitPolicy
            /// Update requires: No interruption
            /// </summary>
            public IngestionWaitPolicy IngestionWaitPolicy { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::DataSet";

        public DataSetProperties Properties { get; } = new DataSetProperties();

    }

    public static class DataSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<double, IntrinsicFunction>> ConsumedSpiceCapacityInBytes = new ResourceAttribute<Union<double, IntrinsicFunction>>("ConsumedSpiceCapacityInBytes");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<List<OutputColumn>> OutputColumns = new ResourceAttribute<List<OutputColumn>>("OutputColumns");
    }
}
