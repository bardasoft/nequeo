// Warning 169 (Disables the 'Never used' warning)
#pragma warning disable 169
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.CloudInteraction.Data.Extension
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
    using Nequeo.Data.DataType;
    using Nequeo.Data;
    using Nequeo.Data.Linq;
    using Nequeo.Data.Control;
    using Nequeo.Data.Custom;
    using Nequeo.Data.LinqToSql;
    using Nequeo.Data.DataSet;
    using Nequeo.Data.Edm;
    using Nequeo.ComponentModel;
    using Data = Nequeo.DataAccess.CloudInteraction.Data;
    
    
    #region Nonce Data Extension Type
    /// <summary>
    /// The nonce replica object class.
    /// </summary>
    public partial class Nonce : DataBase<Data.Nonce>, IDisposable
    {
        
        private const string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.CloudInteraction.Properties.Settings.CloudInteractionDatabaseConnection";
        
        private string _connectionConfigKey = "Nequeo.DataAccess.CloudInteraction.Properties.Settings.CloudInteractionDatabaseConnection";
        
        private Nequeo.Data.DataType.ConnectionContext.ConnectionType _connectionType = Nequeo.Data.DataType.ConnectionContext.ConnectionType.SqlConnection;
        
        private Nequeo.Data.DataType.ConnectionContext.ConnectionDataType _connectionDataType = Nequeo.Data.DataType.ConnectionContext.ConnectionDataType.SqlDataType;
        
        private ISelectDataGenericBase<Data.Nonce> SelectContext;
        
        private IDeleteDataGenericBase<Data.Nonce> DeleteContext;
        
        private IInsertDataGenericBase<Data.Nonce> InsertContext;
        
        private IUpdateDataGenericBase<Data.Nonce> UpdateContext;
        
        private ICommonDataGenericBase<Data.Nonce> CommonContext;
        
        private Data.DataContext Context;
        
        private bool _referenceLazyLoading = false;
        
        #region Extensibility Method Definitions
        /// <summary>
        /// On create data entity.
        /// </summary>
		partial void OnCreated();

		#endregion
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Nonce() : 
                base(defaultDatabaseConnectionConfigurationKey, Nequeo.Data.DataType.ConnectionContext.ConnectionType.SqlConnection, Nequeo.Data.DataType.ConnectionContext.ConnectionDataType.SqlDataType, new Nequeo.Data.SqlServer.DataAccess())
        {
            OnCreated();
            _connectionConfigKey = defaultDatabaseConnectionConfigurationKey;
            _connectionType = Nequeo.Data.DataType.ConnectionContext.ConnectionType.SqlConnection;
            _connectionDataType = Nequeo.Data.DataType.ConnectionContext.ConnectionDataType.SqlDataType;
        }
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="connectionConfigKey">The database connection configuration key.</param>
        /// <param name="connectionType">The connection type.</param>
        /// <param name="connectionDataType">The connection data type.</param>
        /// <param name="dataAccessProvider">The data access provider.</param>
        public Nonce(string connectionConfigKey, Nequeo.Data.DataType.ConnectionContext.ConnectionType connectionType, Nequeo.Data.DataType.ConnectionContext.ConnectionDataType connectionDataType, Nequeo.Data.DataType.IDataAccess dataAccessProvider) : 
                base(connectionConfigKey, connectionType, connectionDataType, dataAccessProvider)
        {
            OnCreated();
            _connectionConfigKey = connectionConfigKey;
            _connectionType = connectionType;
            _connectionDataType = connectionDataType;
        }
        
        /// <summary>
        /// Gets, the select property override.
        /// </summary>
        public new ISelectDataGenericBase<Data.Nonce> Select
        {
            get
            {
                this.SelectContext = base.Select;
                this.SelectContext.LazyLoading = _referenceLazyLoading;
                return this.SelectContext;
            }
        }
        
        /// <summary>
        /// Gets, the delete property override.
        /// </summary>
        public new IDeleteDataGenericBase<Data.Nonce> Delete
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
        public new IInsertDataGenericBase<Data.Nonce> Insert
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
        public new IUpdateDataGenericBase<Data.Nonce> Update
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
        public new ICommonDataGenericBase<Data.Nonce> Common
        {
            get
            {
                this.CommonContext = base.Common;
                return this.CommonContext;
            }
        }
        
        /// <summary>
        /// Gets, the nonce entity table property for the object.
        /// </summary>
        public Data.DataContext DataContext
        {
            get
            {
                return new Data.DataContext(_connectionConfigKey, _connectionType, _connectionDataType, new Nequeo.Data.SqlServer.DataAccess());
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
        /// Gets the Data.Nonce queryable provider.
        /// </summary>
        /// <returns>The object queryable provider.</returns>
        public static Nequeo.Linq.QueryableProvider<Data.Nonce> QueryableProvider()
        {
            return new Nonce().Select.QueryableProvider();
        }
    }
    #endregion
}

#pragma warning restore 169
