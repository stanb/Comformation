using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html
    /// </summary>
    public class CrawlerResource : ResourceBase
    {
        public class CrawlerProperties
        {
            /// <summary>
            /// Classifiers
            /// A list of UTF-8 strings that specify the custom classifiers that are associated with the crawler.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Classifiers { get; set; }

            /// <summary>
            /// Description
            /// A description of the crawler.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SchemaChangePolicy
            /// The policy that specifies update and delete behaviors for the crawler.
            /// Required: No
            /// Type: SchemaChangePolicy
            /// Update requires: No interruption
            /// </summary>
            public SchemaChangePolicy SchemaChangePolicy { get; set; }

            /// <summary>
            /// Configuration
            /// Crawler configuration information. This versioned JSON string allows users to specify aspects of a
            /// crawler&#39;s behavior. For more information, see Configuring a Crawler.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Configuration { get; set; }

            /// <summary>
            /// RecrawlPolicy
            /// A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that
            /// were added since the last crawler run.
            /// Required: No
            /// Type: RecrawlPolicy
            /// Update requires: No interruption
            /// </summary>
            public RecrawlPolicy RecrawlPolicy { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the database in which the crawler&#39;s output is stored.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// Targets
            /// A collection of targets to crawl.
            /// Required: Yes
            /// Type: Targets
            /// Update requires: No interruption
            /// </summary>
            public Targets Targets { get; set; }

            /// <summary>
            /// CrawlerSecurityConfiguration
            /// The name of the SecurityConfiguration structure to be used by this crawler.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CrawlerSecurityConfiguration { get; set; }

            /// <summary>
            /// Name
            /// The name of the crawler.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Role
            /// The Amazon Resource Name (ARN) of an IAM role that&#39;s used to access customer resources, such as
            /// Amazon Simple Storage Service (Amazon S3) data.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// Schedule
            /// For scheduled crawlers, the schedule when the crawler runs.
            /// Required: No
            /// Type: Schedule
            /// Update requires: No interruption
            /// </summary>
            public Schedule Schedule { get; set; }

            /// <summary>
            /// TablePrefix
            /// The prefix added to the names of tables that are created.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TablePrefix { get; set; }

            /// <summary>
            /// Tags
            /// The tags to use with this crawler.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Crawler";

        public CrawlerProperties Properties { get; } = new CrawlerProperties();

    }
}
