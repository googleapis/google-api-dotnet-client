/*
Copyright 2023 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Globalization;

namespace Google.Apis.Tests;

/// <summary>
/// Disposable class to help test code in different cultures.
/// On construction, this changes the current thread's current culture
/// to the specified one (and remembers the original culture). On disposal,
/// the original culture is restored.
/// </summary>
internal class CultureSwitcher : IDisposable
{
    private readonly CultureInfo _originalCulture;

    /// <summary>
    /// Creates a new instance based on the name of the culture to switch to.
    /// </summary>
    internal CultureSwitcher(string name) : this(new CultureInfo(name))
    {
    }

    /// <summary>
    /// Creates a new instance switching to the specified culture.
    /// </summary>
    internal CultureSwitcher(CultureInfo newCulture)
    {
        _originalCulture = CultureInfo.CurrentCulture;
        SetCulture(newCulture);
    }

    public void Dispose() => SetCulture(_originalCulture);

    private void SetCulture(CultureInfo culture)
    {
        // CultureInfo.CurrentCulture is the preferred way to set this,
        // but it was read-only on .NET Framework before v4.6.
#if NET452
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;
#else
        CultureInfo.CurrentCulture = culture;
#endif
    }
}
