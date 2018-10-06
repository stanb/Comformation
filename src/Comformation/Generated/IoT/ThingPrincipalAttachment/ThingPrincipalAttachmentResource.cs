using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.ThingPrincipalAttachment
{
    /// <summary>
    /// AWS::IoT::ThingPrincipalAttachment
    /// Use the AWS::IoT::ThingPrincipalAttachment resource to attach a principal (an X. 509 certificate or another
    /// credential) to a thing.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html
    /// </summary>
    public class ThingPrincipalAttachmentResource : ResourceBase
    {
        public class ThingPrincipalAttachmentProperties
        {
            /// <summary>
            /// Principal
            /// The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or
            /// an Amazon Cognito ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

            /// <summary>
            /// ThingName
            /// The name of the AWS IoT thing.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ThingName { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::ThingPrincipalAttachment";
        
        public ThingPrincipalAttachmentProperties Properties { get; } = new ThingPrincipalAttachmentProperties();

    }
}
