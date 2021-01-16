using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL StatementTwo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-statementtwo.html
    /// </summary>
    public class StatementTwo
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
        /// RuleGroupReferenceStatement
        /// A rule statement used to run the rules that are defined in a RuleGroup. To use this, create a rule
        /// group with your rules, then provide the ARN of the rule group in this statement. You can&#39;t nest this
        /// type of statement within another.
        /// Required: No
        /// Type: RuleGroupReferenceStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleGroupReferenceStatement")]
        public RuleGroupReferenceStatement RuleGroupReferenceStatement { get; set; }

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

        /// <summary>
        /// ManagedRuleGroupStatement
        /// Statement that references a managed rule group.
        /// Required: No
        /// Type: ManagedRuleGroupStatement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManagedRuleGroupStatement")]
        public ManagedRuleGroupStatement ManagedRuleGroupStatement { get; set; }

        /// <summary>
        /// RateBasedStatement
        /// A rate-based rule tracks the rate of requests for each originating IP address, and triggers the rule
        /// action when the rate exceeds a limit that you specify on the number of requests in any 5-minute time
        /// span. You can use this to put a temporary block on requests from an IP address that&#39;s sending
        /// excessive requests.
        /// When the rule action triggers, AWS WAF blocks additional requests from the IP address until the
        /// request rate falls below the limit.
        /// You can optionally nest another statement inside the rate-based statement, to narrow the scope of
        /// the rule so that it only counts requests that match the nested statement. You can&#39;t nest a
        /// RateBasedStatement, for example for use inside a NotStatement or OrStatement. It can only be
        /// referenced as a top-level statement within a rule.
        /// Required: No
        /// Type: RateBasedStatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RateBasedStatement")]
        public RateBasedStatementTwo RateBasedStatement { get; set; }

        /// <summary>
        /// AndStatement
        /// Logical AND statement used in statement nesting.
        /// Required: No
        /// Type: AndStatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AndStatement")]
        public AndStatementTwo AndStatement { get; set; }

        /// <summary>
        /// OrStatement
        /// Logical OR statement used in statement nesting.
        /// Required: No
        /// Type: OrStatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrStatement")]
        public OrStatementTwo OrStatement { get; set; }

        /// <summary>
        /// NotStatement
        /// Logical NOT statement used to negate the match results of a nested statement.
        /// Required: No
        /// Type: NotStatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotStatement")]
        public NotStatementTwo NotStatement { get; set; }

    }
}
