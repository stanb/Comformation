using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.PolicyPrincipalAttachment
{
    /// <summary>
    /// AWS::IoT::PolicyPrincipalAttachment
    /// Use the AWS::IoT::PolicyPrincipalAttachment resource to attach an AWS IoT policy to a principal (an X. 509
    /// certificate or other credential).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-policyprincipalattachment.html
    /// </summary>
    public class PolicyPrincipalAttachmentResource : ResourceBase
    {
        public class PolicyPrincipalAttachmentProperties
        {
            /// <summary>
            /// PolicyName
            /// The name of the policy.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// Principal
            /// The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or
            /// an Amazon Cognito ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::PolicyPrincipalAttachment";
        
        public PolicyPrincipalAttachmentProperties Properties { get; } = new PolicyPrincipalAttachmentProperties();
    }
}
