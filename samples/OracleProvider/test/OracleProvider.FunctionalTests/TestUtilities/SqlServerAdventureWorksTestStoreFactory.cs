// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public class OracleAdventureWorksTestStoreFactory : OracleTestStoreFactory
    {
        public new static OracleAdventureWorksTestStoreFactory Instance { get; } = new OracleAdventureWorksTestStoreFactory();

        protected OracleAdventureWorksTestStoreFactory()
        {
        }

        public override TestStore GetOrCreate(string storeName)
            => OracleTestStore.GetOrCreate(
                "adventureworks",
                Path.Combine("SqlAzure", "adventureworks.sql"));
    }
}
