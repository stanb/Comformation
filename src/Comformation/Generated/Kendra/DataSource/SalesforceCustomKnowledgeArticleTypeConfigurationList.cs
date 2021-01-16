using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceCustomKnowledgeArticleTypeConfigurationList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcecustomknowledgearticletypeconfigurationlist.html
    /// </summary>
    public class SalesforceCustomKnowledgeArticleTypeConfigurationList
    {

        /// <summary>
        /// SalesforceCustomKnowledgeArticleTypeConfigurationList_
        /// </summary>
        [JsonProperty("SalesforceCustomKnowledgeArticleTypeConfigurationList")]
        public List<SalesforceCustomKnowledgeArticleTypeConfiguration> SalesforceCustomKnowledgeArticleTypeConfigurationList_ { get; set; }

    }
}
