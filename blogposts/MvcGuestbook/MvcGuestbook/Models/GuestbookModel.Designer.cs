﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("GuestbookModel", "FK_Comments_Categories", "Categories", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MvcGuestbook.Models.Categories), "Comments", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MvcGuestbook.Models.Comments))]

// Original file name:
// Generation date: 27.03.2009 11:26:11
namespace MvcGuestbook.Models
{
    
    /// <summary>
    /// There are no comments for GuestbookEntities in the schema.
    /// </summary>
    public partial class GuestbookEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new GuestbookEntities object using the connection string found in the 'GuestbookEntities' section of the application configuration file.
        /// </summary>
        public GuestbookEntities() : 
                base("name=GuestbookEntities", "GuestbookEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new GuestbookEntities object.
        /// </summary>
        public GuestbookEntities(string connectionString) : 
                base(connectionString, "GuestbookEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new GuestbookEntities object.
        /// </summary>
        public GuestbookEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "GuestbookEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Categories> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Categories>("[Categories]");
                }
                return this._Categories;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Categories> _Categories;
        /// <summary>
        /// There are no comments for Comments in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Comments> Comments
        {
            get
            {
                if ((this._Comments == null))
                {
                    this._Comments = base.CreateQuery<Comments>("[Comments]");
                }
                return this._Comments;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Comments> _Comments;
        /// <summary>
        /// There are no comments for sysdiagrams in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<sysdiagrams> sysdiagrams
        {
            get
            {
                if ((this._sysdiagrams == null))
                {
                    this._sysdiagrams = base.CreateQuery<sysdiagrams>("[sysdiagrams]");
                }
                return this._sysdiagrams;
            }
        }
        private global::System.Data.Objects.ObjectQuery<sysdiagrams> _sysdiagrams;
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public void AddToCategories(Categories categories)
        {
            base.AddObject("Categories", categories);
        }
        /// <summary>
        /// There are no comments for Comments in the schema.
        /// </summary>
        public void AddToComments(Comments comments)
        {
            base.AddObject("Comments", comments);
        }
        /// <summary>
        /// There are no comments for sysdiagrams in the schema.
        /// </summary>
        public void AddTosysdiagrams(sysdiagrams sysdiagrams)
        {
            base.AddObject("sysdiagrams", sysdiagrams);
        }
    }
    /// <summary>
    /// There are no comments for GuestbookModel.Categories in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="GuestbookModel", Name="Categories")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Categories : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Categories object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        public static Categories CreateCategories(global::System.Guid id, string name)
        {
            Categories categories = new Categories();
            categories.Id = id;
            categories.Name = name;
            return categories;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Comments in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("GuestbookModel", "FK_Comments_Categories", "Comments")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Comments> Comments
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Comments>("GuestbookModel.FK_Comments_Categories", "Comments");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Comments>("GuestbookModel.FK_Comments_Categories", "Comments", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for GuestbookModel.Comments in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="GuestbookModel", Name="Comments")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Comments : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Comments object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="dateTime">Initial value of DateTime.</param>
        /// <param name="text">Initial value of Text.</param>
        public static Comments CreateComments(global::System.Guid id, string name, global::System.DateTime dateTime, string text)
        {
            Comments comments = new Comments();
            comments.Id = id;
            comments.Name = name;
            comments.DateTime = dateTime;
            comments.Text = text;
            return comments;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DateTime in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.DateTime DateTime
        {
            get
            {
                return this._DateTime;
            }
            set
            {
                this.OnDateTimeChanging(value);
                this.ReportPropertyChanging("DateTime");
                this._DateTime = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateTime");
                this.OnDateTimeChanged();
            }
        }
        private global::System.DateTime _DateTime;
        partial void OnDateTimeChanging(global::System.DateTime value);
        partial void OnDateTimeChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this.ReportPropertyChanging("Text");
                this._Text = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Text");
                this.OnTextChanged();
            }
        }
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("GuestbookModel", "FK_Comments_Categories", "Categories")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Categories Categories
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Categories>("GuestbookModel.FK_Comments_Categories", "Categories").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Categories>("GuestbookModel.FK_Comments_Categories", "Categories").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Categories> CategoriesReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Categories>("GuestbookModel.FK_Comments_Categories", "Categories");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Categories>("GuestbookModel.FK_Comments_Categories", "Categories", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for GuestbookModel.sysdiagrams in the schema.
    /// </summary>
    /// <KeyProperties>
    /// diagram_id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="GuestbookModel", Name="sysdiagrams")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class sysdiagrams : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new sysdiagrams object.
        /// </summary>
        /// <param name="name">Initial value of name.</param>
        /// <param name="principal_id">Initial value of principal_id.</param>
        /// <param name="diagram_id">Initial value of diagram_id.</param>
        public static sysdiagrams Createsysdiagrams(string name, int principal_id, int diagram_id)
        {
            sysdiagrams sysdiagrams = new sysdiagrams();
            sysdiagrams.name = name;
            sysdiagrams.principal_id = principal_id;
            sysdiagrams.diagram_id = diagram_id;
            return sysdiagrams;
        }
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this.ReportPropertyChanging("name");
                this._name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("name");
                this.OnnameChanged();
            }
        }
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property principal_id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int principal_id
        {
            get
            {
                return this._principal_id;
            }
            set
            {
                this.Onprincipal_idChanging(value);
                this.ReportPropertyChanging("principal_id");
                this._principal_id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("principal_id");
                this.Onprincipal_idChanged();
            }
        }
        private int _principal_id;
        partial void Onprincipal_idChanging(int value);
        partial void Onprincipal_idChanged();
        /// <summary>
        /// There are no comments for Property diagram_id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int diagram_id
        {
            get
            {
                return this._diagram_id;
            }
            set
            {
                this.Ondiagram_idChanging(value);
                this.ReportPropertyChanging("diagram_id");
                this._diagram_id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("diagram_id");
                this.Ondiagram_idChanged();
            }
        }
        private int _diagram_id;
        partial void Ondiagram_idChanging(int value);
        partial void Ondiagram_idChanged();
        /// <summary>
        /// There are no comments for Property version in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> version
        {
            get
            {
                return this._version;
            }
            set
            {
                this.OnversionChanging(value);
                this.ReportPropertyChanging("version");
                this._version = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("version");
                this.OnversionChanged();
            }
        }
        private global::System.Nullable<int> _version;
        partial void OnversionChanging(global::System.Nullable<int> value);
        partial void OnversionChanged();
        /// <summary>
        /// There are no comments for Property definition in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] definition
        {
            get
            {
                return global::System.Data.Objects.DataClasses.StructuralObject.GetValidValue(this._definition);
            }
            set
            {
                this.OndefinitionChanging(value);
                this.ReportPropertyChanging("definition");
                this._definition = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("definition");
                this.OndefinitionChanged();
            }
        }
        private byte[] _definition;
        partial void OndefinitionChanging(byte[] value);
        partial void OndefinitionChanged();
    }
}
