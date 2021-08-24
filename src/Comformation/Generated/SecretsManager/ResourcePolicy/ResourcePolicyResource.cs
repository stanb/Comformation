using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.ResourcePolicy
{
    /// <summary>
    /// AWS::SecretsManager::ResourcePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-resourcepolicy.html
    /// </summary>
    public class ResourcePolicyResource : ResourceBase
    {
        public class ResourcePolicyProperties
        {
            /// <summary>
            /// BlockPublicPolicy
            /// Specifies if you configured a check for a resource policy that exposes information publicly.
            /// For more information on using this parameter, see Managing a resource-based policy for a secret.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> BlockPublicPolicy { get; set; }

            /// <summary>
            /// SecretId
            /// Specifies the Amazon Resource Name (ARN) or the friendly name of the secret to attach a
            /// resource-based permissions policy.
            /// Important If you use this property to change the SecretId for an existing resource-based policy,
            /// Secrets Manager removes the policy from the original secret, and then attaches the policy to the
            /// secret with the specified SecretId. This results in changing the permissions for two secrets.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// ResourcePolicy
            /// Specifies a JSON object constructed according to the grammar and syntax for a resource-based policy.
            /// The policy identifies who can access or manage this secret and associated versions. For information
            /// on how to format a JSON object as a parameter for this resource type, see Using Resource-based
            /// Policies for Secrets Manager in the AWS Secrets Manager User Guide. Those same rules apply here.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResourcePolicy { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::ResourcePolicy";

        public ResourcePolicyProperties Properties { get; } = new ResourcePolicyProperties();

    }
}
