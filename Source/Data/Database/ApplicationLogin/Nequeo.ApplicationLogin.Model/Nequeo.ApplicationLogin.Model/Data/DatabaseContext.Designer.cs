//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Data
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
    [DatabaseAttribute("ApplicationLogin")]
    public partial class DataContext : DataContextBase
    {
        
        private const string defaultDatabaseConnectionConfigurationKey = "Nequeo.DataAccess.ApplicationLogin.Properties.Settings.ApplicationLoginDatabaseConnection";
        
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
        /// Gets, the screen queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Screen> Screens
        {
            get
            {
                return this.GetTable<Data.Screen>();
            }
        }
        
        /// <summary>
        /// Gets, the roletype queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.RoleType> RoleTypes
        {
            get
            {
                return this.GetTable<Data.RoleType>();
            }
        }
        
        /// <summary>
        /// Gets, the accesstype queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.AccessType> AccessTypes
        {
            get
            {
                return this.GetTable<Data.AccessType>();
            }
        }
        
        /// <summary>
        /// Gets, the continent queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Continent> Continents
        {
            get
            {
                return this.GetTable<Data.Continent>();
            }
        }
        
        /// <summary>
        /// Gets, the department queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Department> Departments
        {
            get
            {
                return this.GetTable<Data.Department>();
            }
        }
        
        /// <summary>
        /// Gets, the company queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Company> Companies
        {
            get
            {
                return this.GetTable<Data.Company>();
            }
        }
        
        /// <summary>
        /// Gets, the application queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Application> Applications
        {
            get
            {
                return this.GetTable<Data.Application>();
            }
        }
        
        /// <summary>
        /// Gets, the language queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Language> Languages
        {
            get
            {
                return this.GetTable<Data.Language>();
            }
        }
        
        /// <summary>
        /// Gets, the loginhistory queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.LoginHistory> LoginHistories
        {
            get
            {
                return this.GetTable<Data.LoginHistory>();
            }
        }
        
        /// <summary>
        /// Gets, the changelog queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ChangeLog> ChangeLogs
        {
            get
            {
                return this.GetTable<Data.ChangeLog>();
            }
        }
        
        /// <summary>
        /// Gets, the errorlog queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ErrorLog> ErrorLogs
        {
            get
            {
                return this.GetTable<Data.ErrorLog>();
            }
        }
        
        /// <summary>
        /// Gets, the internationaltimezone queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.InternationalTimeZone> InternationalTimeZones
        {
            get
            {
                return this.GetTable<Data.InternationalTimeZone>();
            }
        }
        
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
        /// Gets, the useraddress queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.UserAddress> UserAddresses
        {
            get
            {
                return this.GetTable<Data.UserAddress>();
            }
        }
        
        /// <summary>
        /// Gets, the country queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.Country> Countries
        {
            get
            {
                return this.GetTable<Data.Country>();
            }
        }
        
        /// <summary>
        /// Gets, the statetimezone queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.StateTimeZone> StateTimeZones
        {
            get
            {
                return this.GetTable<Data.StateTimeZone>();
            }
        }
        
        /// <summary>
        /// Gets, the state queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.State> States
        {
            get
            {
                return this.GetTable<Data.State>();
            }
        }
        
        /// <summary>
        /// Gets, the applicationuser queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ApplicationUser> ApplicationUsers
        {
            get
            {
                return this.GetTable<Data.ApplicationUser>();
            }
        }
        
        /// <summary>
        /// Gets, the tabletype queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.TableType> TableTypes
        {
            get
            {
                return this.GetTable<Data.TableType>();
            }
        }
        
        /// <summary>
        /// Gets, the screenaccess queryable provider property for the object.
        /// </summary>
        public Nequeo.Data.Linq.Query<Data.ScreenAccess> ScreenAccesses
        {
            get
            {
                return this.GetTable<Data.ScreenAccess>();
            }
        }
        #endregion
    }
    #endregion
}