using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App CustomRule
    /// The CustomRule property type allows you to specify redirects, rewrites, and reverse proxies. Redirects enable
    /// a web app to reroute navigation from one URL to another.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html
    /// </summary>
    public class CustomRule
    {

        /// <summary>
        /// Condition
        /// The condition for a URL rewrite or redirect rule, e. g. country code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Condition")]
        public Union<string, IntrinsicFunction> Condition { get; set; }

        /// <summary>
        /// Status
        /// The status code for a URL rewrite or redirect rule.
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
