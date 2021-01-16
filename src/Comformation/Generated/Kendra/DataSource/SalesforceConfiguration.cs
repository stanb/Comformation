using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html
    /// </summary>
    public class SalesforceConfiguration
    {

        /// <summary>
        /// ServerUrl
        /// The instance URL for the Salesforce site that you want to index.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: ^(https?|ftp|file):\/\/([^\s]*)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerUrl")]
        public Union<string, IntrinsicFunction> ServerUrl { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of an AWS Secrets Manager secret that contains the key/value pairs
        /// required to connect to your Salesforce instance. The secret must contain a JSON structure with the
        /// following keys:
        /// authenticationUrl - The OAUTH endpoint that Amazon Kendra connects to get an OAUTH token.
        /// consumerKey - The application public key generated when you created your Salesforce application.
        /// consumerSecret - The application private key generated when you created your Salesforce application.
        /// password - The password associated with the user logging in to the Salesforce instance.
        /// securityToken - The token associated with the user account logging in to the Salesforce instance.
        /// username - The user name of the user logging in to the Salesforce instance.
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
        /// StandardObjectConfigurations
        /// Specifies the Salesforce standard objects that Amazon Kendra indexes.
        /// Required: No
        /// Type: SalesforceStandardObjectConfigurationList
        /// Maximum: 17
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StandardObjectConfigurations")]
        public SalesforceStandardObjectConfigurationList StandardObjectConfigurations { get; set; }

        /// <summary>
        /// KnowledgeArticleConfiguration
        /// Specifies configuration information for the knowlege article types that Amazon Kendra indexes.
        /// Amazon Kendra indexes standard knowledge articles and the standard fields of knowledge articles, or
        /// the custom fields of custom knowledge articles, but not both.
        /// Required: No
        /// Type: SalesforceKnowledgeArticleConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KnowledgeArticleConfiguration")]
        public SalesforceKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }

        /// <summary>
        /// ChatterFeedConfiguration
        /// Specifies configuration information for Salesforce chatter feeds.
        /// Required: No
        /// Type: SalesforceChatterFeedConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChatterFeedConfiguration")]
        public SalesforceChatterFeedConfiguration ChatterFeedConfiguration { get; set; }

        /// <summary>
        /// CrawlAttachments
        /// Indicates whether Amazon Kendra should index attachments to Salesforce objects.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlAttachments")]
        public Union<bool, IntrinsicFunction> CrawlAttachments { get; set; }

        /// <summary>
        /// StandardObjectAttachmentConfiguration
        /// Provides configuration information for processing attachments to Salesforce standard objects.
        /// Required: No
        /// Type: SalesforceStandardObjectAttachmentConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StandardObjectAttachmentConfiguration")]
        public SalesforceStandardObjectAttachmentConfiguration StandardObjectAttachmentConfiguration { get; set; }

        /// <summary>
        /// IncludeAttachmentFilePatterns
        /// A list of regular expression patterns. Documents that match the patterns are included in the index.
        /// Documents that don&#39;t match the patterns are excluded from the index. If a document matches both an
        /// inclusion pattern and an exclusion pattern, the document is not included in the index.
        /// The regex is applied to the name of the attached file.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeAttachmentFilePatterns")]
        public DataSourceInclusionsExclusionsStrings IncludeAttachmentFilePatterns { get; set; }

        /// <summary>
        /// ExcludeAttachmentFilePatterns
        /// A list of regular expression patterns. Documents that match the patterns are excluded from the
        /// index. Documents that don&#39;t match the patterns are included in the index. If a document matches both
        /// an exclusion pattern and an inclusion pattern, the document is not included in the index.
        /// The regex is applied to the name of the attached file.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeAttachmentFilePatterns")]
        public DataSourceInclusionsExclusionsStrings ExcludeAttachmentFilePatterns { get; set; }

    }
}
