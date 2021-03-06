﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.Text;
using RapidXamlToolkit.Resources;
using RapidXamlToolkit.XamlAnalysis.Actions;

namespace RapidXamlToolkit.XamlAnalysis.Tags
{
    public class ColumnSpanOverflowTag : MissingDefinitionTag
    {
        public ColumnSpanOverflowTag(Span span, ITextSnapshot snapshot, int line, int column)
            : base(span, snapshot, "RT104", line, column)
        {
            this.SuggestedAction = typeof(ColumnSpanOverflowAction);
            this.ToolTip = StringRes.Info_XamlAnalysisColumnSpanOverflowTooltip;
        }
    }
}
