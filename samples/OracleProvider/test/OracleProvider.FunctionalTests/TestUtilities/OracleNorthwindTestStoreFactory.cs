// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public class OracleNorthwindTestStoreFactory : OracleTestStoreFactory
    {
        public const string Name = "Northwind";
        public static readonly string NorthwindConnectionString = OracleTestStore.CreateConnectionString(Name);
        public new static OracleNorthwindTestStoreFactory Instance { get; } = new OracleNorthwindTestStoreFactory();

        protected OracleNorthwindTestStoreFactory()
        {
        }

        public override TestStore GetOrCreate(string storeName)
            => OracleTestStore.GetOrCreate(Name, "Northwind.sql");
    }
}
