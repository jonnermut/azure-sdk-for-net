// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyValuesCondition. </summary>
    public partial class AutomationRulePropertyValuesCondition
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

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyValuesCondition"/>. </summary>
        public AutomationRulePropertyValuesCondition()
        {
            PropertyValues = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyValuesCondition"/>. </summary>
        /// <param name="propertyName"> The property to evaluate in an automation rule property condition. </param>
        /// <param name="operator"></param>
        /// <param name="propertyValues"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationRulePropertyValuesCondition(AutomationRulePropertyConditionSupportedProperty? propertyName, AutomationRulePropertyConditionSupportedOperator? @operator, IList<string> propertyValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PropertyName = propertyName;
            Operator = @operator;
            PropertyValues = propertyValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The property to evaluate in an automation rule property condition. </summary>
        public AutomationRulePropertyConditionSupportedProperty? PropertyName { get; set; }
        /// <summary> Gets or sets the operator. </summary>
        public AutomationRulePropertyConditionSupportedOperator? Operator { get; set; }
        /// <summary> Gets the property values. </summary>
        public IList<string> PropertyValues { get; }
    }
}
