using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler RecrawlPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-recrawlpolicy.html
    /// </summary>
    public class RecrawlPolicy
    {

        /// <summary>
        /// RecrawlBehavior
        /// Specifies whether to crawl the entire dataset again or to crawl only folders that were added since
        /// the last crawler run.
        /// 	 	
        /// A value of CRAWL_EVERYTHING specifies crawling the entire dataset again.
        /// A value of CRAWL_NEW_FOLDERS_ONLY specifies crawling only folders that were added since the last
        /// crawler run.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecrawlBehavior")]
        public Union<string, IntrinsicFunction> RecrawlBehavior { get; set; }

    }
}
