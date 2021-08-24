using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.XRay.SamplingRule
{
    /// <summary>
    /// AWS::XRay::SamplingRule SamplingRuleUpdate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-xray-samplingrule-samplingruleupdate.html
    /// </summary>
    public class SamplingRuleUpdate
    {

        /// <summary>
        /// Attributes
        /// Matches attributes derived from the request.
        /// Map Entries: Maximum number of 5 items.
        /// Key Length Constraints: Minimum length of 1. Maximum length of 32.
        /// Value Length Constraints: Minimum length of 1. Maximum length of 32.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

        /// <summary>
        /// FixedRate
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FixedRate")]
        public Union<double, IntrinsicFunction> FixedRate { get; set; }

        /// <summary>
        /// Host
        /// Matches the hostname from a request URL.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Host")]
        public Union<string, IntrinsicFunction> Host { get; set; }

        /// <summary>
        /// HTTPMethod
        /// Matches the HTTP method of a request.
        /// Required: No
        /// Type: String
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HTTPMethod")]
        public Union<string, IntrinsicFunction> HTTPMethod { get; set; }

        /// <summary>
        /// Priority
        /// The priority of the sampling rule.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// ReservoirSize
        /// A fixed number of matching requests to instrument per second, prior to applying the fixed rate. The
        /// reservoir is not used directly by services, but applies to all services using the rule collectively.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReservoirSize")]
        public Union<int, IntrinsicFunction> ReservoirSize { get; set; }

        /// <summary>
        /// ResourceARN
        /// Matches the ARN of the AWS resource on which the service runs.
        /// Required: No
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceARN")]
        public Union<string, IntrinsicFunction> ResourceARN { get; set; }

        /// <summary>
        /// RuleARN
        /// The ARN of the sampling rule. You must specify either RuleARN or RuleName, but not both.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleARN")]
        public Union<string, IntrinsicFunction> RuleARN { get; set; }

        /// <summary>
        /// RuleName
        /// The name of the sampling rule. You must specify either RuleARN or RuleName, but not both.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleName")]
        public Union<string, IntrinsicFunction> RuleName { get; set; }

        /// <summary>
        /// ServiceName
        /// Matches the name that the service uses to identify itself in segments.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// ServiceType
        /// Matches the origin that the service uses to identify its type in segments.
        /// Required: No
        /// Type: String
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceType")]
        public Union<string, IntrinsicFunction> ServiceType { get; set; }

        /// <summary>
        /// URLPath
        /// Matches the path from a request URL.
        /// Required: No
        /// Type: String
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("URLPath")]
        public Union<string, IntrinsicFunction> URLPath { get; set; }

    }
}
