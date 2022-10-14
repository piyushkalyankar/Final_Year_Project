﻿//------------------------------------------------------------------------------
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EmployeeDatabaseModel1", "FK_attendance_Employee", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Employee_MAnagement.Models.Employee), "attendance", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Employee_MAnagement.Models.attendance), true)]
[assembly: EdmRelationshipAttribute("EmployeeDatabaseModel1", "FK_leave_Employee", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Employee_MAnagement.Models.Employee), "leave", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Employee_MAnagement.Models.leave), true)]

#endregion

namespace Employee_MAnagement.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeeDatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeeDatabaseEntities object using the connection string found in the 'EmployeeDatabaseEntities' section of the application configuration file.
        /// </summary>
        public EmployeeDatabaseEntities() : base("name=EmployeeDatabaseEntities", "EmployeeDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDatabaseEntities object.
        /// </summary>
        public EmployeeDatabaseEntities(string connectionString) : base(connectionString, "EmployeeDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeeDatabaseEntities object.
        /// </summary>
        public EmployeeDatabaseEntities(EntityConnection connection) : base(connection, "EmployeeDatabaseEntities")
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
        public ObjectSet<attendance> attendances
        {
            get
            {
                if ((_attendances == null))
                {
                    _attendances = base.CreateObjectSet<attendance>("attendances");
                }
                return _attendances;
            }
        }
        private ObjectSet<attendance> _attendances;
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<leave> leaves
        {
            get
            {
                if ((_leaves == null))
                {
                    _leaves = base.CreateObjectSet<leave>("leaves");
                }
                return _leaves;
            }
        }
        private ObjectSet<leave> _leaves;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the attendances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToattendances(attendance attendance)
        {
            base.AddObject("attendances", attendance);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the leaves EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToleaves(leave leave)
        {
            base.AddObject("leaves", leave);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeDatabaseModel1", Name="attendance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class attendance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new attendance object.
        /// </summary>
        /// <param name="emp_id">Initial value of the Emp_id property.</param>
        /// <param name="emp_name">Initial value of the Emp_name property.</param>
        /// <param name="attendance1">Initial value of the attendance1 property.</param>
        /// <param name="date">Initial value of the date property.</param>
        public static attendance Createattendance(global::System.String emp_id, global::System.String emp_name, global::System.String attendance1, global::System.String date)
        {
            attendance attendance = new attendance();
            attendance.Emp_id = emp_id;
            attendance.Emp_name = emp_name;
            attendance.attendance1 = attendance1;
            attendance.date = date;
            return attendance;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Emp_id
        {
            get
            {
                return _Emp_id;
            }
            set
            {
                if (_Emp_id != value)
                {
                    OnEmp_idChanging(value);
                    ReportPropertyChanging("Emp_id");
                    _Emp_id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Emp_id");
                    OnEmp_idChanged();
                }
            }
        }
        private global::System.String _Emp_id;
        partial void OnEmp_idChanging(global::System.String value);
        partial void OnEmp_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Emp_name
        {
            get
            {
                return _Emp_name;
            }
            set
            {
                if (_Emp_name != value)
                {
                    OnEmp_nameChanging(value);
                    ReportPropertyChanging("Emp_name");
                    _Emp_name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Emp_name");
                    OnEmp_nameChanged();
                }
            }
        }
        private global::System.String _Emp_name;
        partial void OnEmp_nameChanging(global::System.String value);
        partial void OnEmp_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String attendance1
        {
            get
            {
                return _attendance1;
            }
            set
            {
                if (_attendance1 != value)
                {
                    Onattendance1Changing(value);
                    ReportPropertyChanging("attendance1");
                    _attendance1 = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("attendance1");
                    Onattendance1Changed();
                }
            }
        }
        private global::System.String _attendance1;
        partial void Onattendance1Changing(global::System.String value);
        partial void Onattendance1Changed();
    
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

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeDatabaseModel1", "FK_attendance_Employee", "Employee")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_attendance_Employee", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_attendance_Employee", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_attendance_Employee", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("EmployeeDatabaseModel1.FK_attendance_Employee", "Employee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeDatabaseModel1", Name="Employee")]
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

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeDatabaseModel1", "FK_attendance_Employee", "attendance")]
        public EntityCollection<attendance> attendances
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<attendance>("EmployeeDatabaseModel1.FK_attendance_Employee", "attendance");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<attendance>("EmployeeDatabaseModel1.FK_attendance_Employee", "attendance", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeDatabaseModel1", "FK_leave_Employee", "leave")]
        public EntityCollection<leave> leaves
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<leave>("EmployeeDatabaseModel1.FK_leave_Employee", "leave");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<leave>("EmployeeDatabaseModel1.FK_leave_Employee", "leave", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeeDatabaseModel1", Name="leave")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class leave : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new leave object.
        /// </summary>
        /// <param name="leave_id">Initial value of the leave_id property.</param>
        public static leave Createleave(global::System.String leave_id)
        {
            leave leave = new leave();
            leave.leave_id = leave_id;
            return leave;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Emp_id
        {
            get
            {
                return _Emp_id;
            }
            set
            {
                OnEmp_idChanging(value);
                ReportPropertyChanging("Emp_id");
                _Emp_id = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Emp_id");
                OnEmp_idChanged();
            }
        }
        private global::System.String _Emp_id;
        partial void OnEmp_idChanging(global::System.String value);
        partial void OnEmp_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String leave_reason
        {
            get
            {
                return _leave_reason;
            }
            set
            {
                Onleave_reasonChanging(value);
                ReportPropertyChanging("leave_reason");
                _leave_reason = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("leave_reason");
                Onleave_reasonChanged();
            }
        }
        private global::System.String _leave_reason;
        partial void Onleave_reasonChanging(global::System.String value);
        partial void Onleave_reasonChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String leave_from
        {
            get
            {
                return _leave_from;
            }
            set
            {
                Onleave_fromChanging(value);
                ReportPropertyChanging("leave_from");
                _leave_from = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("leave_from");
                Onleave_fromChanged();
            }
        }
        private global::System.String _leave_from;
        partial void Onleave_fromChanging(global::System.String value);
        partial void Onleave_fromChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String leave_to
        {
            get
            {
                return _leave_to;
            }
            set
            {
                Onleave_toChanging(value);
                ReportPropertyChanging("leave_to");
                _leave_to = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("leave_to");
                Onleave_toChanged();
            }
        }
        private global::System.String _leave_to;
        partial void Onleave_toChanging(global::System.String value);
        partial void Onleave_toChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String emp_name
        {
            get
            {
                return _emp_name;
            }
            set
            {
                Onemp_nameChanging(value);
                ReportPropertyChanging("emp_name");
                _emp_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("emp_name");
                Onemp_nameChanged();
            }
        }
        private global::System.String _emp_name;
        partial void Onemp_nameChanging(global::System.String value);
        partial void Onemp_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String user_name
        {
            get
            {
                return _user_name;
            }
            set
            {
                Onuser_nameChanging(value);
                ReportPropertyChanging("user_name");
                _user_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("user_name");
                Onuser_nameChanged();
            }
        }
        private global::System.String _user_name;
        partial void Onuser_nameChanging(global::System.String value);
        partial void Onuser_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String leave_status
        {
            get
            {
                return _leave_status;
            }
            set
            {
                Onleave_statusChanging(value);
                ReportPropertyChanging("leave_status");
                _leave_status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("leave_status");
                Onleave_statusChanged();
            }
        }
        private global::System.String _leave_status;
        partial void Onleave_statusChanging(global::System.String value);
        partial void Onleave_statusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String leave_id
        {
            get
            {
                return _leave_id;
            }
            set
            {
                if (_leave_id != value)
                {
                    Onleave_idChanging(value);
                    ReportPropertyChanging("leave_id");
                    _leave_id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("leave_id");
                    Onleave_idChanged();
                }
            }
        }
        private global::System.String _leave_id;
        partial void Onleave_idChanging(global::System.String value);
        partial void Onleave_idChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeeDatabaseModel1", "FK_leave_Employee", "Employee")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_leave_Employee", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_leave_Employee", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeeDatabaseModel1.FK_leave_Employee", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("EmployeeDatabaseModel1.FK_leave_Employee", "Employee", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}