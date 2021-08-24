using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SharePointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sharepointconfiguration.html
    /// </summary>
    public class SharePointConfiguration
    {

        /// <summary>
        /// SharePointVersion
        /// The version of Microsoft SharePoint that you are using as a data source.
        /// Required: Yes
        /// Type: String
        /// Allowed values: SHAREPOINT_2013 | SHAREPOINT_2016 | SHAREPOINT_ONLINE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SharePointVersion")]
        public Union<string, IntrinsicFunction> SharePointVersion { get; set; }

        /// <summary>
        /// Urls
        /// The URLs of the Microsoft SharePoint site that contains the documents that should be indexed.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Urls")]
        public List<Union<string, IntrinsicFunction>> Urls { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of credentials stored in AWS Secrets Manager. The credentials should
        /// be a user/password pair. If you use SharePoint Server, you also need to provide the sever domain
        /// name as part of the credentials. For more information, see Using a Microsoft SharePoint Data Source.
        /// For more information about AWS Secrets Manager, see What Is AWS Secrets Manager in the AWS Secrets
        /// Manager user guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1284
        /// Pattern: arn:[a-z0-9-\. ]{1,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[^/].
        /// {0,1023}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// CrawlAttachments
        /// TRUE to include attachments to documents stored in your Microsoft SharePoint site in the index;
        /// otherwise, FALSE.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlAttachments")]
        public Union<bool, IntrinsicFunction> CrawlAttachments { get; set; }

        /// <summary>
        /// UseChangeLog
        /// Set to TRUE to use the Microsoft SharePoint change log to determine the documents that need to be
        /// updated in the index. Depending on the size of the SharePoint change log, it may take longer for
        /// Amazon Kendra to use the change log than it takes it to determine the changed documents using the
        /// Amazon Kendra document crawler.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseChangeLog")]
        public Union<bool, IntrinsicFunction> UseChangeLog { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of regular expression patterns. Documents that match the patterns are included in the index.
        /// Documents that don&#39;t match the patterns are excluded from the index. If a document matches both an
        /// inclusion pattern and an exclusion pattern, the document is not included in the index.
        /// The regex is applied to the display URL of the SharePoint document.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// A list of regular expression patterns. Documents that match the patterns are excluded from the
        /// index. Documents that don&#39;t match the patterns are included in the index. If a document matches both
        /// an exclusion pattern and an inclusion pattern, the document is not included in the index.
        /// The regex is applied to the display URL of the SharePoint document.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> ExclusionPatterns { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: DataSourceVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// FieldMappings
        /// A list of DataSourceToIndexFieldMapping objects that map Microsoft SharePoint attributes to custom
        /// fields in the Amazon Kendra index. You must first create the index fields using the UpdateIndex
        /// operation before you map SharePoint attributes. For more information, see Mapping Data Source
        /// Fields.
        /// Required: No
        /// Type: List of DataSourceToIndexFieldMapping
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; }

        /// <summary>
        /// DocumentTitleFieldName
        /// The Microsoft SharePoint attribute field that contains the title of the document.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_. ]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentTitleFieldName")]
        public Union<string, IntrinsicFunction> DocumentTitleFieldName { get; set; }

        /// <summary>
        /// DisableLocalGroups
        /// A Boolean value that specifies whether local groups are disabled (True) or enabled (False).
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableLocalGroups")]
        public Union<bool, IntrinsicFunction> DisableLocalGroups { get; set; }

    }
}
