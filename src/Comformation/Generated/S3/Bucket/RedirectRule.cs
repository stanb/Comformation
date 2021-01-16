using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket RedirectRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html
    /// </summary>
    public class RedirectRule
    {

        /// <summary>
        /// HostName
        /// The host name to use in the redirect request.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostName")]
        public Union<string, IntrinsicFunction> HostName { get; set; }

        /// <summary>
        /// HttpRedirectCode
        /// The HTTP redirect code to use on the response. Not required if one of the siblings is present.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpRedirectCode")]
        public Union<string, IntrinsicFunction> HttpRedirectCode { get; set; }

        /// <summary>
        /// Protocol
        /// Protocol to use when redirecting requests. The default is the protocol that is used in the original
        /// request.
        /// Required: No
        /// Type: String
        /// Allowed values: http | https
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// ReplaceKeyPrefixWith
        /// The object key prefix to use in the redirect request. For example, to redirect requests for all
        /// pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block
        /// with KeyPrefixEquals set to docs/ and in the Redirect set ReplaceKeyPrefixWith to /documents. Not
        /// required if one of the siblings is present. Can be present only if ReplaceKeyWith is not provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplaceKeyPrefixWith")]
        public Union<string, IntrinsicFunction> ReplaceKeyPrefixWith { get; set; }

        /// <summary>
        /// ReplaceKeyWith
        /// The specific object key to use in the redirect request. For example, redirect request to error.
        /// html. Not required if one of the siblings is present. Can be present only if ReplaceKeyPrefixWith is
        /// not provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplaceKeyWith")]
        public Union<string, IntrinsicFunction> ReplaceKeyWith { get; set; }

    }
}
