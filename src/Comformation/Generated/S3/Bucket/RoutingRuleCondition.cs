using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Website Configuration Routing Rules Routing Rule Condition Property
    /// The RoutingRuleCondition property is an embedded property of the Amazon S3 Website Configuration Routing Rules
    /// Property that describes a condition that must be met for a redirect to apply.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-routingrulecondition.html
    /// </summary>
    public class RoutingRuleCondition
    {

        /// <summary>
        /// HttpErrorCodeReturnedEquals
        /// Applies this redirect if the error code equals this value in the event of an error.
        /// Required: Conditional. You must specify at least one condition property.
        /// Type: String
        /// </summary>
        [JsonProperty("HttpErrorCodeReturnedEquals")]
        public Union<string, IntrinsicFunction> HttpErrorCodeReturnedEquals { get; set; }

        /// <summary>
        /// KeyPrefixEquals
        /// The object key name prefix when the redirect is applied. For example, to redirect requests for
        /// ExamplePage. html, set the key prefix to ExamplePage. html. To redirect request for all pages with
        /// the prefix docs/, set the key prefix to docs/, which identifies all objects in the docs/ folder.
        /// Required: Conditional. You must at least one condition property.
        /// Type: String
        /// </summary>
        [JsonProperty("KeyPrefixEquals")]
        public Union<string, IntrinsicFunction> KeyPrefixEquals { get; set; }

    }
}
