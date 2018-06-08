using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS::WAF::SqlInjectionMatchSet
    /// The AWS::WAF::SqlInjectionMatchSet resource creates an AWS WAF SqlInjectionMatchSet, which you use to allow,
    /// block, or count requests that contain malicious SQL code in a specific part of web requests. For more
    /// information, see CreateSqlInjectionMatchSet in the AWS WAF API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html
    /// </summary>
    public class SqlInjectionMatchSetResource : ResourceBase
    {
        public class SqlInjectionMatchSetProperties
        {
            /// <summary>
            /// Name
            /// A friendly name or description of the SqlInjectionMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SqlInjectionMatchTuples
            /// The parts of web requests that you want AWS WAF to inspect for malicious SQL code and, if you want
            /// AWS WAF to inspect a header, the name of the header.
            /// Required: No
            /// Type: List of AWS WAF SqlInjectionMatchSet SqlInjectionMatchTuples
            /// Update requires: No interruption
            /// </summary>
			public Union<List<SqlInjectionMatchTuple>, IntrinsicFunction> SqlInjectionMatchTuples { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::SqlInjectionMatchSet";
        
        public SqlInjectionMatchSetProperties Properties { get; } = new SqlInjectionMatchSetProperties();
    }
}
