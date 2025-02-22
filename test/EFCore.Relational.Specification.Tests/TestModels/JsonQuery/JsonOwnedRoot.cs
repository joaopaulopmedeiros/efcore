﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.TestModels.JsonQuery
{
    public class JsonOwnedRoot
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public JsonOwnedBranch OwnedReferenceBranch { get; set; }
        public List<JsonOwnedBranch> OwnedCollectionBranch { get; set; }

        public JsonEntityBasic Owner { get; set; }
    }
}
