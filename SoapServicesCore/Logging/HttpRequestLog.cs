﻿using System.Buffers;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoapServicesCore.Logging;

public class HttpRequestLog : IReadOnlyList<KeyValuePair<string, object?>>
{
    private readonly List<KeyValuePair<string, object?>> _keyValues;
    private string? _cachedToString;

    internal static readonly Func<object, Exception?, string> Callback = (state, exception) => ((HttpRequestLog)state).ToString();

    public HttpRequestLog(List<KeyValuePair<string, object?>> keyValues)
    {
        _keyValues = keyValues;
    }

    public KeyValuePair<string, object?> this[int index] => _keyValues[index];

    public int Count => _keyValues.Count;

    public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
    {
        var count = _keyValues.Count;
        for (var i = 0; i < count; i++)
        {
            yield return _keyValues[i];
        }
    }

    public override string ToString()
    {
        if (_cachedToString == null)
        {
            // Use 2kb as a rough average size for request headers
            var builder = new ValueStringBuilder(2 * 1024);
            var count = _keyValues.Count;
            builder.Append("Request:");
            builder.Append(Environment.NewLine);

            for (var i = 0; i < count - 1; i++)
            {
                var kvp = _keyValues[i];
                builder.Append(kvp.Key);
                builder.Append(": ");
                builder.Append(kvp.Value?.ToString());
                builder.Append(Environment.NewLine);
            }

            if (count > 0)
            {
                var kvp = _keyValues[count - 1];
                builder.Append(kvp.Key);
                builder.Append(": ");
                builder.Append(kvp.Value?.ToString());
            }

            _cachedToString = builder.ToString();
        }

        return _cachedToString;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}