// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class OracleIndexAnnotations : RelationalIndexAnnotations, IOracleIndexAnnotations
    {
        public OracleIndexAnnotations([NotNull] IIndex index)
            : base(index)
        {
        }

        protected OracleIndexAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
