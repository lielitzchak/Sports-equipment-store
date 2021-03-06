#pragma warning disable 1591
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
    partial void InsertShoe(Shoe instance);
    partial void UpdateShoe(Shoe instance);
    partial void DeleteShoe(Shoe instance);
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
		
		public System.Data.Linq.Table<Clothing> Clothings
		{
			get
			{
				return this.GetTable<Clothing>();
			}
		}
		
		public System.Data.Linq.Table<Shoe> Shoes
		{
			get
			{
				return this.GetTable<Shoe>();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clothing")]
	public partial class Clothing
	{
		
		private int _Id;
		
		private string _TypeGarment;
		
		private string _Company;
		
		private string _Model;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<bool> _IsShort;
		
		private System.Nullable<bool> _IsDreyfit;
		
		private string _ImageLink_;
		
		public Clothing()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeGarment", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TypeGarment
		{
			get
			{
				return this._TypeGarment;
			}
			set
			{
				if ((this._TypeGarment != value))
				{
					this._TypeGarment = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this._Company = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NVarChar(MAX)")]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this._Model = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
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
					this._Amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsShort", DbType="Bit")]
		public System.Nullable<bool> IsShort
		{
			get
			{
				return this._IsShort;
			}
			set
			{
				if ((this._IsShort != value))
				{
					this._IsShort = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDreyfit", DbType="Bit")]
		public System.Nullable<bool> IsDreyfit
		{
			get
			{
				return this._IsDreyfit;
			}
			set
			{
				if ((this._IsDreyfit != value))
				{
					this._IsDreyfit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[ImageLink ]", Storage="_ImageLink_", DbType="NVarChar(MAX)")]
		public string ImageLink_
		{
			get
			{
				return this._ImageLink_;
			}
			set
			{
				if ((this._ImageLink_ != value))
				{
					this._ImageLink_ = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shoes")]
	public partial class Shoe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _shoeType;
		
		private string _company;
		
		private string _model;
		
		private System.Nullable<int> _price;
		
		private System.Nullable<int> _amount;
		
		private System.Nullable<bool> _isSale;
		
		private string _LinkToImage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnshoeTypeChanging(string value);
    partial void OnshoeTypeChanged();
    partial void OncompanyChanging(string value);
    partial void OncompanyChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    partial void OnpriceChanging(System.Nullable<int> value);
    partial void OnpriceChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    partial void OnisSaleChanging(System.Nullable<bool> value);
    partial void OnisSaleChanged();
    partial void OnLinkToImageChanging(string value);
    partial void OnLinkToImageChanged();
    #endregion
		
		public Shoe()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shoeType", DbType="VarChar(MAX)")]
		public string shoeType
		{
			get
			{
				return this._shoeType;
			}
			set
			{
				if ((this._shoeType != value))
				{
					this.OnshoeTypeChanging(value);
					this.SendPropertyChanging();
					this._shoeType = value;
					this.SendPropertyChanged("shoeType");
					this.OnshoeTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_company", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="VarChar(MAX)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isSale", DbType="Bit")]
		public System.Nullable<bool> isSale
		{
			get
			{
				return this._isSale;
			}
			set
			{
				if ((this._isSale != value))
				{
					this.OnisSaleChanging(value);
					this.SendPropertyChanging();
					this._isSale = value;
					this.SendPropertyChanged("isSale");
					this.OnisSaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkToImage", DbType="VarChar(MAX)")]
		public string LinkToImage
		{
			get
			{
				return this._LinkToImage;
			}
			set
			{
				if ((this._LinkToImage != value))
				{
					this.OnLinkToImageChanging(value);
					this.SendPropertyChanging();
					this._LinkToImage = value;
					this.SendPropertyChanged("LinkToImage");
					this.OnLinkToImageChanged();
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
