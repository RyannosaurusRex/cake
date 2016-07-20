// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System;

namespace Cake.Core
{
    /// <summary>
    /// Acts as a context providing info about the overall build following its completion
    /// </summary>
    public sealed class TeardownContext : ITeardownContext
    {
        private readonly bool _successful;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeardownContext"/> class.
        /// </summary>
        /// <param name="successful">if set to <c>true</c>, the build was not successful.</param>
        public TeardownContext(bool successful)
        {
            _successful = successful;
        }

        /// <summary>
        /// Gets a value indicating whether this build was successful
        /// </summary>
        /// <value>
        /// <c>true</c> if successful; otherwise <c>false</c>.
        /// </value>
        public bool Successful
        {
            get { return _successful; }
        }
    }
}