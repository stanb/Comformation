using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.ControlPanel
{
    /// <summary>
    /// AWS::Route53RecoveryControl::ControlPanel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-controlpanel.html
    /// </summary>
    public class ControlPanelResource : ResourceBase
    {
        public class ControlPanelProperties
        {
            /// <summary>
            /// ClusterArn
            /// The Amazon Resource Name (ARN) of the cluster for the control panel.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterArn { get; set; }

            /// <summary>
            /// Name
            /// The name of the control panel. You can use any non-white space character in the name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryControl::ControlPanel";

        public ControlPanelProperties Properties { get; } = new ControlPanelProperties();

    }

    public static class ControlPanelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ControlPanelArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ControlPanelArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> DefaultControlPanel = new ResourceAttribute<Union<bool, IntrinsicFunction>>("DefaultControlPanel");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> RoutingControlCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("RoutingControlCount");
    }
}
