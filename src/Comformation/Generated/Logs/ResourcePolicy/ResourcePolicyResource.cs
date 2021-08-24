using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.ResourcePolicy
{
    /// <summary>
    /// AWS::Logs::ResourcePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-resourcepolicy.html
    /// </summary>
    public class ResourcePolicyResource : ResourceBase
    {
        public class ResourcePolicyProperties
        {
            /// <summary>
            /// PolicyName
            /// The name of the resource policy.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// PolicyDocument
            /// The details of the policy. It must be formatted in JSON, and you must use backslashes to escape
            /// characters that need to be escaped in JSON strings, such as double quote marks.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 5120
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyDocument { get; set; }

        }

        public string Type { get; } = "AWS::Logs::ResourcePolicy";

        public ResourcePolicyProperties Properties { get; } = new ResourcePolicyProperties();

    }
}
