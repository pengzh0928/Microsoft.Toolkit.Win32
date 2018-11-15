﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Forms.UI.XamlHost;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;

namespace Microsoft.Toolkit.Forms.UI.Controls
{
    public class RichEditBox : WindowsXamlHostBase
    {
        internal Windows.UI.Xaml.Controls.RichEditBox UwpControl => GetUwpInternalObject() as Windows.UI.Xaml.Controls.RichEditBox;

        public RichEditBox()
            : this(typeof(Windows.UI.Xaml.Controls.RichEditBox).FullName)
        {
        }

        protected RichEditBox(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Gets or sets <see cref="Windows.UI.Xaml.Controls.RichEditBox.PlaceholderText"/>
        /// </summary>
        public string PlaceholderText
        {
            get => UwpControl.PlaceholderText;
            set => UwpControl.PlaceholderText = value;
        }
    }
}