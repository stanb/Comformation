using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.User
{
    /// <summary>
    /// AWS::ElastiCache::User
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-user.html
    /// </summary>
    public class UserResource : ResourceBase
    {
        public class UserProperties
        {
            /// <summary>
            /// UserId
            /// The ID of the user.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Pattern: [a-zA-Z][a-zA-Z0-9\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserId { get; set; }

            /// <summary>
            /// UserName
            /// The username of the user.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserName { get; set; }

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
            /// AccessString
            /// Access permissions string used for this user.
            /// Required: No
            /// Type: String
            /// Pattern: . *\S. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AccessString { get; set; }

            /// <summary>
            /// NoPasswordRequired
            /// Indicates a password is not required for this user.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> NoPasswordRequired { get; set; }

            /// <summary>
            /// Passwords
            /// Passwords used for this user. You can create up to two passwords for each user.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Passwords { get; set; }

        }

        public string Type { get; } = "AWS::ElastiCache::User";

        public UserProperties Properties { get; } = new UserProperties();

    }

    public static class UserAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
