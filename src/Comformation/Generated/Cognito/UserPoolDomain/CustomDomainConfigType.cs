using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolDomain
{
    /// <summary>
    /// AWS::Cognito::UserPoolDomain CustomDomainConfigType
    /// The configuration for a custom domain that hosts the sign-up and sign-in webpages for your application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpooldomain-customdomainconfigtype.html
    /// </summary>
    public class CustomDomainConfigType
    {

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) of an AWS Certificate Manager SSL certificate. You use this
        /// certificate for the subdomain of your custom domain.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
        /// @-]+)?(:[\w+=/,. @-]+)?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
