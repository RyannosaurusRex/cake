// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Cake.Core
{
    /// <summary>
    /// Acts as a context providing info about the overall build following its completion
    /// </summary>
    public interface ITeardownContext
    {
        /// <summary>
        /// Gets a value indicating whether this build was successful
        /// </summary>
        /// <value>
        /// <c>true</c> if successful; otherwise <c>false</c>.
        /// </value>
        bool Successful { get; }
    }
}