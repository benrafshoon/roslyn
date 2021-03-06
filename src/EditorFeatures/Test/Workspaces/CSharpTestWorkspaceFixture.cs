// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Editor.UnitTests.Workspaces
{
    public class CSharpTestWorkspaceFixture : TestWorkspaceFixture
    {
        public CSharpTestWorkspaceFixture()
        {
            this.Workspace = CSharpWorkspaceFactory.CreateWorkspaceFromFiles(
                new string[] { string.Empty, },
                new CSharpParseOptions[] { new CSharpParseOptions(kind: SourceCodeKind.Regular), });
        }
    }
}
