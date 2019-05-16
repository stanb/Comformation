using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket RoutingRuleCondition
    /// Specifies a condition that must be met for a redirect to apply.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-routingrulecondition.html
    /// </summary>
    public class RoutingRuleCondition
    {

        /// <summary>
        /// HttpErrorCodeReturnedEquals
        /// The HTTP error code when the redirect is applied. In the event of an error, if the error code equals
        /// this value, then the specified redirect is applied.
        /// Required when parent element Condition is specified and sibling KeyPrefixEquals is not specified. If
        /// both are specified, then both must be true for the redirect to be applied.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpErrorCodeReturnedEquals")]
        public Union<string, IntrinsicFunction> HttpErrorCodeReturnedEquals { get; set; }

        /// <summary>
        /// KeyPrefixEquals
        /// The object key name prefix when the redirect is applied. For example, to redirect requests for
        /// ExamplePage. html, the key prefix will be ExamplePage. html. To redirect request for all pages with
        /// the prefix docs/, the key prefix will be /docs, which identifies all objects in the docs/ folder.
        /// Required when the parent element Condition is specified and sibling HttpErrorCodeReturnedEquals is
        /// not specified. If both conditions are specified, both must be true for the redirect to be applied.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyPrefixEquals")]
        public Union<string, IntrinsicFunction> KeyPrefixEquals { get; set; }

    }
}
