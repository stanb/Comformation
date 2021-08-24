using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate Validity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-validity.html
    /// </summary>
    public class Validity
    {

        /// <summary>
        /// Value
        /// 		
        /// A long integer interpreted according to the value of Type, below.
        /// 	
        /// Required: Yes
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Type
        /// Specifies whether the Value parameter represents days, months, or years.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ABSOLUTE | DAYS | END_DATE | MONTHS | YEARS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
