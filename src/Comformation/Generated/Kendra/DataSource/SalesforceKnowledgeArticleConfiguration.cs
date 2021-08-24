using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceKnowledgeArticleConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceknowledgearticleconfiguration.html
    /// </summary>
    public class SalesforceKnowledgeArticleConfiguration
    {

        /// <summary>
        /// IncludedStates
        /// Specifies the document states that should be included when Amazon Kendra indexes knowledge articles.
        /// You must specify at least one state.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludedStates")]
        public List<Union<string, IntrinsicFunction>> IncludedStates { get; set; }

        /// <summary>
        /// StandardKnowledgeArticleTypeConfiguration
        /// Provides configuration information for standard Salesforce knowledge articles.
        /// Required: No
        /// Type: SalesforceStandardKnowledgeArticleTypeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StandardKnowledgeArticleTypeConfiguration")]
        public SalesforceStandardKnowledgeArticleTypeConfiguration StandardKnowledgeArticleTypeConfiguration { get; set; }

        /// <summary>
        /// CustomKnowledgeArticleTypeConfigurations
        /// Provides configuration information for custom Salesforce knowledge articles.
        /// Required: No
        /// Type: List of SalesforceCustomKnowledgeArticleTypeConfiguration
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomKnowledgeArticleTypeConfigurations")]
        public List<SalesforceCustomKnowledgeArticleTypeConfiguration> CustomKnowledgeArticleTypeConfigurations { get; set; }

    }
}
