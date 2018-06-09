using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.ByteMatchSet
{
    /// <summary>
    /// AWS WAF ByteMatchSet ByteMatchTuples
    /// ByteMatchTuples is a property of the AWS::WAF::ByteMatchSet resource that specifies settings for an AWS WAF
    /// ByteMatchSet resource, such as the bytes (typically a string that corresponds with ASCII characters) that you
    /// want AWS WAF to search for in web requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples.html
    /// </summary>
    public class ByteMatchTuple
    {

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to search, such as a specific header or a query
        /// string.
        /// Required: Yes
        /// Type: AWS WAF ByteMatchSet ByteMatchTuples FieldToMatch
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public Union<FieldToMatch, IntrinsicFunction> FieldToMatch { get; set; }

        /// <summary>
        /// PositionalConstraint
        /// How AWS WAF finds matches within the web request part in which you are searching. For valid values,
        /// see the PositionalConstraint content for the ByteMatchTuple data type in the AWS WAF API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PositionalConstraint")]
        public Union<string, IntrinsicFunction> PositionalConstraint { get; set; }

        /// <summary>
        /// TargetString
        /// The value that AWS WAF searches for. AWS CloudFormation base64 encodes this value before sending it
        /// to AWS WAF.
        /// AWS WAF searches for this value in a specific part of web requests, which you define in the
        /// FieldToMatch property.
        /// Valid values depend on the Type value in the FieldToMatch property. For example, for a METHOD type,
        /// you must specify HTTP methods such as DELETE, GET, HEAD, OPTIONS, PATCH, POST, and PUT. For more
        /// information, see the TargetString content for the ByteMatchTuple data type in the AWS WAF API
        /// Reference.
        /// Required: Conditional. You must specify this property or the TargetStringBase64 property.
        /// Type: String
        /// </summary>
        [JsonProperty("TargetString")]
        public Union<string, IntrinsicFunction> TargetString { get; set; }

        /// <summary>
        /// TargetStringBase64
        /// The base64-encoded value that AWS WAF searches for. AWS CloudFormation sends this value to AWS WAF
        /// without encoding it.
        /// AWS WAF searches for this value in a specific part of web requests, which you define in the
        /// FieldToMatch property.
        /// Valid values depend on the Type value in the FieldToMatch property. For example, for a METHOD type,
        /// you must specify HTTP methods such as DELETE, GET, HEAD, OPTIONS, PATCH, POST, and PUT. For more
        /// information, see the TargetString content for the ByteMatchTuple data type in the AWS WAF API
        /// Reference.
        /// Required: Conditional. You must specify this property or the TargetString property.
        /// Type: String
        /// </summary>
        [JsonProperty("TargetStringBase64")]
        public Union<string, IntrinsicFunction> TargetStringBase64 { get; set; }

        /// <summary>
        /// TextTransformation
        /// Specifies how AWS WAF processes the target string value. Text transformations eliminate some of the
        /// unusual formatting that attackers use in web requests in an effort to bypass AWS WAF. If you specify
        /// a transformation, AWS WAF transforms the target string value before inspecting a web request for a
        /// match.
        /// For example, AWS WAF can replace whitespace characters (such as \t and \n) with a single space. For
        /// valid values, see the TextTransformation content for the ByteMatchTuple data type in the AWS WAF API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

    }
}
