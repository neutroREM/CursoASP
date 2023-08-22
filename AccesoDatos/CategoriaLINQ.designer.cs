﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="abarrotes")]
	public partial class CategoriaLINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProducto(ProductoLINQ instance);
    partial void UpdateProducto(ProductoLINQ instance);
    partial void DeleteProducto(ProductoLINQ instance);
    #endregion
		
		public CategoriaLINQDataContext() : 
				base(global::AccesoDatos.Properties.Settings.Default.abarrotesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CategoriaLINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CategoriaLINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CategoriaLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CategoriaLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<ProductoLINQ> Producto
		{
			get
			{
				return this.GetTable<ProductoLINQ>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdCategoria;
		
		private string _NombreCategoria;
		
		private string _Descripcion;
		
		private EntitySet<ProductoLINQ> _Producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCategoriaChanging(int value);
    partial void OnIdCategoriaChanged();
    partial void OnNombreCategoriaChanging(string value);
    partial void OnNombreCategoriaChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public Categoria()
		{
			this._Producto = new EntitySet<ProductoLINQ>(new Action<ProductoLINQ>(this.attach_Producto), new Action<ProductoLINQ>(this.detach_Producto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this.OnIdCategoriaChanging(value);
					this.SendPropertyChanging();
					this._IdCategoria = value;
					this.SendPropertyChanged("IdCategoria");
					this.OnIdCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCategoria", DbType="VarChar(40)")]
		public string NombreCategoria
		{
			get
			{
				return this._NombreCategoria;
			}
			set
			{
				if ((this._NombreCategoria != value))
				{
					this.OnNombreCategoriaChanging(value);
					this.SendPropertyChanging();
					this._NombreCategoria = value;
					this.SendPropertyChanged("NombreCategoria");
					this.OnNombreCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(200)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Producto", Storage="_Producto", ThisKey="IdCategoria", OtherKey="IdCategoria")]
		public EntitySet<ProductoLINQ> Producto
		{
			get
			{
				return this._Producto;
			}
			set
			{
				this._Producto.Assign(value);
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
		
		private void attach_Producto(ProductoLINQ entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Producto(ProductoLINQ entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class ProductoLINQ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdProducto;
		
		private string _NombreProducto;
		
		private System.Nullable<decimal> _Precio;
		
		private System.Nullable<System.DateTime> _FechaCreacion;
		
		private System.Nullable<System.DateTime> _FechaExpiracion;
		
		private System.Nullable<int> _IdCategoria;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdProductoChanging(int value);
    partial void OnIdProductoChanged();
    partial void OnNombreProductoChanging(string value);
    partial void OnNombreProductoChanged();
    partial void OnPrecioChanging(System.Nullable<decimal> value);
    partial void OnPrecioChanged();
    partial void OnFechaCreacionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaCreacionChanged();
    partial void OnFechaExpiracionChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaExpiracionChanged();
    partial void OnIdCategoriaChanging(System.Nullable<int> value);
    partial void OnIdCategoriaChanged();
    #endregion
		
		public ProductoLINQ()
		{
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdProducto
		{
			get
			{
				return this._IdProducto;
			}
			set
			{
				if ((this._IdProducto != value))
				{
					this.OnIdProductoChanging(value);
					this.SendPropertyChanging();
					this._IdProducto = value;
					this.SendPropertyChanged("IdProducto");
					this.OnIdProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreProducto", DbType="VarChar(50)")]
		public string NombreProducto
		{
			get
			{
				return this._NombreProducto;
			}
			set
			{
				if ((this._NombreProducto != value))
				{
					this.OnNombreProductoChanging(value);
					this.SendPropertyChanging();
					this._NombreProducto = value;
					this.SendPropertyChanged("NombreProducto");
					this.OnNombreProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaCreacion
		{
			get
			{
				return this._FechaCreacion;
			}
			set
			{
				if ((this._FechaCreacion != value))
				{
					this.OnFechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._FechaCreacion = value;
					this.SendPropertyChanged("FechaCreacion");
					this.OnFechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaExpiracion", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaExpiracion
		{
			get
			{
				return this._FechaExpiracion;
			}
			set
			{
				if ((this._FechaExpiracion != value))
				{
					this.OnFechaExpiracionChanging(value);
					this.SendPropertyChanging();
					this._FechaExpiracion = value;
					this.SendPropertyChanged("FechaExpiracion");
					this.OnFechaExpiracionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", DbType="Int")]
		public System.Nullable<int> IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdCategoriaChanging(value);
					this.SendPropertyChanging();
					this._IdCategoria = value;
					this.SendPropertyChanged("IdCategoria");
					this.OnIdCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Producto", Storage="_Categoria", ThisKey="IdCategoria", OtherKey="IdCategoria", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Producto.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Producto.Add(this);
						this._IdCategoria = value.IdCategoria;
					}
					else
					{
						this._IdCategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
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