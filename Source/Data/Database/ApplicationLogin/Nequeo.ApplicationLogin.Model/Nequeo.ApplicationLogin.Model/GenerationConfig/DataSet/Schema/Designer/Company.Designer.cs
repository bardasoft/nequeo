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

namespace Nequeo.DataAccess.ApplicationLogin.DataSet.Schema
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
    using System.Data.Common;
    using System.Data.Linq.SqlClient;
    using System.Data.Linq.Mapping;
    using Nequeo.Data.Base.Exception;
    using Nequeo.Data.DataAccess.Control.Generic;
    using Nequeo.Data.DataAccess.Control.Generic.Data;
    using Nequeo.Data.DataAccess.Control.Generic.DataSet;
    using Nequeo.Data.Enumeration;
    using Nequeo.Data.Controller.Custom;
    using Nequeo.Data.Controller.Extension;
    using DataSet = Nequeo.DataAccess.ApplicationLogin.DataSet;
    using Data = Nequeo.DataAccess.ApplicationLogin.Data;
    
    
    /// <summary>
    /// The company schema object class.
    /// </summary>
    public partial class Company : DataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company>, IDisposable
    {
        
        private const string schemaItem = "_Company";
        
        private string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.ApplicationLogin.Properties.Settings.ApplicationLoginDatabaseConnection";
        
        private DataContextBase.ConnectionType _connectionType = DataContextBase.ConnectionType.SqlConnection;
        
        private DataContextBase.ConnectionDataType _connectionDataType = DataContextBase.ConnectionDataType.SqlDataType;
        
        private ISelectDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> SelectContext;
        
        private IDeleteDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> DeleteContext;
        
        private IInsertDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> InsertContext;
        
        private IUpdateDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> UpdateContext;
        
        private DataSetDataGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> CommonContext;
        
        private DataSet.Common Context;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Company() : 
                base(schemaItem, DataContextBase.ConnectionType.SqlConnection, DataContextBase.ConnectionDataType.SqlDataType)
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
        public Company(string connectionConfigKey, DataContextBase.ConnectionType connectionType, DataContextBase.ConnectionDataType connectionDataType) : 
                base(schemaItem, connectionType, connectionDataType)
        {
            defaultDatabaseConnectionConfigurationKey = connectionConfigKey;
            _connectionType = connectionType;
            _connectionDataType = connectionDataType;
        }
        
        /// <summary>
        /// Gets, the select property override.
        /// </summary>
        public new ISelectDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> Select
        {
            get
            {
                this.SelectContext = base.Select;
                this.SelectContext.ConfigurationDatabaseConnection = defaultDatabaseConnectionConfigurationKey;
                return this.SelectContext;
            }
        }
        
        /// <summary>
        /// Gets, the delete property override.
        /// </summary>
        public new IDeleteDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> Delete
        {
            get
            {
                this.DeleteContext = base.Delete;
                this.DeleteContext.ConfigurationDatabaseConnection = defaultDatabaseConnectionConfigurationKey;
                return this.DeleteContext;
            }
        }
        
        /// <summary>
        /// Gets, the insert property override.
        /// </summary>
        public new IInsertDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> Insert
        {
            get
            {
                this.InsertContext = base.Insert;
                this.InsertContext.ConfigurationDatabaseConnection = defaultDatabaseConnectionConfigurationKey;
                return this.InsertContext;
            }
        }
        
        /// <summary>
        /// Gets, the update property override.
        /// </summary>
        public new IUpdateDataSetGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> Update
        {
            get
            {
                this.UpdateContext = base.Update;
                this.UpdateContext.ConfigurationDatabaseConnection = defaultDatabaseConnectionConfigurationKey;
                return this.UpdateContext;
            }
        }
        
        /// <summary>
        /// Gets, the common property override.
        /// </summary>
        public new DataSetDataGenericBase<DataSet.Common, DataSet.Common.CompanyDataTable, Data.Company> Common
        {
            get
            {
                this.CommonContext = base.Common;
                this.CommonContext.ConfigurationDatabaseConnection = defaultDatabaseConnectionConfigurationKey;
                return this.CommonContext;
            }
        }
        
        /// <summary>
        /// Gets, the company dataset table property for the object.
        /// </summary>
        public DataSet.Common DataContext
        {
            get
            {
                return new DataSet.Common();
            }
        }
        
        /// <summary>
        /// Open a new default database connection
        /// </summary>
        /// <returns>The default DbConnection object.</returns>
        public virtual DbConnection OpenDefault()
        {
            return base.Common.StartDefaultConnection(base.Common.DefaultConnection(defaultDatabaseConnectionConfigurationKey));
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

