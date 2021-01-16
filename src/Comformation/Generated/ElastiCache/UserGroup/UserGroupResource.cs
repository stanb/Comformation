using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.UserGroup
{
    /// <summary>
    /// AWS::ElastiCache::UserGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-usergroup.html
    /// </summary>
    public class UserGroupResource : ResourceBase
    {
        public class UserGroupProperties
        {
            /// <summary>
            /// UserGroupId
            /// The ID of the user group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserGroupId { get; set; }

            /// <summary>
            /// Engine
            /// The current supported value is Redis.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-zA-Z]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Engine { get; set; }

            /// <summary>
            /// UserIds
            /// The list of user IDs that belong to the user group.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> UserIds { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::UserGroup";

        public UserGroupProperties Properties { get; } = new UserGroupProperties();

    }

    public static class UserGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
