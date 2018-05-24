using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.ThingPrincipalAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html
    /// </summary>
    public class ThingPrincipalAttachmentResource : ResourceBase
    {
        public class ThingPrincipalAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-principal
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-thingname
            /// </summary>
			public Union<string, IntrinsicFunction> ThingName { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::ThingPrincipalAttachment";
        
        public ThingPrincipalAttachmentProperties Properties { get; } = new ThingPrincipalAttachmentProperties();
    }
}
