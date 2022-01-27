﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sports_equipment_store.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SportsEquipmentSoreDB")]
	public partial class SportsEquipmentStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSportsTeam(SportsTeam instance);
    partial void UpdateSportsTeam(SportsTeam instance);
    partial void DeleteSportsTeam(SportsTeam instance);
    partial void InsertSportsEquipment(SportsEquipment instance);
    partial void UpdateSportsEquipment(SportsEquipment instance);
    partial void DeleteSportsEquipment(SportsEquipment instance);
    #endregion
		
		public SportsEquipmentStoreDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SportsEquipmentSoreDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SportsEquipmentStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsEquipmentStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsEquipmentStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SportsEquipmentStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SportsTeam> SportsTeams
		{
			get
			{
				return this.GetTable<SportsTeam>();
			}
		}
		
		public System.Data.Linq.Table<SportsEquipment> SportsEquipments
		{
			get
			{
				return this.GetTable<SportsEquipment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SportsTeams")]
	public partial class SportsTeam : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nameGroup;
		
		private EntitySet<SportsEquipment> _SportsEquipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameGroupChanging(string value);
    partial void OnnameGroupChanged();
    #endregion
		
		public SportsTeam()
		{
			this._SportsEquipments = new EntitySet<SportsEquipment>(new Action<SportsEquipment>(this.attach_SportsEquipments), new Action<SportsEquipment>(this.detach_SportsEquipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameGroup", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string nameGroup
		{
			get
			{
				return this._nameGroup;
			}
			set
			{
				if ((this._nameGroup != value))
				{
					this.OnnameGroupChanging(value);
					this.SendPropertyChanging();
					this._nameGroup = value;
					this.SendPropertyChanged("nameGroup");
					this.OnnameGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SportsTeam_SportsEquipment", Storage="_SportsEquipments", ThisKey="Id", OtherKey="groupID")]
		public EntitySet<SportsEquipment> SportsEquipments
		{
			get
			{
				return this._SportsEquipments;
			}
			set
			{
				this._SportsEquipments.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SportsEquipments(SportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.SportsTeam = this;
		}
		
		private void detach_SportsEquipments(SportsEquipment entity)
		{
			this.SendPropertyChanging();
			entity.SportsTeam = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SportsEquipment")]
	public partial class SportsEquipment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _sportType;
		
		private string _productName;
		
		private string _company;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<int> _groupID;
		
		private string _picture;
		
		private EntityRef<SportsTeam> _SportsTeam;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnsportTypeChanging(string value);
    partial void OnsportTypeChanged();
    partial void OnproductNameChanging(string value);
    partial void OnproductNameChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OngroupIDChanging(System.Nullable<int> value);
    partial void OngroupIDChanged();
    partial void OnpictureChanging(string value);
    partial void OnpictureChanged();
    #endregion
		
		public SportsEquipment()
		{
			this._SportsTeam = default(EntityRef<SportsTeam>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sportType", DbType="NVarChar(MAX)")]
		public string sportType
		{
			get
			{
				return this._sportType;
			}
			set
			{
				if ((this._sportType != value))
				{
					this.OnsportTypeChanging(value);
					this.SendPropertyChanging();
					this._sportType = value;
					this.SendPropertyChanged("sportType");
					this.OnsportTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", DbType="NVarChar(MAX)")]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this.OnproductNameChanging(value);
					this.SendPropertyChanging();
					this._productName = value;
					this.SendPropertyChanged("productName");
					this.OnproductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="NVarChar(MAX)")]
		public string company
		{
			get
			{
				return this._company;
			}
			set
			{
				if ((this._company != value))
				{
					this.OncompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("company");
					this.OncompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int")]
		public System.Nullable<int> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_groupID", DbType="Int")]
		public System.Nullable<int> groupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((this._groupID != value))
				{
					if (this._SportsTeam.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OngroupIDChanging(value);
					this.SendPropertyChanging();
					this._groupID = value;
					this.SendPropertyChanged("groupID");
					this.OngroupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(MAX)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SportsTeam_SportsEquipment", Storage="_SportsTeam", ThisKey="groupID", OtherKey="Id", IsForeignKey=true)]
		public SportsTeam SportsTeam
		{
			get
			{
				return this._SportsTeam.Entity;
			}
			set
			{
				SportsTeam previousValue = this._SportsTeam.Entity;
				if (((previousValue != value) 
							|| (this._SportsTeam.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SportsTeam.Entity = null;
						previousValue.SportsEquipments.Remove(this);
					}
					this._SportsTeam.Entity = value;
					if ((value != null))
					{
						value.SportsEquipments.Add(this);
						this._groupID = value.Id;
					}
					else
					{
						this._groupID = default(Nullable<int>);
					}
					this.SendPropertyChanged("SportsTeam");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591