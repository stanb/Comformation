using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.RoutingControl
{
    /// <summary>
    /// AWS::Route53RecoveryControl::RoutingControl
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-routingcontrol.html
    /// </summary>
    public class RoutingControlResource : ResourceBase
    {
        public class RoutingControlProperties
        {
            /// <summary>
            /// ControlPanelArn
            /// The Amazon Resource Name (ARN) of the control panel that includes the routing control.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ControlPanelArn { get; set; }

            /// <summary>
            /// Name
            /// The name of the routing control. You can use any non-white space character in the name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ClusterArn
            /// The Amazon Resource Name (ARN) of the cluster that includes the routing control.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterArn { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryControl::RoutingControl";

        public RoutingControlProperties Properties { get; } = new RoutingControlProperties();

    }

    public static class RoutingControlAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RoutingControlArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RoutingControlArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
