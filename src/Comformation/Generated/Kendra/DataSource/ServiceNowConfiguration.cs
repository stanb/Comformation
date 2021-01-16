using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ServiceNowConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-servicenowconfiguration.html
    /// </summary>
    public class ServiceNowConfiguration
    {

        /// <summary>
        /// HostUrl
        /// The ServiceNow instance that the data source connects to. The host endpoint should look like the
        /// following: {instance}. service-now. com.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: ^(?!(^(https?|ftp|file):\/\/))[a-z0-9-]+(\. service-now\. com)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostUrl")]
        public Union<string, IntrinsicFunction> HostUrl { get; set; }

        /// <summary>
        /// SecretArn
        /// The Amazon Resource Name (ARN) of the AWS Secret Manager secret that contains the user name and
        /// password required to connect to the ServiceNow instance.
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
        /// ServiceNowBuildVersion
        /// The identifier of the release that the ServiceNow host is running. If the host is not running the
        /// LONDON release, use OTHERS.
        /// Required: Yes
        /// Type: String
        /// Allowed values: LONDON | OTHERS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNowBuildVersion")]
        public Union<string, IntrinsicFunction> ServiceNowBuildVersion { get; set; }

        /// <summary>
        /// KnowledgeArticleConfiguration
        /// Provides configuration information for crawling knowledge articles in the ServiceNow site.
        /// Required: No
        /// Type: ServiceNowKnowledgeArticleConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KnowledgeArticleConfiguration")]
        public ServiceNowKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }

        /// <summary>
        /// ServiceCatalogConfiguration
        /// Provides configuration information for crawling service catalogs in the ServiceNow site.
        /// Required: No
        /// Type: ServiceNowServiceCatalogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceCatalogConfiguration")]
        public ServiceNowServiceCatalogConfiguration ServiceCatalogConfiguration { get; set; }

    }
}
