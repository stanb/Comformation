using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket WebsiteConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html
    /// </summary>
    public class WebsiteConfiguration
    {

        /// <summary>
        /// ErrorDocument
        /// The name of the error document for the website.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorDocument")]
        public Union<string, IntrinsicFunction> ErrorDocument { get; set; }

        /// <summary>
        /// IndexDocument
        /// The name of the index document for the website.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexDocument")]
        public Union<string, IntrinsicFunction> IndexDocument { get; set; }

        /// <summary>
        /// RedirectAllRequestsTo
        /// The redirect behavior for every request to this bucket&#39;s website endpoint.
        /// Important If you specify this property, you can&#39;t specify any other property.
        /// Required: No
        /// Type: RedirectAllRequestsTo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedirectAllRequestsTo")]
        public RedirectAllRequestsTo RedirectAllRequestsTo { get; set; }

        /// <summary>
        /// RoutingRules
        /// Rules that define when a redirect is applied and the redirect behavior.
        /// Required: No
        /// Type: List of RoutingRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoutingRules")]
        public List<RoutingRule> RoutingRules { get; set; }

    }
}
