﻿using System;

namespace oclockvn.Extensions
{
    public static class ExceptionExtension
    {
        public static string ToErrorMessage(this Exception ex, string tag = "Exception", int loop = 1)
        {
            return (ex == null || loop >= 5) 
                ? string.Empty
                : $"[{tag}] => {ex.Message} \r\n {ex.InnerException?.ToErrorMessage($"Inner {loop}", loop++)}";
        }
    }
}
