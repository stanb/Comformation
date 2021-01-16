using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Timestream.Table
{
    /// <summary>
    /// AWS::Timestream::Table
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// DatabaseName
            /// The name of the Timestream database that contains this table.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 64
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// TableName
            /// The name of the Timestream table.
            /// Required: No
            /// Type: String
            /// Minimum: 3
            /// Maximum: 64
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// RetentionProperties
            /// The retention duration for the memory store and magnetic store. This object has the following
            /// attributes:
            /// MemoryStoreRetentionPeriodInHours: Retention duration for memory store, in hours.
            /// MagneticStoreRetentionPeriodInDays: Retention duration for magnetic store, in days.
            /// Both attributes are of type string. Both attributes are required when RetentionProperties is
            /// specified.
            /// See the following examples:
            /// JSON
            /// { &quot;Type&quot; : &quot;AWS::Timestream::Table&quot;, &quot;Properties&quot; : { &quot;DatabaseName&quot; : &quot;TestDatabase&quot;, &quot;TableName&quot; :
            /// &quot;TestTable&quot;, &quot;RetentionProperties&quot; : { &quot;MemoryStoreRetentionPeriodInHours&quot;: &quot;24&quot;,
            /// &quot;MagneticStoreRetentionPeriodInDays&quot;: &quot;7&quot; } } }
            /// YAML
            /// Type: AWS::Timestream::Table DependsOn: TestDatabase Properties: TableName: &quot;TestTable&quot;
            /// DatabaseName: &quot;TestDatabase&quot; RetentionProperties: MemoryStoreRetentionPeriodInHours: &quot;24&quot;
            /// MagneticStoreRetentionPeriodInDays: &quot;7&quot;
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RetentionProperties { get; set; }

            /// <summary>
            /// Tags
            /// The tags to add to the table
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Timestream::Table";

        public TableProperties Properties { get; } = new TableProperties();

    }

    public static class TableAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
