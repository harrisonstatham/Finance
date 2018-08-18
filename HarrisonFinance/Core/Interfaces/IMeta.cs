// ===========================================================
//   IMeta.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//   Meta information describes the current financial object in readable
//   form that might be used in conversation or documentation.
//

using System;


namespace HarrisonFinance.Core
{
    public interface IMeta
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; set; }
    }
}
