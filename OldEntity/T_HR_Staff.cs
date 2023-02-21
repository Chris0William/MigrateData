using System;
using System.Linq;
using System.Text;
using MigrateData.NewEntity;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///员工信息表
    ///</summary>
    [SugarTable("T_HR_Staff")]
    [Tenant("oldDb")]
    public partial class T_HR_Staff
    {
        public T_HR_Staff()
        {


        }
        /// <summary>
        /// Desc:工号
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public string StaffID { get; set; }

        /// <summary>
        /// Desc:姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:电话号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TelNum { get; set; }

        /// <summary>
        /// Desc:紧急联系人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Urgencyperson { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string UPRelationship { get; set; }

        /// <summary>
        /// Desc:紧急联系人电话
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string UPTelNum { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Email { get; set; }

        /// <summary>
        /// Desc:民族
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Nation { get; set; }

        /// <summary>
        /// Desc:雇佣状态
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string HireState { get; set; }

        /// <summary>
        /// Desc:证件类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CertificateType { get; set; }

        /// <summary>
        /// Desc:证件号码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CertificateNum { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string IDNumberPath { get; set; }

        /// <summary>
        /// Desc:身份证地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string IdCardAddress { get; set; }

        /// <summary>
        /// Desc:籍贯
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Nativeplace { get; set; }

        /// <summary>
        /// Desc:生日
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Sex { get; set; }

        /// <summary>
        /// Desc:婚姻状况
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Desc:员工类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string StaffType { get; set; }

        /// <summary>
        /// Desc:工作地点
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WorkAddress { get; set; }

        /// <summary>
        /// Desc:地区
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Area { get; set; }

        /// <summary>
        /// Desc:银行账号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BankAccount { get; set; }

        /// <summary>
        /// Desc:银行类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BankType { get; set; }

        /// <summary>
        /// Desc:工种
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Craft { get; set; }

        /// <summary>
        /// Desc:学历
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Education { get; set; }

        /// <summary>
        /// Desc:毕业院校
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GraduationSchool { get; set; }

        /// <summary>
        /// Desc:专业
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Major { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Remark { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CreaterName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string EditorName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? EditeTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ID1 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ID2 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ID3 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ID4 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ID5 { get; set; }

        /// <summary>
        /// Desc:总部门
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Department { get; set; }

        /// <summary>
        /// Desc:照片
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ImagePath { get; set; }

        /// <summary>
        /// Desc:社保类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SocialInsuranceType { get; set; }

        /// <summary>
        /// Desc:参保日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SSStartdate { get; set; }

        /// <summary>
        /// Desc:停保日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SSEnddate { get; set; }

        /// <summary>
        /// Desc:是否打卡
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string NoAttend { get; set; }

        /// <summary>
        /// Desc:预离职日
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? PreDimissionDate { get; set; }

        /// <summary>
        /// Desc:预离职类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DimissionType { get; set; }

        /// <summary>
        /// Desc:预离职原因
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DimissionReason { get; set; }

        /// <summary>
        /// Desc:试用期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? Probation { get; set; }

        /// <summary>
        /// Desc:试用期截止日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? ProbationDate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? ProbationValid { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? FundValid { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string JobList { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Job { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string JobDuty { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string JobLevel { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OwnCompany { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? Hiredate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? Seniorty { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PermitType { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? PermitDate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Introducer { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PromoteCheck { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Director { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string EducationProperty { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CardValidDate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? GraduateTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string HaveDiploma { get; set; }

        [Navigate(NavigateType.OneToOne, nameof(StaffID), nameof(T_PE_Users.EmployeeID))]//一对一 SchoolId是StudentA类里面的
        public T_PE_Users userEntity { get; set; }

    }
}
