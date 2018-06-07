using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Comformation.CodeBuilder
{
    public class SchemaParser
    {
        private const string BaseNamespace = "Comformation";

        public IEnumerable<CodeUnit> Parse(Schema schema)
        {
            var propertyTypes = Parse(schema.PropertyTypes);
            var resources = Parse(schema.ResourceTypes);
            return propertyTypes.AsEnumerable<CodeUnit>()
                .Concat(resources.AsEnumerable<CodeUnit>());
        }

        private IEnumerable<PropertyTypeClass> Parse(IDictionary<string, PropertySpec> propertySpecs)
        {
            var propertyClasses = propertySpecs.Select(x =>
            {
                var keyParts = x.Key.Split('.').Reverse().ToArray();
                var className = keyParts[0];
                string path;
                string namespaceName;

                if (keyParts.Length == 1)
                {
                    namespaceName = string.Join(".", BaseNamespace);
                    path = className;
                }
                else
                {
                    var nameParts = keyParts[1].Split(new string[] {"::"}, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                    namespaceName = string.Join(".", nameParts.Prepend(BaseNamespace));
                    var pathParts = nameParts.Append(className).ToArray();
                    path = Path.Combine(pathParts);
                }
                path = Path.ChangeExtension(path, ".cs");

                var propertyClass = new PropertyTypeClass
                {
                    Name = className,
                    Namespace = namespaceName,
                    Path = path,
                    Documentation = x.Value.Documentation,
                    Properties = Parse(x.Value.Properties)
                };
                FixPropertyNames(propertyClass);

                return propertyClass;
            }).ToList();

            return propertyClasses;
        }

        private IEnumerable<ResourceClass> Parse(IDictionary<string, ResourceSpec> resourceSpecs)
        {
            var resourceClasses = resourceSpecs.Select(x => Parse(x.Key, x.Value)).ToList();
            return resourceClasses;
        }

        private ResourceClass Parse(string type, ResourceSpec resourceSpec)
        {
            var nameParts = type.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
            var className = nameParts.Last();
            var namespaceName = string.Join(".", nameParts.Prepend(BaseNamespace));
            var path = Path.ChangeExtension(Path.Combine(Path.Combine(nameParts.ToArray()), className + "Resource"), ".cs");
            //var documentation = DocumentationParser.Parse(resourceSpec.Documentation);

            var resourceClass = new ResourceClass
            {
                Type = type,
                Name = className,
                Namespace = namespaceName,
                Path = path,
                Documentation = FixUrl(resourceSpec.Documentation),
                Attributes = Parse(resourceSpec.Attributes),
                Properties = Parse(resourceSpec.Properties)
            };
            return resourceClass;
        }

        private void FixPropertyNames(PropertyTypeClass propertyClass)
        {
            foreach (var prop in propertyClass.Properties)
            {
                if (prop.Name.Equals(propertyClass.Name))
                    prop.Name += "_";
            }
        }

        private IEnumerable<AttributeMember> Parse(IDictionary<string, Attribute> attributes)
        {
            if (attributes == null)
                return Enumerable.Empty<AttributeMember>();

            var members = attributes.Select(x =>
                new AttributeMember
                {
                    Name = x.Key.Replace(".", "_"),
                    Value = x.Key,
                    Type = ParsePropertyType(x.Value, true)
                }).ToList();
            return members;
        }

        private IEnumerable<PropertyMember> Parse(IDictionary<string, Property> properties)
        {
            var members = properties.Select(property =>
                new PropertyMember
                {
                    JsonProperty = property.Key,
                    Name = property.Key,
                    Documentation = FixUrl(property.Value.Documentation),
                    Type = ParsePropertyType(property.Value, property.Value.Required)
                }).ToList();
            return members;
        }

        private string ParsePropertyType(PropertyBase property, bool required)
        {
            string type;
            if (property.PrimitiveType.HasValue)
            {
                type = Parse(property.PrimitiveType.Value, true);
            }
            else
            {
                string itemType;
                switch (property.Type)
                {
                    case "List":
                        itemType = property.PrimitiveItemType.HasValue ?
                            Parse(property.PrimitiveItemType.Value, true) :
                            property.ItemType;

                        type = $"List<{itemType}>";
                        break;
                    case "Map":
                        itemType = property.PrimitiveItemType.HasValue ?
                            Parse(property.PrimitiveItemType.Value, true) :
                            property.ItemType;

                        type = $"Dictionary<string, {itemType}>";
                        break;
                    default:
                        type = property.Type;
                        break;
                }
            }

            return type;
        }

        private string Parse(PrimitiveType primitiveType, bool required)
        {
            switch (primitiveType)
            {
                case PrimitiveType.Boolean:
                    return required ? "bool" : "bool?";
                case PrimitiveType.Double:
                    return required ? "double" : "double?";
                case PrimitiveType.Integer:
                    return required ? "int" : "int?";
                case PrimitiveType.Long:
                    return required ? "long" : "long?";
                case PrimitiveType.String:
                    return "string";
                case PrimitiveType.Json:
                    return "Newtonsoft.Json.Linq.JToken";
                case PrimitiveType.Timestamp:
                    return "string";
                default:
                    throw new Exception();
            }
        }

        private static string FixUrl(string key)
        {
            var parts = key.Split("#");
            parts[0] = Fix(parts[0]);
            if (parts.Length > 1)
                parts[1] = FixHashtag(parts[1]);
            return string.Join("#", parts);
        }

        private static string Fix(string key)
        {
            key = key
                .Replace("aws-resource-elasticbeanstalk", "aws-resource-beanstalk")
                .Replace("aws-resource-cloudwatch-dashboard", "aws-properties-cw-dashboard")
                .Replace("aws-resource-elasticmapreduce-cluster", "aws-resource-emr-cluster")
                .Replace("aws-resource-dms-replicationsubnetgroup", "aws-resource-dms-replicationsubnet-group")
                .Replace("aws-resource-route53-recordsetgroup", "aws-properties-route53-recordsetgroup");

            return key;
        }

        private static string FixHashtag(string key)
        {
            if (key.Equals("topicarn"))
                return "cfn-sns-topicarn";

            key = key
                .Replace("aws-sqs-queue-contentbaseddeduplication", "cfn-sqs-queue-contentbaseddeduplication")
                .Replace("aws-sqs-queue-fifoqueue", "cfn-sqs-queue-fifoqueue")
                .Replace("aws-sqs-queue-maxmesgsize", "aws-sqs-queue-maxmsgsize")
                .Replace("aws-sqs-queue-visiblitytimeout", "aws-sqs-queue-visibilitytimeout")
                .Replace("cfn-cloudwatch-dashboard-dashboardname", "cfn-cloudwatch-dashboard-name")
                .Replace("cfn-cloudwatch-dashboard-dashboardbody", "cfn-cloudwatch-dashboard-body")
                .Replace("cfn-elasticmapreduce-cluster", "cfn-emr-cluster")
                .Replace("cfn-emr-cluster-customamiid", "cfn-elasticmapreduce-cluster-customamiid")
                .Replace("cfn-emr-cluster-ebsrootvolumesize", "cfn-elasticmapreduce-cluster-ebsrootvolumesize")
                .Replace("cfn-sns-topic-topicname", "cfn-sns-topic-name")
                .Replace("cfn-cloudwatch-alarms-dimension", "cfn-cloudwatch-alarms-dimensions")
                .Replace("cfn-redshift-cluster-HsmConfigurationIdentifier", "cfn-redshift-cluster-hsmconfigidentifier")
                .Replace("cfn-opsworks-app-sslconfiguration", "cfn-opsworks-app-sslconfig")
                .Replace("cfn-elasticloadbalancing-loadbalancer-tags", "cfn-ec2-elb-tags")
                .Replace("cfn-opsworks-layer-custominstanceprofilearn", "cfn-opsworks-layer-custinstanceprofilearn")
                .Replace("cfn-opsworks-layer-customsecuritygroupids", "cfn-opsworks-layer-custsecuritygroupnids")
                .Replace("cfn-opsworks-layer-volumeconfigurations", "cfn-opsworks-layer-volconfig")
                .Replace("cfn-apigateway-resource-restapiid", "cfn-apigateway-resource-resapiid")
                .Replace("cfn-dax-subnetgroup-subnetgroupname", "cfn-dax-subnetgroup-name")
                .Replace("cfn-dax-subnetgroup-subnetids", "cfn-dax-subnetgroup-name-values")
                .Replace("defaultsubnet", "cfn-opsworks-stack-defaultsubnet")
                .Replace("usecustcookbooks", "cfn-opsworks-stack-usecustcookbooks")
                .Replace("cfn-stepfunctions-statemachine-statemachinename", "cfn-stepfunctions-statemachine-definitionname")
                .Replace("cfn-dax-parametergroup-parameternamevalues", "cfn-dax-parametergroup-name-values")
                .Replace("cfn-dax-parametergroup-parametergroupname", "cfn-dax-parametergroup-name")
                .Replace("cfn-emr-instancegroupconfiginstancecount-", "cfn-emr-instancegroupconfig-instancecount")
                .Replace("cfn-autoscaling-lifecyclehook-lifecyclehookname", "cfn-as-lifecyclehook-lifecyclehookname")
                .Replace("cfn-elasticache-replicationgroup-snapshotretentionlimit", "cfn-elasticache-replicationgroup-snapshotrentionlimit")
                .Replace("cfn-apigateway-restapi-failonwarnings", "cfn-apigateway-restapi-failonwarning")
                .Replace("cfn-dax-cluster-replicationfactor", "cfn-dax-cluster-replication-factor")
                .Replace("cfn-dax-cluster-parametergroupname", "cfn-dax-cluster-parameter-group-name")
                .Replace("cfn-dax-cluster-availabilityzones", "cfn-dax-cluster-availability-zones")
                .Replace("cfn-dax-cluster-nodetype", "cfn-dax-cluster-node-type")
                .Replace("cfn-dax-cluster-iamrolearn", "cfn-dax-cluster-iam-role-arn")
                .Replace("cfn-dax-cluster-subnetgroupname", "cfn-dax-cluster-subnet-group-name")
                .Replace("cfn-dax-cluster-clustername", "cfn-dax-cluster-cluster-name")
                .Replace("cfn-dax-cluster-preferredmaintenancewindow", "cfn-dax-cluster-preferred-maintenance-window")
                .Replace("cfn-dax-cluster-notificationtopicarn", "cfn-dax-cluster-notification-topic-arn")
                .Replace("cfn-dax-cluster-securitygroupids", "cfn-dax-cluster-security-group-ids")
                .Replace("cfn-elasticmapreduce-step-", "cfn-emr-step-")
                .Replace("cfn-elasticbeanstalk-environment-tags", "cfn-beanstalk-environment-tags")
                .Replace("cfn-neptune-dbcluster-backupretentionperiod", "cfn-neptune-dbcluster-backuprententionperiod")
                .Replace("cfn-cognito-userpool-userpoolname", "cfn-cognito-userpool-poolname")
                .Replace("cfn-ec2-dhcpoptions-path", "cfn-iam-managedpolicy-path")
                .Replace("cfn-ecs-taskdefinition-containerdefinitions", "cfn-ecs-taskdefinition-containerdefinition")
                .Replace("cfn-elasticache-cachecluster-snapshotarns", "cfn-elasticache-cachecluster-snapshotarn")
                .Replace("cfn-elasticloadbalancingv2-targetgroup-targetgroupattributes", "cfn-elasticloadbalancingv2-targetgroup-targetattributes")
                .Replace("cfn-ssm-association-documentversion", "cfn-ssm-association-documentationversion")
                .Replace("aws-properties-s3-policy-", "cfn-s3-bucketpolicy-")
                .Replace("cfn-dms-replicationtask-replicationtasksettings", "cfn-dms-replicationtask-replicationstasksettings")
                .Replace("cfn-apigateway-usageplankey-", "cfn-apigateway-")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                //.Replace("", "")
                ;
            return key;
        }
    }
}
