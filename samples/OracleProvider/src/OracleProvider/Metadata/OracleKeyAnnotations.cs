// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class OracleKeyAnnotations : RelationalKeyAnnotations, IOracleKeyAnnotations
    {
        public OracleKeyAnnotations([NotNull] IKey key)
            : base(key)
        {
        }

        protected OracleKeyAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
