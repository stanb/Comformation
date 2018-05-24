using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.PolicyPrincipalAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-policyprincipalattachment.html
    /// </summary>
    public class PolicyPrincipalAttachmentResource : ResourceBase
    {
        public class PolicyPrincipalAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-policyprincipalattachment.html#cfn-iot-policyprincipalattachment-policyname
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-policyprincipalattachment.html#cfn-iot-policyprincipalattachment-principal
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::PolicyPrincipalAttachment";
        
        public PolicyPrincipalAttachmentProperties Properties { get; } = new PolicyPrincipalAttachmentProperties();
    }
}
