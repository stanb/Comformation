using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup StatementThree
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-statementthree.html
    /// </summary>
    public class StatementThree
    {

        /// <summary>
        /// ByteMatchStatement
        /// A rule statement that defines a string match search for AWS WAF to apply to web requests. The byte
        /// match statement provides the bytes to search for, the location in requests that you want AWS WAF to
        /// search, and other settings. The bytes to search for are typically a string that corresponds with
        /// ASCII characters. In the AWS WAF console and the developer guide, this is refered to as a string
        /// match statement.
        /// Required: No
        /// Type: ByteMatchStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ByteMatchStatement")]
        public ByteMatchStatement ByteMatchStatement { get; set; }

        /// <summary>
        /// SqliMatchStatement
        /// Attackers sometimes insert malicious SQL code into web requests in an effort to extract data from
        /// your database. To allow or block web requests that appear to contain malicious SQL code, create one
        /// or more SQL injection match conditions. An SQL injection match condition identifies the part of web
        /// requests, such as the URI or the query string, that you want AWS WAF to inspect. Later in the
        /// process, when you create a web ACL, you specify whether to allow or block requests that appear to
        /// contain malicious SQL code.
        /// Required: No
        /// Type: SqliMatchStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqliMatchStatement")]
        public SqliMatchStatement SqliMatchStatement { get; set; }

        /// <summary>
        /// XssMatchStatement
        /// A rule statement that defines a cross-site scripting (XSS) match search for AWS WAF to apply to web
        /// requests. XSS attacks are those where the attacker uses vulnerabilities in a benign website as a
        /// vehicle to inject malicious client-site scripts into other legitimate web browsers. The XSS match
        /// statement provides the location in requests that you want AWS WAF to search and text transformations
        /// to use on the search area before AWS WAF searches for character sequences that are likely to be
        /// malicious strings.
        /// Required: No
        /// Type: XssMatchStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("XssMatchStatement")]
        public XssMatchStatement XssMatchStatement { get; set; }

        /// <summary>
        /// SizeConstraintStatement
        /// A rule statement that compares a number of bytes against the size of a request component, using a
        /// comparison operator, such as greater than or less than. For example, you can use a size constraint
        /// statement to look for query strings that are longer than 100 bytes.
        /// If you configure AWS WAF to inspect the request body, AWS WAF inspects only the first 8192 bytes (8
        /// KB). If the request body for your web requests never exceeds 8192 bytes, you can create a size
        /// constraint condition and block requests that have a request body greater than 8192 bytes.
        /// If you choose URI for the value of Part of the request to filter on, the slash (/) in the URI counts
        /// as one character. For example, the URI /logo. jpg is nine characters long.
        /// Required: No
        /// Type: SizeConstraintStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SizeConstraintStatement")]
        public SizeConstraintStatement SizeConstraintStatement { get; set; }

        /// <summary>
        /// GeoMatchStatement
        /// Statement used to identify web requests based on country of origin.
        /// Required: No
        /// Type: GeoMatchStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GeoMatchStatement")]
        public GeoMatchStatement GeoMatchStatement { get; set; }

        /// <summary>
        /// IPSetReferenceStatement
        /// Statement that references a set of IP addresses to compare to incoming requests.
        /// Required: No
        /// Type: IPSetReferenceStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPSetReferenceStatement")]
        public IPSetReferenceStatement IPSetReferenceStatement { get; set; }

        /// <summary>
        /// RegexPatternSetReferenceStatement
        /// A rule statement used to search web request components for matches with regular expressions. To use
        /// this, create a RegexPatternSet with the expressions that you want to detect, then use that set in
        /// this statement. A web request matches the pattern set rule statement if the request component
        /// matches any of the patterns in the set.
        /// Required: No
        /// Type: RegexPatternSetReferenceStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegexPatternSetReferenceStatement")]
        public RegexPatternSetReferenceStatement RegexPatternSetReferenceStatement { get; set; }

    }
}
