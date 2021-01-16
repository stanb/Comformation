using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Keyspace
{
    /// <summary>
    /// AWS::Cassandra::Keyspace
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html
    /// </summary>
    public class KeyspaceResource : ResourceBase
    {
        public class KeyspaceProperties
        {
            /// <summary>
            /// KeyspaceName
            /// The name of the keyspace to be created. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique ID and uses that ID for the keyspace name. For more information, see Name Type.
            /// Length Constraints: Minimum length of 3. Maximum length of 255.
            /// Pattern: ^[a-zA-Z0-9][a-zA-Z0-9_]{1,47}$
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyspaceName { get; set; }

        }

        public string Type { get; } = "AWS::Cassandra::Keyspace";

        public KeyspaceProperties Properties { get; } = new KeyspaceProperties();

    }
}
