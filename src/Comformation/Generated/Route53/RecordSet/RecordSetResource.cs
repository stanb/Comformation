using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSet
{
    /// <summary>
    /// AWS::Route53::RecordSet
    /// The AWS::Route53::RecordSet type can be used as a standalone resource or as an embedded property in the
    /// AWS::Route53::RecordSetGroup type. Note that some AWS::Route53::RecordSet properties are valid only when used
    /// within AWS::Route53::RecordSetGroup.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html
    /// </summary>
    public class RecordSetResource : ResourceBase
    {
        public class RecordSetProperties
        {
            /// <summary>
            /// AliasTarget
            /// Alias resource record sets only: Information about the domain to which you are redirecting traffic.
            /// If you specify this property, do not specify the TTL property. The alias uses a TTL value from the
            /// alias target record.
            /// For more information about alias resource record sets, see Creating Alias Resource Record Sets in
            /// the Route 53 Developer Guide and POST ChangeResourceRecordSets in the Route 53 API reference.
            /// Required: Conditional. Required if you are creating an alias resource record set.
            /// Type: AliasTarget
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-aliastarget
            /// </summary>
			public Union<AliasTarget, IntrinsicFunction> AliasTarget { get; set; }

            /// <summary>
            /// Comment
            /// Any comments that you want to include about the hosted zone.
            /// Important If the record set is part of a record set group, this property isn't valid. Don't specify
            /// this property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-comment
            /// </summary>
			public Union<string, IntrinsicFunction> Comment { get; set; }

            /// <summary>
            /// Failover
            /// Designates the record set as a PRIMARY or SECONDARY failover record set. When you have more than one
            /// resource performing the same function, you can configure Route 53 to check the health of your
            /// resources and use only health resources to respond to DNS queries. You cannot create nonfailover
            /// resource record sets that have the same Name and Type property values as failover resource record
            /// sets. For more information, see the Failover content in the Amazon Route 53 API Reference.
            /// If you specify this property, you must specify the SetIdentifier property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-failover
            /// </summary>
			public Union<string, IntrinsicFunction> Failover { get; set; }

            /// <summary>
            /// GeoLocation
            /// Describes how Route 53 responds to DNS queries based on the geographic origin of the query. This
            /// property is not compatible with the Region property.
            /// Required: No
            /// Type: Route 53 Record Set GeoLocation Property
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-geolocation
            /// </summary>
			public Union<GeoLocation, IntrinsicFunction> GeoLocation { get; set; }

            /// <summary>
            /// HealthCheckId
            /// The health check ID that you want to apply to this record set. Route 53 returns this resource record
            /// set in response to a DNS query only while record set is healthy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-healthcheckid
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckId { get; set; }

            /// <summary>
            /// HostedZoneId
            /// The ID of the hosted zone.
            /// Required: Conditional. You must specify either the HostedZoneName or HostedZoneId, but you cannot
            /// specify both. If this record set is part of a record set group, do not specify this property.
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzoneid
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

            /// <summary>
            /// HostedZoneName
            /// The name of the domain for the hosted zone where you want to add the record set.
            /// When you create a stack using an AWS::Route53::RecordSet that specifies HostedZoneName, AWS
            /// CloudFormation attempts to find a hosted zone whose name matches the HostedZoneName. If AWS
            /// CloudFormation cannot find a hosted zone with a matching domain name, or if there is more than one
            /// hosted zone with the specified domain name, AWS CloudFormation will not create the stack.
            /// If you have multiple hosted zones with the same domain name, you must explicitly specify the hosted
            /// zone using HostedZoneId.
            /// Required: Conditional. You must specify either the HostedZoneName or HostedZoneId, but you cannot
            /// specify both. If this record set is part of a record set group, do not specify this property.
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-hostedzonename
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneName { get; set; }

            /// <summary>
            /// Name
            /// The name of the domain. You must specify a fully qualified domain name that ends with a period as
            /// the last label indication. If you omit the final period, Route 53 adds it.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Region
            /// Latency resource record sets only: The Amazon EC2 region where the resource that is specified in
            /// this resource record set resides. The resource typically is an AWS resource, for example, Amazon EC2
            /// instance or an Elastic Load Balancing load balancer, and is referred to by an IP address or a DNS
            /// domain name, depending on the record type.
            /// When Route 53 receives a DNS query for a domain name and type for which you have created latency
            /// resource record sets, Route 53 selects the latency resource record set that has the lowest latency
            /// between the end user and the associated Amazon EC2 region. Route 53 then returns the value that is
            /// associated with the selected resource record set.
            /// The following restrictions must be followed:
            /// You can only specify one resource record per latency resource record set. You can only create one
            /// latency resource record set for each Amazon EC2 region. You are not required to create latency
            /// resource record sets for all Amazon EC2 regions. Route 53 will choose the region with the best
            /// latency from among the regions for which you create latency resource record sets. You cannot create
            /// both weighted and latency resource record sets that have the same values for the Name and Type
            /// elements. This property is not compatible with the GeoLocation property.
            /// To see a list of regions by service, see Regions and Endpoints in the AWS General Reference.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-region
            /// </summary>
			public Union<string, IntrinsicFunction> Region { get; set; }

            /// <summary>
            /// ResourceRecords
            /// List of resource records to add. Each record should be in the format appropriate for the record type
            /// specified by the Type property. For information about different record types and their record
            /// formats, see Values for Basic Resource Record Sets and Appendix: Domain Name Format in the Route 53
            /// Developer Guide.
            /// Required: Conditional. If you don't specify the AliasTarget property, you must specify this
            /// property. If you are creating an alias resource record set, do not specify this property.
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-resourcerecords
            /// </summary>
			public Union<List<string>, IntrinsicFunction> ResourceRecords { get; set; }

            /// <summary>
            /// SetIdentifier
            /// A unique identifier that differentiates among multiple resource record sets that have the same
            /// combination of DNS name and type.
            /// Required: Conditional. Required if you are creating a weighted, latency, failover, or geolocation
            /// resource record set.
            /// For more information, see the SetIdentifier content in the Route 53 Developer Guide.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-setidentifier
            /// </summary>
			public Union<string, IntrinsicFunction> SetIdentifier { get; set; }

            /// <summary>
            /// TTL
            /// The resource record cache time to live (TTL), in seconds. If you specify this property, do not
            /// specify the AliasTarget property. For alias target records, the alias uses a TTL value from the
            /// target.
            /// If you specify this property, you must specify the ResourceRecords property.
            /// Required: Conditional. If you don't specify the AliasTarget property, you must specify this
            /// property. If you are creating an alias resource record set, do not specify this property.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-ttl
            /// </summary>
			public Union<string, IntrinsicFunction> TTL { get; set; }

            /// <summary>
            /// Type
            /// The type of records to add. For valid values, see the Type content in the Amazon Route 53 API
            /// Reference.
            /// In AWS CloudFormation, you cannot modify the NS and SOA records for a hosted zone created
            /// automatically by Route 53. Specifically, you can't create or delete NS or SOA records for the root
            /// domain of your hosted zone, but you can create them for subdomains to delegate. For example, for
            /// hosted zone mydomain. net, you cannot create an NS record for mydomain. net but you can create an NS
            /// record for nnnn. mydomain. net for delegation.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Weight
            /// Weighted resource record sets only: Among resource record sets that have the same combination of DNS
            /// name and type, a value that determines what portion of traffic for the current resource record set
            /// is routed to the associated location.
            /// For more information about weighted resource record sets, see Setting Up Weighted Resource Record
            /// Sets in the Route 53 Developer Guide.
            /// Required: Conditional. Required if you are creating a weighted resource record set.
            /// Type: Number. Weight expects integer values.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset.html#cfn-route53-recordset-weight
            /// </summary>
			public Union<int, IntrinsicFunction> Weight { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::RecordSet";
        
        public RecordSetProperties Properties { get; } = new RecordSetProperties();
    }
}
