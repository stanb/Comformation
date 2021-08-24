using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource AmazonElasticsearchParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-amazonelasticsearchparameters.html
    /// </summary>
    public class AmazonElasticsearchParameters
    {

        /// <summary>
        /// Domain
        /// The Amazon Elasticsearch Service domain.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Domain")]
        public Union<string, IntrinsicFunction> Domain { get; set; }

    }
}
