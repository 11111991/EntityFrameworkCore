// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class OracleEntityTypeAnnotations : RelationalEntityTypeAnnotations, IOracleEntityTypeAnnotations
    {
        public OracleEntityTypeAnnotations([NotNull] IEntityType entityType)
            : base(entityType)
        {
        }

        public OracleEntityTypeAnnotations([NotNull] RelationalAnnotations annotations)
            : base(annotations)
        {
        }
    }
}
