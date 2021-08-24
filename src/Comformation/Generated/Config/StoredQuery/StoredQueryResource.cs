using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.StoredQuery
{
    /// <summary>
    /// AWS::Config::StoredQuery
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-storedquery.html
    /// </summary>
    public class StoredQueryResource : ResourceBase
    {
        public class StoredQueryProperties
        {
            /// <summary>
            /// QueryName
            /// 		
            /// The name of the query.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[a-zA-Z0-9-_]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> QueryName { get; set; }

            /// <summary>
            /// QueryDescription
            /// A unique description for the query.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> QueryDescription { get; set; }

            /// <summary>
            /// QueryExpression
            /// The expression of the query. For example, SELECT resourceId, resourceType,
            /// supplementaryConfiguration. BucketVersioningConfiguration. status WHERE resourceType =
            /// &#39;AWS::S3::Bucket&#39; AND supplementaryConfiguration. BucketVersioningConfiguration. status = &#39;Off&#39;.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> QueryExpression { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Config::StoredQuery";

        public StoredQueryProperties Properties { get; } = new StoredQueryProperties();

    }

    public static class StoredQueryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> QueryArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("QueryArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> QueryId = new ResourceAttribute<Union<string, IntrinsicFunction>>("QueryId");
    }
}
