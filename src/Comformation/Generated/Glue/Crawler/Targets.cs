using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler Targets
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        /// S3Targets
        /// Specifies Amazon Simple Storage Service (Amazon S3) targets.
        /// Required: No
        /// Type: List of S3Target
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Targets")]
        public List<S3Target> S3Targets { get; set; }

        /// <summary>
        /// CatalogTargets
        /// 	
        /// Specifies AWS Glue Data Catalog targets.
        /// 	
        /// Required: No
        /// Type: List of CatalogTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogTargets")]
        public List<CatalogTarget> CatalogTargets { get; set; }

        /// <summary>
        /// JdbcTargets
        /// Specifies JDBC targets.
        /// Required: No
        /// Type: List of JdbcTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JdbcTargets")]
        public List<JdbcTarget> JdbcTargets { get; set; }

        /// <summary>
        /// DynamoDBTargets
        /// 		
        /// Specifies Amazon DynamoDB targets.
        /// 	
        /// Required: No
        /// Type: List of DynamoDBTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamoDBTargets")]
        public List<DynamoDBTarget> DynamoDBTargets { get; set; }

    }
}
