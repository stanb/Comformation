using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html
    /// </summary>
    public class DataSourceResource : ResourceBase
    {
        public class DataSourceProperties
        {
            /// <summary>
            /// Name
            /// The name of the data source.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1000
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9_-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// IndexId
            /// The identifier of the index that should be associated with this data source.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IndexId { get; set; }

            /// <summary>
            /// Type
            /// The type of the data source.
            /// Required: Yes
            /// Type: String
            /// Allowed values: CONFLUENCE | CUSTOM | DATABASE | GOOGLEDRIVE | ONEDRIVE | S3 | SALESFORCE |
            /// SERVICENOW | SHAREPOINT | WEBCRAWLER | WORKDOCS
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// DataSourceConfiguration
            /// Configuration information for an Amazon Kendra data source. The contents of the configuration depend
            /// on the type of data source. You can only specify one type of data source in the configuration.
            /// Choose from one of the following data sources.
            /// Amazon S3 Confluence Custom Database Microsoft OneDrive Microsoft SharePoint Salesforce ServiceNow
            /// You can&#39;t specify the Configuration parameter when the Type parameter is set to CUSTOM.
            /// The Configuration parameter is required for all other data sources.
            /// Required: No
            /// Type: DataSourceConfiguration
            /// Update requires: No interruption
            /// </summary>
            public DataSourceConfiguration DataSourceConfiguration { get; set; }

            /// <summary>
            /// Description
            /// A description of the data source.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Schedule
            /// Sets the frequency that Amazon Kendra checks the documents in your data source and updates the
            /// index. If you don&#39;t set a schedule, Amazon Kendra doesn&#39;t periodically update the index.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of a role with permission to access the data source.
            /// You can&#39;t specify the RoleArn parameter when the Type parameter is set to CUSTOM.
            /// The RoleArn parameter is required for all other data sources.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Kendra::DataSource";

        public DataSourceProperties Properties { get; } = new DataSourceProperties();

    }

    public static class DataSourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
