// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties to update namespace. </summary>
    public partial class EventGridNamespacePatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EventGridNamespacePatch"/>. </summary>
        public EventGridNamespacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespacePatch"/>. </summary>
        /// <param name="tags"> Tags of the namespace resource. </param>
        /// <param name="identity"> Namespace resource identity information. </param>
        /// <param name="sku"> Represents available Sku pricing tiers. </param>
        /// <param name="topicSpacesConfiguration"> Topic spaces configuration properties that can be updated. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PubSub.NamespaceUpdateParameterProperties.InboundIpRules" /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridNamespacePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, NamespaceSku sku, UpdateTopicSpacesConfigurationInfo topicSpacesConfiguration, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            Sku = sku;
            TopicSpacesConfiguration = topicSpacesConfiguration;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tags of the namespace resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Namespace resource identity information. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Represents available Sku pricing tiers. </summary>
        public NamespaceSku Sku { get; set; }
        /// <summary> Topic spaces configuration properties that can be updated. </summary>
        public UpdateTopicSpacesConfigurationInfo TopicSpacesConfiguration { get; set; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PubSub.NamespaceUpdateParameterProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
    }
}
