﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using toast_ui.blazor_calendar.Models;

namespace toast_ui.blazor_calendar.Services.JsonConverters
{
    public class TUITaskViewJsonConverter : JsonConverter<TUITaskView>
    {
        public override TUITaskView Read(ref Utf8JsonReader reader,
                                    Type typeToConvert,
                                    JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            TUITaskView viewName,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (string item in viewName.Value)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
        }
    }
}
