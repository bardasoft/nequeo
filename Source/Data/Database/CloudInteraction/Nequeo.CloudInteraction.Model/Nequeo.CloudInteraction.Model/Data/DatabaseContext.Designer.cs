//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.CloudInteraction.Data
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Threading;
    using System.Diagnostics;
    using System.Data.SqlClient;
    using System.Data.OleDb;
    using System.Data.Odbc;
    using System.Collections;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.ComponentModel;
    using Nequeo.Data.DataType;
    using Nequeo.Data;
    using Nequeo.Data.Linq;
    using Nequeo.Data.Control;
    using Nequeo.Data.Custom;
    using Nequeo.Data.LinqToSql;
    using Nequeo.Data.DataSet;
    using Nequeo.Data.Edm;
    using Nequeo.ComponentModel;
    
    
    #region DataContext Context Ling Type
    /// <summary>
    /// The datacontext data context object class.
    /// </summary>
    [DatabaseAttribute("CloudInteraction")]
    public partial class DataContext : DataContextBase
    {
        
        private const string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.CloudInteraction.Properties.Settings.CloudInteractionDatabaseConnection";
        
        #region Extensibility Method Definitions
        /// <summary>
        /// On create data entity.
        /// </summary>
		partial void OnCreated();

        /// <summary>
        /// On load data entity.
        /// </summary>
		partial void OnLoaded();

		#endregion
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public DataContext() : 
                base(defaultDatabaseConnectionConfigurationKey, Nequeo.Data.DataType.ConnectionContext.ConnectionType.SqlConnection, Nequeo.Data.DataType.ConnectionContext.ConnectionDataType.SqlDataType, new Nequeo.Data.SqlServer.DataAccess())
        {
            OnCreated();
        }
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="connectionConfigKey">The database connection configuration key.</param>
        /// <param name="connectionType">The connection type.</param>
        /// <param name="connectionDataType">The connection data type.</param>
        /// <param name="dataAccessProvider">The data access provider.</param>
        public DataContext(string connectionConfigKey, Nequeo.Data.DataType.ConnectionContext.ConnectionType connectionType, Nequeo.Data.DataType.ConnectionContext.ConnectionDataType connectionDataType, Nequeo.Data.DataType.IDataAccess dataAccessProvider) : 
                base(connectionConfigKey, connectionType, connectionDataType, dataAccessProvider)
        {
            OnCreated();
        }
        
        #region Public Ling Properties
        /// <summary>
        /// Gets, the user queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.User> Users
        {
            get
            {
                return this.GetTable<Data.User>();
            }
        }
        
        /// <summary>
        /// Gets, the role queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Role> Roles
        {
            get
            {
                return this.GetTable<Data.Role>();
            }
        }
        
        /// <summary>
        /// Gets, the oauthconsumer queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.OAuthConsumer> OAuthConsumers
        {
            get
            {
                return this.GetTable<Data.OAuthConsumer>();
            }
        }
        
        /// <summary>
        /// Gets, the clientauthorization queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ClientAuthorization> ClientAuthorizations
        {
            get
            {
                return this.GetTable<Data.ClientAuthorization>();
            }
        }
        
        /// <summary>
        /// Gets, the oauthtoken queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.OAuthToken> OAuthTokens
        {
            get
            {
                return this.GetTable<Data.OAuthToken>();
            }
        }
        
        /// <summary>
        /// Gets, the profile queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Profile> Profiles
        {
            get
            {
                return this.GetTable<Data.Profile>();
            }
        }
        
        /// <summary>
        /// Gets, the profilevalue queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ProfileValue> ProfileValues
        {
            get
            {
                return this.GetTable<Data.ProfileValue>();
            }
        }
        
        /// <summary>
        /// Gets, the contacttype queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ContactType> ContactTypes
        {
            get
            {
                return this.GetTable<Data.ContactType>();
            }
        }
        
        /// <summary>
        /// Gets, the contact queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Contact> Contacts
        {
            get
            {
                return this.GetTable<Data.Contact>();
            }
        }
        
        /// <summary>
        /// Gets, the client queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Client> Clients
        {
            get
            {
                return this.GetTable<Data.Client>();
            }
        }
        
        /// <summary>
        /// Gets, the symmetriccryptokey queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.SymmetricCryptoKey> SymmetricCryptoKeies
        {
            get
            {
                return this.GetTable<Data.SymmetricCryptoKey>();
            }
        }
        
        /// <summary>
        /// Gets, the nonce queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Nonce> Nonces
        {
            get
            {
                return this.GetTable<Data.Nonce>();
            }
        }
        #endregion
    }
    #endregion
}