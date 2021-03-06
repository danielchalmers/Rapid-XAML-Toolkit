﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.Text;
using RapidXamlToolkit.Resources;
using RapidXamlToolkit.XamlAnalysis.Actions;

namespace RapidXamlToolkit.XamlAnalysis.Tags
{
    public class UseMediaPlayerElementTag : RapidXamlWarningTag
    {
        // https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Controls.MediaElement#remarks
        public UseMediaPlayerElementTag(Span span, ITextSnapshot snapshot, int line, int column)
            : base(span, snapshot, "RXT402", line, column)
        {
            this.SuggestedAction = null;
            this.ToolTip = StringRes.Info_XamlAnalysisUseMediaPlayerElementToolTip;
            this.Description = StringRes.Info_XamlAnalysisUseMediaPlayerElementDescription;
            this.ExtendedMessage = StringRes.Info_XamlAnalysisUseMediaPlayerElementExtendedMessage;
        }
    }
}
