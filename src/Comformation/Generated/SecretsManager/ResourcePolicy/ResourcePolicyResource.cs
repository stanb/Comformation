using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.ResourcePolicy
{
    /// <summary>
    /// AWS::SecretsManager::ResourcePolicy
    /// The AWS::SecretsManager::ResourcePolicy resource lets you define a resource-based policy and attach it to a
    /// secret that&#39;s stored in Secrets Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-resourcepolicy.html
    /// </summary>
    public class ResourcePolicyResource : ResourceBase
    {
        public class ResourcePolicyProperties
        {
            /// <summary>
            /// SecretId
            /// Specifies the Amazon Resource Name (ARN) or the friendly name of the secret that you want to attach
            /// a resource-based permissions policy to. To reference a secret that&#39;s also created in this template,
            /// use the Ref function with the secret&#39;s logical ID.
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
            /// Specifies a JSON object that&#39;s constructed according to the grammar and syntax for an
            /// AWSresource-based policy. The policy identifies who can access or manage this secret and its
            /// versions. For information on how to format a JSON object as a parameter for this resource type, see
            /// Using Resource-based Policies for Secrets Manager in the AWS Secrets Manager User Guide. Those same
            /// rules apply here.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResourcePolicy { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::ResourcePolicy";

        public ResourcePolicyProperties Properties { get; } = new ResourcePolicyProperties();

    }
}
