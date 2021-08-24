using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceconfiguration.html
    /// </summary>
    public class ConfluenceConfiguration
    {

        /// <summary>
        /// ServerUrl
        /// The URL of your Confluence instance. Use the full URL of the server. For example, https://server.
        /// example. com:port/. You can also use an IP address, for example, https://192. 168. 1. 113/.
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
        /// The Amazon Resource Name (ARN) of an AWS Secrets Managersecret that contains the key/value pairs
        /// required to connect to your Confluence server. The secret must contain a JSON structure with the
        /// following keys:
        /// username - The user name or email address of a user with administrative privileges for the
        /// Confluence server. password - The password associated with the user logging in to the Confluence
        /// server.
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
        /// Version
        /// Specifies the version of the Confluence installation that you are connecting to.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CLOUD | SERVER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// SpaceConfiguration
        /// Specifies configuration information for indexing Confluence spaces.
        /// Required: No
        /// Type: ConfluenceSpaceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpaceConfiguration")]
        public ConfluenceSpaceConfiguration SpaceConfiguration { get; set; }

        /// <summary>
        /// PageConfiguration
        /// Specifies configuration information for indexing Confluence pages.
        /// Required: No
        /// Type: ConfluencePageConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PageConfiguration")]
        public ConfluencePageConfiguration PageConfiguration { get; set; }

        /// <summary>
        /// BlogConfiguration
        /// Specifies configuration information for indexing Confluence blogs.
        /// Required: No
        /// Type: ConfluenceBlogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlogConfiguration")]
        public ConfluenceBlogConfiguration BlogConfiguration { get; set; }

        /// <summary>
        /// AttachmentConfiguration
        /// Specifies configuration information for indexing attachments to Confluence blogs and pages.
        /// Required: No
        /// Type: ConfluenceAttachmentConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttachmentConfiguration")]
        public ConfluenceAttachmentConfiguration AttachmentConfiguration { get; set; }

        /// <summary>
        /// VpcConfiguration
        /// Specifies the information for connecting to an Amazon VPC.
        /// Required: No
        /// Type: DataSourceVpcConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfiguration")]
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of regular expression patterns that apply to a URL on the Confluence server. An inclusion
        /// pattern can apply to a blog post, a page, a space, or an attachment. Items that match the patterns
        /// are included in the index. Items that don&#39;t match the pattern are excluded from the index. If an
        /// item matches both an inclusion pattern and an exclusion pattern, the item isn&#39;t included in the
        /// index.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// A list of regular expression patterns that apply to a URL on the Confluence server. An exclusion
        /// pattern can apply to a blog post, a page, a space, or an attachment. Items that match the pattern
        /// are excluded from the index. Items that don&#39;t match the pattern are included in the index. If a item
        /// matches both an exclusion pattern and an inclusion pattern, the item isn&#39;t included in the index.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> ExclusionPatterns { get; set; }

    }
}
