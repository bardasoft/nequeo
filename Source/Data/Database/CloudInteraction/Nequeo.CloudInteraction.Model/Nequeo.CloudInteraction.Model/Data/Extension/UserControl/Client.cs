﻿/*  Company :       Nequeo Pty Ltd, http://www.Nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2008 http://www.nequeo.com.au/
 * 
 *  File :          User.cs
 *  Purpose :       
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;

using Nequeo.Data.DataType;
using Nequeo.Data;
using Nequeo.Data.Linq;
using Nequeo.Data.Control;
using Nequeo.Data.Custom;
using Nequeo.Data.LinqToSql;
using Nequeo.Data.DataSet;
using Nequeo.Data.Edm;
using Nequeo.Net.ServiceModel.Common;
using Nequeo.Data.TypeExtenders;
using Nequeo.Data.Extension;

namespace Nequeo.DataAccess.CloudInteraction.Data.Extension
{
    /// <summary>
    /// The user data member extension.
    /// </summary>
    public partial class Client
    {
        /// <summary>
        /// validate the client details.
        /// </summary>
        /// <param name="clientIdentifier">The client identity.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <returns>The current user else null.</returns>
        public virtual Data.Client ValidateClient(string clientIdentifier, string clientSecret)
        {
            return Select.SelectDataEntity(
                u => 
                    (u.ClientIdentifier == clientIdentifier) && 
                    (u.ClientSecret == clientSecret));
        }
    }
}
