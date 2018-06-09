using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::SqlInjectionMatchSet
    /// The AWS::WAFRegional::SqlInjectionMatchSet resource creates an AWS WAF Regional SqlInjectionMatchSet, which
    /// you use to allow, block, or count requests that contain malicious SQL code in a specific part of web requests.
    /// For more information, see CreateSqlInjectionMatchSet in the AWS WAF Regional API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sqlinjectionmatchset.html
    /// </summary>
    public class SqlInjectionMatchSetResource : ResourceBase
    {
        public class SqlInjectionMatchSetProperties
        {
            /// <summary>
            /// SqlInjectionMatchTuples
            /// The parts of web requests that you want AWS WAF to inspect for malicious SQL code and, if you want
            /// AWS WAF to inspect a header, the name of the header.
            /// Required: No
            /// Type: List of AWS WAF Regional SqlInjectionMatchSet SqlInjectionMatchTuples
            /// Update requires: No interruption
            /// </summary>
			public Union<List<SqlInjectionMatchTuple>, IntrinsicFunction> SqlInjectionMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the SqlInjectionMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::SqlInjectionMatchSet";
        
        public SqlInjectionMatchSetProperties Properties { get; } = new SqlInjectionMatchSetProperties();
    }
}
