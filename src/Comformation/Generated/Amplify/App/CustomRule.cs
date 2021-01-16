using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App CustomRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html
    /// </summary>
    public class CustomRule
    {

        /// <summary>
        /// Condition
        /// The condition for a URL rewrite or redirect rule, such as a country code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

        /// <summary>
        /// Status
        /// The status code for a URL rewrite or redirect rule.
        /// 200 Represents a 200 rewrite rule. 301 Represents a 301 (moved pemanently) redirect rule. This and
        /// all future requests should be directed to the target URL. 302 Represents a 302 temporary redirect
        /// rule. 404 Represents a 404 redirect rule. 404-200 Represents a 404 rewrite rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Target
        /// The target pattern for a URL rewrite or redirect rule.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// Source
        /// The source pattern for a URL rewrite or redirect rule.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

    }
}
