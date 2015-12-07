// Warning 169 (Disables the 'Never used' warning)
#pragma warning disable 169

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Edm.Model
{
    using System;
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
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Linq;
    using System.Data.Entity;
    using System.Data.Linq.SqlClient;
    using System.Data.Linq.Mapping;
    using Nequeo.Data.Base.Exception;
    using Nequeo.Data.DataAccess.Control.Generic;
    using Nequeo.Data.DataAccess.Control.Generic.Data;
    using Nequeo.Data.DataAccess.Control.Generic.Edm;
    using Nequeo.Data.Enumeration;
    using Nequeo.Data.Controller.Custom;
    using Nequeo.Data.Controller.Extension;
    using Data = Nequeo.DataAccess.ApplicationLogin.Data;
    using Edm = Nequeo.DataAccess.ApplicationLogin.Edm;
    
    
    /// <summary>
    /// The user model object class.
    /// </summary>
    public partial class User : EdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User>, IDisposable
    {
        
        private const string modelItem = "_User";
        
        private string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.ApplicationLogin.Properties.Settings.ApplicationLoginDatabaseConnection";
        
        private DataContextBase.ConnectionType _connectionType = DataContextBase.ConnectionType.SqlConnection;
        
        private DataContextBase.ConnectionDataType _connectionDataType = DataContextBase.ConnectionDataType.SqlDataType;
        
        private ISelectEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> SelectContext;
        
        private IDeleteEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> DeleteContext;
        
        private IInsertEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> InsertContext;
        
        private IUpdateEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> UpdateContext;
        
        private EdmDataGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> CommonContext;
        
        private Edm.CommonEntityContext Context;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public User() : 
                base(modelItem, DataContextBase.ConnectionType.SqlConnection, DataContextBase.ConnectionDataType.SqlDataType)
        {
            _connectionType = DataContextBase.ConnectionType.SqlConnection;
            _connectionDataType = DataContextBase.ConnectionDataType.SqlDataType;
        }
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="connectionConfigKey">The database connection configuration key.</param>
        /// <param name="connectionType">The connection type.</param>
        /// <param name="connectionDataType">The connection data type.</param>
        public User(string connectionConfigKey, DataContextBase.ConnectionType connectionType, DataContextBase.ConnectionDataType connectionDataType) : 
                base(modelItem, connectionType, connectionDataType)
        {
            defaultDatabaseConnectionConfigurationKey = connectionConfigKey;
            _connectionType = connectionType;
            _connectionDataType = connectionDataType;
        }
        
        /// <summary>
        /// Gets, the select property override.
        /// </summary>
        public new ISelectEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> Select
        {
            get
            {
                this.SelectContext = base.Select;
                this.SelectContext.DataContext = new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
                return this.SelectContext;
            }
        }
        
        /// <summary>
        /// Gets, the delete property override.
        /// </summary>
        public new IDeleteEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> Delete
        {
            get
            {
                this.DeleteContext = base.Delete;
                this.DeleteContext.DataContext = new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
                return this.DeleteContext;
            }
        }
        
        /// <summary>
        /// Gets, the insert property override.
        /// </summary>
        public new IInsertEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> Insert
        {
            get
            {
                this.InsertContext = base.Insert;
                this.InsertContext.DataContext = new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
                return this.InsertContext;
            }
        }
        
        /// <summary>
        /// Gets, the update property override.
        /// </summary>
        public new IUpdateEdmGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> Update
        {
            get
            {
                this.UpdateContext = base.Update;
                this.UpdateContext.DataContext = new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
                return this.UpdateContext;
            }
        }
        
        /// <summary>
        /// Gets, the common property override.
        /// </summary>
        public new EdmDataGenericBase<Edm.CommonEntityContext, Edm.User, Data.User> Common
        {
            get
            {
                this.CommonContext = base.Common;
                this.CommonContext.DataContext = new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
                return this.CommonContext;
            }
        }
        
        /// <summary>
        /// Gets, the user entity table property for the object.
        /// </summary>
        public Edm.CommonEntityContext DataContext
        {
            get
            {
                return new Edm.CommonEntityContext(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
            }
        }
        
        /// <summary>
        /// Get the default database connection string.
        /// </summary>
        /// <returns>The default connection string.</returns>
        public virtual String DefaultDatabaseConnection()
        {
            return base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey);
        }
    }
}
#pragma warning restore 169

