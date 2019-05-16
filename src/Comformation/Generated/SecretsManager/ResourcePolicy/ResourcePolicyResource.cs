using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.ResourcePolicy
{
    /// <summary>
    /// AWS::SecretsManager::ResourcePolicy
    /// Attaches the contents of the specified resource-based permission policy to a secret. A resource-based policy
    /// is optional. Alternatively, you can use IAM identity-based policies that specify the secret&#39;s Amazon Resource
    /// Name (ARN) in the policy statement&#39;s Resources element. You can also use a combination of both identity-based
    /// and resource-based policies. The affected users and roles receive the permissions that are permitted by all
    /// relevant policies.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-resourcepolicy.html
    /// </summary>
    public class ResourcePolicyResource : ResourceBase
    {
        public class ResourcePolicyProperties
        {
            /// <summary>
            /// SecretId
            /// Specifies the Amazon Resource Name (ARN) or the friendly name of the secret that you want to attach
            /// a resource-based permissions policy to.
            /// Important If you use this property to change the SecretId for an existing resource-based policy, it
            /// removes the policy from the original secret, and then attaches the policy to the secret with the
            /// specified SecretId. This results in changing the permissions for two secrets.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// ResourcePolicy
            /// Specifies a JSON object that&#39;s constructed according to the grammar and syntax for a resource-based
            /// policy. The policy identifies who can access or manage this secret and its versions. For information
            /// on how to format a JSON object as a parameter for this resource type, see Using Resource-based
            /// Policies for Secrets Managerin the AWS Secrets Manager User Guide. Those same rules apply here.
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
