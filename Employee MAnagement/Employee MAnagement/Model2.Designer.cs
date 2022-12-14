//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Employee_MAnagement
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeeDatabaseEntities6 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeeDatabaseEntities6 object using the connection string found in the 'EmployeeDatabaseEntities6' section of the application configuration file.
        /// </summary>
        public EmployeeDatabaseEntities6() : base("name=EmployeeDatabaseEntities6", "EmployeeDatabaseEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDatabaseEntities6 object.
        /// </summary>
        public EmployeeDatabaseEntities6(string connectionString) : base(connectionString, "EmployeeDatabaseEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDatabaseEntities6 object.
        /// </summary>
        public EmployeeDatabaseEntities6(EntityConnection connection) : base(connection, "EmployeeDatabaseEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Atendance> Atendances
        {
            get
            {
                if ((_Atendances == null))
                {
                    _Atendances = base.CreateObjectSet<Atendance>("Atendances");
                }
                return _Atendances;
            }
        }
        private ObjectSet<Atendance> _Atendances;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Atendances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAtendances(Atendance atendance)
        {
            base.AddObject("Atendances", atendance);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeDatabaseModel2", Name="Atendance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Atendance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Atendance object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="date">Initial value of the date property.</param>
        public static Atendance CreateAtendance(global::System.String id, global::System.String date)
        {
            Atendance atendance = new Atendance();
            atendance.Id = id;
            atendance.date = date;
            return atendance;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String attendance
        {
            get
            {
                return _attendance;
            }
            set
            {
                OnattendanceChanging(value);
                ReportPropertyChanging("attendance");
                _attendance = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("attendance");
                OnattendanceChanged();
            }
        }
        private global::System.String _attendance;
        partial void OnattendanceChanging(global::System.String value);
        partial void OnattendanceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String date
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date != value)
                {
                    OndateChanging(value);
                    ReportPropertyChanging("date");
                    _date = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("date");
                    OndateChanged();
                }
            }
        }
        private global::System.String _date;
        partial void OndateChanging(global::System.String value);
        partial void OndateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String month
        {
            get
            {
                return _month;
            }
            set
            {
                OnmonthChanging(value);
                ReportPropertyChanging("month");
                _month = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("month");
                OnmonthChanged();
            }
        }
        private global::System.String _month;
        partial void OnmonthChanging(global::System.String value);
        partial void OnmonthChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeDatabaseModel2", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="phone">Initial value of the phone property.</param>
        /// <param name="mail">Initial value of the mail property.</param>
        /// <param name="password">Initial value of the password property.</param>
        public static Employee CreateEmployee(global::System.String id, global::System.String name, global::System.String phone, global::System.String mail, global::System.String password)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.name = name;
            employee.phone = phone;
            employee.mail = mail;
            employee.password = password;
            return employee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                OnaddressChanging(value);
                ReportPropertyChanging("address");
                _address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("address");
                OnaddressChanged();
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String gender
        {
            get
            {
                return _gender;
            }
            set
            {
                OngenderChanging(value);
                ReportPropertyChanging("gender");
                _gender = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("gender");
                OngenderChanged();
            }
        }
        private global::System.String _gender;
        partial void OngenderChanging(global::System.String value);
        partial void OngenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String position
        {
            get
            {
                return _position;
            }
            set
            {
                OnpositionChanging(value);
                ReportPropertyChanging("position");
                _position = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("position");
                OnpositionChanged();
            }
        }
        private global::System.String _position;
        partial void OnpositionChanging(global::System.String value);
        partial void OnpositionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                OnbirthdateChanging(value);
                ReportPropertyChanging("birthdate");
                _birthdate = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("birthdate");
                OnbirthdateChanged();
            }
        }
        private global::System.String _birthdate;
        partial void OnbirthdateChanging(global::System.String value);
        partial void OnbirthdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String eduaction
        {
            get
            {
                return _eduaction;
            }
            set
            {
                OneduactionChanging(value);
                ReportPropertyChanging("eduaction");
                _eduaction = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("eduaction");
                OneduactionChanged();
            }
        }
        private global::System.String _eduaction;
        partial void OneduactionChanging(global::System.String value);
        partial void OneduactionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String phone
        {
            get
            {
                return _phone;
            }
            set
            {
                OnphoneChanging(value);
                ReportPropertyChanging("phone");
                _phone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("phone");
                OnphoneChanged();
            }
        }
        private global::System.String _phone;
        partial void OnphoneChanging(global::System.String value);
        partial void OnphoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String mail
        {
            get
            {
                return _mail;
            }
            set
            {
                OnmailChanging(value);
                ReportPropertyChanging("mail");
                _mail = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("mail");
                OnmailChanged();
            }
        }
        private global::System.String _mail;
        partial void OnmailChanging(global::System.String value);
        partial void OnmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> salary
        {
            get
            {
                return _salary;
            }
            set
            {
                OnsalaryChanging(value);
                ReportPropertyChanging("salary");
                _salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("salary");
                OnsalaryChanged();
            }
        }
        private Nullable<global::System.Decimal> _salary;
        partial void OnsalaryChanging(Nullable<global::System.Decimal> value);
        partial void OnsalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String usertype
        {
            get
            {
                return _usertype;
            }
            set
            {
                OnusertypeChanging(value);
                ReportPropertyChanging("usertype");
                _usertype = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("usertype");
                OnusertypeChanged();
            }
        }
        private global::System.String _usertype;
        partial void OnusertypeChanging(global::System.String value);
        partial void OnusertypeChanged();

        #endregion

    
    }

    #endregion

    
}
