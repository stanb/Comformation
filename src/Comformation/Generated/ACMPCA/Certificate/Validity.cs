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
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<int, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// Determines how ACM Private CA interprets the Value 			parameter, an integer. Supported validity
        /// types include those listed below. Type 			definitions with values include a sample input value and
        /// the resulting output.
        /// 		
        /// END_DATE: The specific date and time when the certificate will expire, 			expressed using UTCTime
        /// (YYMMDDHHMMSS) or GeneralizedTime (YYYYMMDDHHMMSS) format. When 			UTCTime is used, if the year
        /// field (YY) is greater than or equal to 50, the year is 			interpreted as 19YY. If the year field is
        /// less than 50, the year is interpreted as 			20YY.
        /// 		
        /// 			 			 		 				 Sample input value: 491231235959 (UTCTime format) 			 				 Output expiration
        /// date/time: 12/31/2049 23:59:59 			
        /// 		
        /// ABSOLUTE: The specific date and time when the certificate will expire, 			expressed in seconds since
        /// the Unix Epoch.
        /// 		
        /// 			 			 		 				 Sample input value: 2524608000 			 				 Output expiration date/time: 01/01/2050
        /// 00:00:00 			
        /// 		
        /// DAYS, MONTHS, YEARS: The relative time from the 			moment of issuance until the certificate will
        /// expire, expressed in days, months, or 			years.
        /// 		
        /// Example if DAYS, issued on 10/12/2020 at 12:34:54 UTC:
        /// 		
        /// 			 			 		 				 Sample input value: 90 			 				 Output expiration date: 01/10/2020 12:34:54 UTC 			
        /// 		
        /// The minimum validity duration for a certificate using relative time 			(DAYS) is one day. The
        /// minimum validity for a certificate using absolute 			time (ABSOLUTE or END_DATE) is one second.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: ABSOLUTE | DAYS | END_DATE | MONTHS | YEARS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
