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

namespace Nequeo.DataAccess.ApplicationLogin.Data.Extension
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
    using System.Data.Linq.SqlClient;
    using System.Data.Linq.Mapping;
    using Nequeo.Data.Base.Exception;
    using Nequeo.Data.DataAccess.Control.Generic;
    using Nequeo.Data.DataAccess.Control.Generic.Data;
    using Nequeo.Data.Enumeration;
    using Nequeo.Data.Controller.Custom;
    using Nequeo.Data.Controller.Extension;
    using Data = Nequeo.DataAccess.ApplicationLogin.Data;
    
    
    /// <summary>
    /// The application replica object class.
    /// </summary>
    public partial class Application : DataBase<Data.Application>, IDisposable
    {
        
        private const string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.ApplicationLogin.Properties.Settings.ApplicationLoginDatabaseConnection";
        
        private string _connectionConfigKey = "Nequeo.DataAccess.ApplicationLogin.Properties.Settings.ApplicationLoginDatabaseConnection";
        
        private DataContextBase.ConnectionType _connectionType = DataContextBase.ConnectionType.SqlConnection;
        
        private DataContextBase.ConnectionDataType _connectionDataType = DataContextBase.ConnectionDataType.SqlDataType;
        
        private ISelectDataGenericBase<Data.Application> SelectContext;
        
        private IDeleteDataGenericBase<Data.Application> DeleteContext;
        
        private IInsertDataGenericBase<Data.Application> InsertContext;
        
        private IUpdateDataGenericBase<Data.Application> UpdateContext;
        
        private CommonDataGenericBase<Data.Application> CommonContext;
        
        private Data.DataContext Context;
        
        private bool _referenceLazyLoading = false;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Application() : 
                base(defaultDatabaseConnectionConfigurationKey, DataContextBase.ConnectionType.SqlConnection, DataContextBase.ConnectionDataType.SqlDataType)
        {
            _connectionConfigKey = defaultDatabaseConnectionConfigurationKey;
            _connectionType = DataContextBase.ConnectionType.SqlConnection;
            _connectionDataType = DataContextBase.ConnectionDataType.SqlDataType;
        }
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="connectionConfigKey">The database connection configuration key.</param>
        /// <param name="connectionType">The connection type.</param>
        /// <param name="connectionDataType">The connection data type.</param>
        public Application(string connectionConfigKey, DataContextBase.ConnectionType connectionType, DataContextBase.ConnectionDataType connectionDataType) : 
                base(connectionConfigKey, connectionType, connectionDataType)
        {
            _connectionConfigKey = connectionConfigKey;
            _connectionType = connectionType;
            _connectionDataType = connectionDataType;
        }
        
        /// <summary>
        /// Gets, the select property override.
        /// </summary>
        public new ISelectDataGenericBase<Data.Application> Select
        {
            get
            {
                this.SelectContext = base.Select;
                this.SelectContext.ReferenceLazyLoading = _referenceLazyLoading;
                return this.SelectContext;
            }
        }
        
        /// <summary>
        /// Gets, the delete property override.
        /// </summary>
        public new IDeleteDataGenericBase<Data.Application> Delete
        {
            get
            {
                this.DeleteContext = base.Delete;
                return this.DeleteContext;
            }
        }
        
        /// <summary>
        /// Gets, the insert property override.
        /// </summary>
        public new IInsertDataGenericBase<Data.Application> Insert
        {
            get
            {
                this.InsertContext = base.Insert;
                return this.InsertContext;
            }
        }
        
        /// <summary>
        /// Gets, the update property override.
        /// </summary>
        public new IUpdateDataGenericBase<Data.Application> Update
        {
            get
            {
                this.UpdateContext = base.Update;
                return this.UpdateContext;
            }
        }
        
        /// <summary>
        /// Gets, the common property override.
        /// </summary>
        public new CommonDataGenericBase<Data.Application> Common
        {
            get
            {
                this.CommonContext = base.Common;
                return this.CommonContext;
            }
        }
        
        /// <summary>
        /// Gets, the application entity table property for the object.
        /// </summary>
        public Data.DataContext DataContext
        {
            get
            {
                return new Data.DataContext(_connectionConfigKey, _connectionType, _connectionDataType);
            }
        }
        
        /// <summary>
        /// Gets sets, the reference lazy loading indicator.
        /// </summary>
        public bool LazyLoading
        {
            get
            {
                return this._referenceLazyLoading;
            }
            set
            {
                this._referenceLazyLoading = value;
            }
        }
        
        /// <summary>
        /// Get the default database connection string.
        /// </summary>
        /// <returns>The default connection string.</returns>
        public virtual String DefaultDatabaseConnection()
        {
            return base.Common.DefaultConnection(_connectionConfigKey);
        }
        
        /// <summary>
        /// Gets the Data.Application queryable provider.
        /// </summary>
        /// <returns>The object queryable provider.</returns>
        public static Nequeo.Data.Controller.Linq.QueryableProvider<Data.Application> QueryableProvider()
        {
            return new Application().Select.QueryableProvider();
        }
    }
}
#pragma warning restore 169

