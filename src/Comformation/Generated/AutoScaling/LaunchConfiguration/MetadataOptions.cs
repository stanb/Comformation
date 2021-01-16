using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.LaunchConfiguration
{
    /// <summary>
    /// AWS::AutoScaling::LaunchConfiguration MetadataOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-launchconfig-metadataoptions.html
    /// </summary>
    public class MetadataOptions
    {

        /// <summary>
        /// HttpEndpoint
        /// This parameter enables or disables the HTTP metadata endpoint on your instances. If the parameter is
        /// not specified, the default state is enabled.
        /// Note If you specify a value of disabled, you will not be able to access your instance metadata.
        /// Required: No
        /// Type: String
        /// Allowed values: disabled | enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpEndpoint")]
        public Union<string, IntrinsicFunction> HttpEndpoint { get; set; }

        /// <summary>
        /// HttpPutResponseHopLimit
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the
        /// further instance metadata requests can travel.
        /// Default: 1
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpPutResponseHopLimit")]
        public Union<int, IntrinsicFunction> HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// HttpTokens
        /// The state of token usage for your instance metadata requests. If the parameter is not specified in
        /// the request, the default state is optional.
        /// If the state is optional, you can choose to retrieve instance metadata with or without a signed
        /// token header on your request. If you retrieve the IAM role credentials without a token, the version
        /// 1. 0 role credentials are returned. If you retrieve the IAM role credentials using a valid signed
        /// token, the version 2. 0 role credentials are returned.
        /// If the state is required, you must send a signed token header with any instance metadata retrieval
        /// requests. In this state, retrieving the IAM role credentials always returns the version 2. 0
        /// credentials; the version 1. 0 credentials are not available.
        /// Required: No
        /// Type: String
        /// Allowed values: optional | required
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpTokens")]
        public Union<string, IntrinsicFunction> HttpTokens { get; set; }

    }
}
