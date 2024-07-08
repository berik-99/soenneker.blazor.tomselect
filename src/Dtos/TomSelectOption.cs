﻿using System.Text.Json.Serialization;

namespace Soenneker.Blazor.TomSelect.Dtos;

/// <summary>
/// Represents a single option in the configuration.
/// </summary>
public class TomSelectOption
{
    /// <summary>
    /// The value of the option.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = default!;

    /// <summary>
    /// The display text of the option.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = default!;

    /// <summary>
    /// The underlying item of the option.
    /// </summary>
    [JsonPropertyName("item")]
    public object? Item { get; set; }
}