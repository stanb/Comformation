using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Crawler
{
    /// <summary>
    /// AWS::Glue::Crawler
    /// The AWS::Glue::Crawler resource specifies an AWS Glue crawler. For more information, see Cataloging Tables
    /// with a Crawler and Crawler Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html
    /// </summary>
    public class CrawlerResource : ResourceBase
    {
        public class CrawlerProperties
        {
            /// <summary>
            /// Role
            /// The Amazon Resource Name (ARN) of an IAM role that&#39;s used to access customer resources, such as
            /// Amazon S3 data.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Role { get; set; }

            /// <summary>
            /// Classifiers
            /// A list of UTF-8 strings that specify the custom classifiers that are associated with the crawler.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Classifiers { get; set; }

            /// <summary>
            /// Description
            /// A description of the crawler and where it should be used. It must match the URI address multi-line
            /// string pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
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
            /// crawler&#39;s behavior. For more information, see Configuring a Crawler. .
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Configuration { get; set; }

            /// <summary>
            /// Schedule
            /// The schedule for the crawler.
            /// Required: No
            /// Type: Schedule
            /// Update requires: No interruption
            /// </summary>
			public Schedule Schedule { get; set; }

            /// <summary>
            /// DatabaseName
            /// The name of the database where the crawler&#39;s output is stored.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// Targets
            /// The crawler targets.
            /// Required: Yes
            /// Type: Targets
            /// Update requires: No interruption
            /// </summary>
			public Targets Targets { get; set; }

            /// <summary>
            /// TablePrefix
            /// The table prefix that&#39;s used for catalog tables that are created.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TablePrefix { get; set; }

            /// <summary>
            /// Name
            /// The name of the crawler. Must match the single-line string pattern:
            /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Crawler";

        public CrawlerProperties Properties { get; } = new CrawlerProperties();

    }
}
