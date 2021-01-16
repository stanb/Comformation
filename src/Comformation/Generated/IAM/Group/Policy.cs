using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.Group
{
    /// <summary>
    /// AWS::IAM::Role Policy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html
    /// </summary>
    public class Policy
    {

        /// <summary>
        /// PolicyDocument
        /// The policy document.
        /// Required: Yes
        /// Type: Json
        /// Minimum: 1
        /// Maximum: 131072
        /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        /// <summary>
        /// PolicyName
        /// The friendly name (not ARN) identifying the policy.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: [\w+=,. @-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
