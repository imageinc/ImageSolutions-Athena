﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Permissions;
using System.Web.Compilation;
using System.CodeDom;
using System.Web.UI;

/// <summary>
/// Summary description for CodeExpressionBuilder
/// </summary>
[ExpressionPrefix("Code")]
public class CodeExpressionBuilder : ExpressionBuilder
{
    public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context)
    {
        return new CodeSnippetExpression(entry.Expression);
    }
}
