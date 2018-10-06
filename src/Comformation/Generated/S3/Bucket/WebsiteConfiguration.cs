using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Website Configuration Property
    /// WebsiteConfiguration is an embedded property of the AWS::S3::Bucket resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html
    /// </summary>
    public class WebsiteConfiguration
    {

        /// <summary>
        /// ErrorDocument
        /// The name of the error document for the website.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ErrorDocument")]
        public Union<string, IntrinsicFunction> ErrorDocument { get; set; }

        /// <summary>
        /// IndexDocument
        /// The name of the index document for the website.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IndexDocument")]
        public Union<string, IntrinsicFunction> IndexDocument { get; set; }

        /// <summary>
        /// RedirectAllRequestsTo
        /// The redirect behavior for every request to this bucket&#39;s website endpoint.
        /// Important If you specify this property, you cannot specify any other property.
        /// Required: No
        /// Type: Amazon S3 Website Configuration Redirect All Requests To Property
        /// </summary>
        [JsonProperty("RedirectAllRequestsTo")]
        public RedirectAllRequestsTo RedirectAllRequestsTo { get; set; }

        /// <summary>
        /// RoutingRules
        /// Rules that define when a redirect is applied and the redirect behavior.
        /// Required: No
        /// Type: List of Amazon S3 Website Configuration Routing Rules Property
        /// </summary>
        [JsonProperty("RoutingRules")]
        public List<RoutingRule> RoutingRules { get; set; }

    }
}
