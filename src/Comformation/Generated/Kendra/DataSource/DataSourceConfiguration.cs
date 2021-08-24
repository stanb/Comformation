using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DataSourceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourceconfiguration.html
    /// </summary>
    public class DataSourceConfiguration
    {

        /// <summary>
        /// S3Configuration
        /// Provides information to create a data source connector for a document repository in an Amazon S3
        /// bucket.
        /// Required: No
        /// Type: S3DataSourceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Configuration")]
        public S3DataSourceConfiguration S3Configuration { get; set; }

        /// <summary>
        /// SharePointConfiguration
        /// Provides information necessary to create a data source connector for a Microsoft SharePoint site.
        /// Required: No
        /// Type: SharePointConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SharePointConfiguration")]
        public SharePointConfiguration SharePointConfiguration { get; set; }

        /// <summary>
        /// SalesforceConfiguration
        /// Provides configuration information for data sources that connect to a Salesforce site.
        /// Required: No
        /// Type: SalesforceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SalesforceConfiguration")]
        public SalesforceConfiguration SalesforceConfiguration { get; set; }

        /// <summary>
        /// OneDriveConfiguration
        /// Provides configuration for data sources that connect to Microsoft OneDrive.
        /// Required: No
        /// Type: OneDriveConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OneDriveConfiguration")]
        public OneDriveConfiguration OneDriveConfiguration { get; set; }

        /// <summary>
        /// ServiceNowConfiguration
        /// Provides configuration for data sources that connect to ServiceNow instances.
        /// Required: No
        /// Type: ServiceNowConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNowConfiguration")]
        public ServiceNowConfiguration ServiceNowConfiguration { get; set; }

        /// <summary>
        /// DatabaseConfiguration
        /// Provides information necessary to create a data source connector for a database.
        /// Required: No
        /// Type: DatabaseConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseConfiguration")]
        public DatabaseConfiguration DatabaseConfiguration { get; set; }

        /// <summary>
        /// ConfluenceConfiguration
        /// Provides configuration information for connecting to a Confluence data source.
        /// Required: No
        /// Type: ConfluenceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfluenceConfiguration")]
        public ConfluenceConfiguration ConfluenceConfiguration { get; set; }

        /// <summary>
        /// GoogleDriveConfiguration
        /// Provides configuration for data sources that connect to Google Drive.
        /// Required: No
        /// Type: GoogleDriveConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GoogleDriveConfiguration")]
        public GoogleDriveConfiguration GoogleDriveConfiguration { get; set; }

    }
}
