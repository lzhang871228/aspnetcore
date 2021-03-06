// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Http.Result
{
    internal sealed class ConflictObjectResult : ObjectResult
    {
        public ConflictObjectResult(object? error) :
            base(error, StatusCodes.Status409Conflict)
        {
        }
    }
}
