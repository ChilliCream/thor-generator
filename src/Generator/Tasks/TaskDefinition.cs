﻿using System;
using System.Collections.Generic;

namespace ChilliCream.Tracing.Generator.Tasks
{
    internal sealed class TaskDefinition
    {
        public Type TaskType { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public List<ArgumentDefinition> PositionalArguments { get; } = new List<ArgumentDefinition>();
        public Dictionary<string, ArgumentDefinition> Arguments { get; } = new Dictionary<string, ArgumentDefinition>();
    }
}