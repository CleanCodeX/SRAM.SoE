﻿using System;

namespace SramFormat.SoE.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceLineBreaks(this string source) => source
            .Replace(Environment.NewLine + Environment.NewLine, " | ")
            .Replace(Environment.NewLine, ", ");
    }
}
