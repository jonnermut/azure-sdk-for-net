// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryTargetExtendedLocation : IUtf8JsonSerializable, IJsonModel<GalleryTargetExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryTargetExtendedLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryTargetExtendedLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryTargetExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryTargetExtendedLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(ExtendedLocationReplicaCount))
            {
                writer.WritePropertyName("extendedLocationReplicaCount"u8);
                writer.WriteNumberValue(ExtendedLocationReplicaCount.Value);
            }
            if (Optional.IsDefined(GalleryStorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(GalleryStorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
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

        GalleryTargetExtendedLocation IJsonModel<GalleryTargetExtendedLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryTargetExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryTargetExtendedLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryTargetExtendedLocation(document.RootElement, options);
        }

        internal static GalleryTargetExtendedLocation DeserializeGalleryTargetExtendedLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<GalleryExtendedLocation> extendedLocation = default;
            Optional<int> extendedLocationReplicaCount = default;
            Optional<EdgeZoneStorageAccountType> storageAccountType = default;
            Optional<EncryptionImages> encryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = GalleryExtendedLocation.DeserializeGalleryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocationReplicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocationReplicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new EdgeZoneStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = EncryptionImages.DeserializeEncryptionImages(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryTargetExtendedLocation(name.Value, extendedLocation.Value, Optional.ToNullable(extendedLocationReplicaCount), Optional.ToNullable(storageAccountType), encryption.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryTargetExtendedLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryTargetExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryTargetExtendedLocation)} does not support '{options.Format}' format.");
            }
        }

        GalleryTargetExtendedLocation IPersistableModel<GalleryTargetExtendedLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryTargetExtendedLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryTargetExtendedLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryTargetExtendedLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryTargetExtendedLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
