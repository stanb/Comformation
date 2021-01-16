using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Thing
{
    /// <summary>
    /// AWS::IoT::Thing
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html
    /// </summary>
    public class ThingResource : ResourceBase
    {
        public class ThingProperties
        {
            /// <summary>
            /// AttributePayload
            /// A string that contains up to three key value pairs. Maximum length of 800. Duplicates not allowed.
            /// Required: No
            /// Type: AttributePayload
            /// Update requires: No interruption
            /// </summary>
            public AttributePayload AttributePayload { get; set; }

            /// <summary>
            /// ThingName
            /// 		
            /// The name of the thing to update.
            /// 		
            /// You can&#39;t change a thing&#39;s name. To change a thing&#39;s name, you must create a 			new thing, give it
            /// the new name, and then delete the old thing.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ThingName { get; set; }

        }

        public string Type { get; } = "AWS::IoT::Thing";

        public ThingProperties Properties { get; } = new ThingProperties();

    }
}
