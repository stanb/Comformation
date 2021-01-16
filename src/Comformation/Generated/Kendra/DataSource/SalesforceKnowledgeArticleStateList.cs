using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceKnowledgeArticleStateList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceknowledgearticlestatelist.html
    /// </summary>
    public class SalesforceKnowledgeArticleStateList
    {

        /// <summary>
        /// SalesforceKnowledgeArticleStateList_
        /// </summary>
        [JsonProperty("SalesforceKnowledgeArticleStateList")]
        public List<Union<string, IntrinsicFunction>> SalesforceKnowledgeArticleStateList_ { get; set; }

    }
}
