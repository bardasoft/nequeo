
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Edm.Extension
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
    using Nequeo.Data.Enumeration;
    using Nequeo.Data.Controller.Custom;
    using Nequeo.Data.Controller.Extension;
    using Edm = Nequeo.DataAccess.ApplicationLogin.Edm;
    
    
    /// <summary>
    /// The data access context model object class.
    /// </summary>
    public partial class Extension : Disposable, IDisposable
    {
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Extension()
        {
        }
        
        /// <summary>
        /// Gets, the screenaccess model property for the object.
        /// </summary>
        public Edm.Model.ScreenAccess ScreenAccess
        {
            get
            {
                return new Edm.Model.ScreenAccess();
            }
        }
        
        /// <summary>
        /// Gets, the tabletype model property for the object.
        /// </summary>
        public Edm.Model.TableType TableType
        {
            get
            {
                return new Edm.Model.TableType();
            }
        }
        
        /// <summary>
        /// Gets, the applicationuser model property for the object.
        /// </summary>
        public Edm.Model.ApplicationUser ApplicationUser
        {
            get
            {
                return new Edm.Model.ApplicationUser();
            }
        }
        
        /// <summary>
        /// Gets, the state model property for the object.
        /// </summary>
        public Edm.Model.State State
        {
            get
            {
                return new Edm.Model.State();
            }
        }
        
        /// <summary>
        /// Gets, the statetimezone model property for the object.
        /// </summary>
        public Edm.Model.StateTimeZone StateTimeZone
        {
            get
            {
                return new Edm.Model.StateTimeZone();
            }
        }
        
        /// <summary>
        /// Gets, the country model property for the object.
        /// </summary>
        public Edm.Model.Country Country
        {
            get
            {
                return new Edm.Model.Country();
            }
        }
        
        /// <summary>
        /// Gets, the useraddress model property for the object.
        /// </summary>
        public Edm.Model.UserAddress UserAddress
        {
            get
            {
                return new Edm.Model.UserAddress();
            }
        }
        
        /// <summary>
        /// Gets, the user model property for the object.
        /// </summary>
        public Edm.Model.User User
        {
            get
            {
                return new Edm.Model.User();
            }
        }
        
        /// <summary>
        /// Gets, the internationaltimezone model property for the object.
        /// </summary>
        public Edm.Model.InternationalTimeZone InternationalTimeZone
        {
            get
            {
                return new Edm.Model.InternationalTimeZone();
            }
        }
        
        /// <summary>
        /// Gets, the errorlog model property for the object.
        /// </summary>
        public Edm.Model.ErrorLog ErrorLog
        {
            get
            {
                return new Edm.Model.ErrorLog();
            }
        }
        
        /// <summary>
        /// Gets, the changelog model property for the object.
        /// </summary>
        public Edm.Model.ChangeLog ChangeLog
        {
            get
            {
                return new Edm.Model.ChangeLog();
            }
        }
        
        /// <summary>
        /// Gets, the loginhistory model property for the object.
        /// </summary>
        public Edm.Model.LoginHistory LoginHistory
        {
            get
            {
                return new Edm.Model.LoginHistory();
            }
        }
        
        /// <summary>
        /// Gets, the language model property for the object.
        /// </summary>
        public Edm.Model.Language Language
        {
            get
            {
                return new Edm.Model.Language();
            }
        }
        
        /// <summary>
        /// Gets, the application model property for the object.
        /// </summary>
        public Edm.Model.Application Application
        {
            get
            {
                return new Edm.Model.Application();
            }
        }
        
        /// <summary>
        /// Gets, the company model property for the object.
        /// </summary>
        public Edm.Model.Company Company
        {
            get
            {
                return new Edm.Model.Company();
            }
        }
        
        /// <summary>
        /// Gets, the department model property for the object.
        /// </summary>
        public Edm.Model.Department Department
        {
            get
            {
                return new Edm.Model.Department();
            }
        }
        
        /// <summary>
        /// Gets, the continent model property for the object.
        /// </summary>
        public Edm.Model.Continent Continent
        {
            get
            {
                return new Edm.Model.Continent();
            }
        }
        
        /// <summary>
        /// Gets, the accesstype model property for the object.
        /// </summary>
        public Edm.Model.AccessType AccessType
        {
            get
            {
                return new Edm.Model.AccessType();
            }
        }
        
        /// <summary>
        /// Gets, the roletype model property for the object.
        /// </summary>
        public Edm.Model.RoleType RoleType
        {
            get
            {
                return new Edm.Model.RoleType();
            }
        }
        
        /// <summary>
        /// Gets, the screen model property for the object.
        /// </summary>
        public Edm.Model.Screen Screen
        {
            get
            {
                return new Edm.Model.Screen();
            }
        }
    }
}
namespace Nequeo.DataAccess.ApplicationLogin.Edm
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
    using Nequeo.Data.Enumeration;
    using Nequeo.Data.Controller.Custom;
    using Nequeo.Data.Controller.Extension;
    
    
    /// <summary>
    /// The data access context object class.
    /// </summary>
    public partial class CommonEntityContext
    {
        
        /// <summary>
        /// Gets, the extension class.
        /// </summary>
        public Edm.Extension.Extension Extension
        {
            get
            {
                return new Edm.Extension.Extension();
            }
        }
    }
}

