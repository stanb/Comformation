using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL CustomResponse
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponse.html
    /// </summary>
    public class CustomResponse
    {

        /// <summary>
        /// ResponseCode
        /// The HTTP status code to return to the client.
        /// For a list of status codes that you can use in your custom reqponses, see Supported status codes for
        /// custom response in the AWS WAF Developer Guide.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 200
        /// Maximum: 600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseCode")]
        public Union<int, IntrinsicFunction> ResponseCode { get; set; }

        /// <summary>
        /// CustomResponseBodyKey
        /// References the response body that you want AWS WAF to return to the web request client. You can
        /// define a custom response for a rule action or a default web ACL action that is set to block. To do
        /// this, you first define the response body key and value in the CustomResponseBodies setting for the
        /// AWS::WAFv2::WebACL or AWS::WAFv2::RuleGroup where you want to use it. Then, in the rule action or
        /// web ACL default action BlockAction setting, you reference the response body using this key.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\w\-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomResponseBodyKey")]
        public Union<string, IntrinsicFunction> CustomResponseBodyKey { get; set; }

        /// <summary>
        /// ResponseHeaders
        /// The HTTP headers to use in the response. Duplicate header names are not allowed.
        /// For information about the limits on count and size for custom request and response settings, see AWS
        /// WAF quotas in the AWS WAF Developer Guide.
        /// Required: No
        /// Type: List of CustomHTTPHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseHeaders")]
        public List<CustomHTTPHeader> ResponseHeaders { get; set; }

    }
}
