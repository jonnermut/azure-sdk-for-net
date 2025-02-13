// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageActiveDirectoryProperties : IUtf8JsonSerializable, IJsonModel<StorageActiveDirectoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageActiveDirectoryProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageActiveDirectoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            if (Optional.IsDefined(NetBiosDomainName))
            {
                writer.WritePropertyName("netBiosDomainName"u8);
                writer.WriteStringValue(NetBiosDomainName);
            }
            if (Optional.IsDefined(ForestName))
            {
                writer.WritePropertyName("forestName"u8);
                writer.WriteStringValue(ForestName);
            }
            writer.WritePropertyName("domainGuid"u8);
            writer.WriteStringValue(DomainGuid);
            if (Optional.IsDefined(DomainSid))
            {
                writer.WritePropertyName("domainSid"u8);
                writer.WriteStringValue(DomainSid);
            }
            if (Optional.IsDefined(AzureStorageSid))
            {
                writer.WritePropertyName("azureStorageSid"u8);
                writer.WriteStringValue(AzureStorageSid);
            }
            if (Optional.IsDefined(SamAccountName))
            {
                writer.WritePropertyName("samAccountName"u8);
                writer.WriteStringValue(SamAccountName);
            }
            if (Optional.IsDefined(AccountType))
            {
                writer.WritePropertyName("accountType"u8);
                writer.WriteStringValue(AccountType.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StorageActiveDirectoryProperties IJsonModel<StorageActiveDirectoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageActiveDirectoryProperties(document.RootElement, options);
        }

        internal static StorageActiveDirectoryProperties DeserializeStorageActiveDirectoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            Optional<string> netBiosDomainName = default;
            Optional<string> forestName = default;
            Guid domainGuid = default;
            Optional<string> domainSid = default;
            Optional<string> azureStorageSid = default;
            Optional<string> samAccountName = default;
            Optional<ActiveDirectoryAccountType> accountType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netBiosDomainName"u8))
                {
                    netBiosDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forestName"u8))
                {
                    forestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainGuid"u8))
                {
                    domainGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("domainSid"u8))
                {
                    domainSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageSid"u8))
                {
                    azureStorageSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("samAccountName"u8))
                {
                    samAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountType = new ActiveDirectoryAccountType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageActiveDirectoryProperties(domainName, netBiosDomainName.Value, forestName.Value, domainGuid, domainSid.Value, azureStorageSid.Value, samAccountName.Value, Optional.ToNullable(accountType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageActiveDirectoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support '{options.Format}' format.");
            }
        }

        StorageActiveDirectoryProperties IPersistableModel<StorageActiveDirectoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageActiveDirectoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageActiveDirectoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
