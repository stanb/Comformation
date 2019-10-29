using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.GeoMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::GeoMatchSet
    /// Contains one or more countries that AWS WAF will search for.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-geomatchset.html
    /// </summary>
    public class GeoMatchSetResource : ResourceBase
    {
        public class GeoMatchSetProperties
        {
            /// <summary>
            /// GeoMatchConstraints
            /// An array of GeoMatchConstraint objects, which contain the country that you want AWS WAF to search
            /// for.
            /// Required: No
            /// Type: List of GeoMatchConstraint
            /// Update requires: No interruption
            /// </summary>
			public List<GeoMatchConstraint> GeoMatchConstraints { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the AWS::WAFRegional::GeoMatchSet. You can&#39;t change the name of an
            /// GeoMatchSet after you create it.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::GeoMatchSet";

        public GeoMatchSetProperties Properties { get; } = new GeoMatchSetProperties();

    }
}
