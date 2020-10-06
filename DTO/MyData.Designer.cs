﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 10/6/2020 8:59:56 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace CuongkientrucContext
{

    [DatabaseAttribute(Name = "cuongkientruc")]
    [ProviderAttribute(typeof(Devart.Data.SqlServer.Linq.Provider.SqlDataProvider))]
    public partial class CuongkientrucDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(CuongkientrucDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertRam(Ram instance);
        partial void UpdateRam(Ram instance);
        partial void DeleteRam(Ram instance);

        #endregion

        public CuongkientrucDataContext() :
        base(GetConnectionString("CuongkientrucDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public CuongkientrucDataContext(MappingSource mappingSource) :
        base(GetConnectionString("CuongkientrucDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public CuongkientrucDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CuongkientrucDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CuongkientrucDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CuongkientrucDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Ram> Rams
        {
            get
            {
                return this.GetTable<Ram>();
            }
        }
    }
}

namespace CuongkientrucContext
{

    /// <summary>
    /// There are no comments for CuongkientrucContext.Ram in the schema.
    /// </summary>
    [Table(Name = @"dbo.Ram")]
    public partial class Ram : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Code;

        private string _Name;

        private int? _Price;

        private int? _Bus;

        private string _Type;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnCodeChanging(int value);
        partial void OnCodeChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnPriceChanging(int? value);
        partial void OnPriceChanged();
        partial void OnBusChanging(int? value);
        partial void OnBusChanged();
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        #endregion

        public Ram()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Code in the schema.
        /// </summary>
        [Column(Storage = "_Code", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                if (this._Code != value)
                {
                    this.OnCodeChanging(value);
                    this.SendPropertyChanging("Code");
                    this._Code = value;
                    this.SendPropertyChanged("Code");
                    this.OnCodeChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        [Column(Storage = "_Name", CanBeNull = false, DbType = "NVARCHAR(50) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging("Name");
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Price in the schema.
        /// </summary>
        [Column(Storage = "_Price", DbType = "INT", UpdateCheck = UpdateCheck.Never)]
        public int? Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if (this._Price != value)
                {
                    this.OnPriceChanging(value);
                    this.SendPropertyChanging("Price");
                    this._Price = value;
                    this.SendPropertyChanged("Price");
                    this.OnPriceChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Bus in the schema.
        /// </summary>
        [Column(Storage = "_Bus", DbType = "INT", UpdateCheck = UpdateCheck.Never)]
        public int? Bus
        {
            get
            {
                return this._Bus;
            }
            set
            {
                if (this._Bus != value)
                {
                    this.OnBusChanging(value);
                    this.SendPropertyChanging("Bus");
                    this._Bus = value;
                    this.SendPropertyChanged("Bus");
                    this.OnBusChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Type in the schema.
        /// </summary>
        [Column(Storage = "_Type", DbType = "NVARCHAR(50)", UpdateCheck = UpdateCheck.Never)]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if (this._Type != value)
                {
                    this.OnTypeChanging(value);
                    this.SendPropertyChanging("Type");
                    this._Type = value;
                    this.SendPropertyChanged("Type");
                    this.OnTypeChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}