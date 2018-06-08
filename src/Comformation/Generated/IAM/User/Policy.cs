using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    /// IAM Policies
    /// Policies is a property of the AWS::IAM::Role, AWS::IAM::Group, and AWS::IAM::User resources. The Policies
    /// property describes what actions are allowed on what resources. For more information about IAM policies, see
    /// Overview of Policies and AWS IAM Policy Reference in the IAM User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html
    /// </summary>
    public class Policy
    {

        /// <summary>
        /// PolicyDocument
        /// A policy document that describes what actions are allowed on which resources.
        /// Required: Yes
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        /// <summary>
        /// PolicyName
        /// The name of the policy.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
