//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Data.Extended
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
    
    
    #region CountryList Data Type
    /// <summary>
    /// The countrylist data object class.
    /// </summary>
    [DataContractAttribute(Name = "CountryList", IsReference = true)]
    [SerializableAttribute()]
    [KnownTypeAttribute(typeof(DataBase))]
    public partial class CountryList : DataBase
    {
        
        private long _CountryID;
        
        private string _CountryName;
        
        private string _CountryCode;
        
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
        public CountryList()
        {
            OnCreated();
        }
        
        /// <summary>
        /// Gets sets, the countryid property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the countryid property for the object.")]
        [DataMemberAttribute(Name = "CountryID")]
        [XmlElementAttribute(ElementName = "CountryID", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public long CountryID
        {
            get
            {
                return this._CountryID;
            }
            set
            {
                if ((this._CountryID != value))
                {
                    this._CountryID = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the countryname property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the countryname property for the object.")]
        [DataMemberAttribute(Name = "CountryName")]
        [XmlElementAttribute(ElementName = "CountryName", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string CountryName
        {
            get
            {
                return this._CountryName;
            }
            set
            {
                if ((this._CountryName != value))
                {
                    this._CountryName = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the countrycode property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the countrycode property for the object.")]
        [DataMemberAttribute(Name = "CountryCode")]
        [XmlElementAttribute(ElementName = "CountryCode", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string CountryCode
        {
            get
            {
                return this._CountryCode;
            }
            set
            {
                if ((this._CountryCode != value))
                {
                    this._CountryCode = value;
                }
            }
        }
        
        /// <summary>
        /// Create a new countrylist data entity.
        /// </summary>
        /// <param name="countryID">Initial value of CountryID.</param>
        /// <param name="countryName">Initial value of CountryName.</param>
        /// <param name="countryCode">Initial value of CountryCode.</param>
        /// <returns>The Data.Extended.CountryList entity.</returns>
        public static Data.Extended.CountryList CreateCountryList(long countryID, string countryName, string countryCode)
        {
            Data.Extended.CountryList countryList = new Data.Extended.CountryList();
            countryList.CountryID = countryID;
            countryList.CountryName = countryName;
            countryList.CountryCode = countryCode;
            return countryList;
        }
    }
    #endregion
}
