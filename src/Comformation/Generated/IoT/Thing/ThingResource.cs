using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Thing
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html
    /// </summary>
    public class ThingResource : ResourceBase
    {
        public class ThingProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-attributepayload
            /// </summary>
			public Union<AttributePayload, IntrinsicFunction> AttributePayload { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-thingname
            /// </summary>
			public Union<string, IntrinsicFunction> ThingName { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::Thing";
        
        public ThingProperties Properties { get; } = new ThingProperties();
    }
}
