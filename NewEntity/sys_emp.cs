using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///员工表
    ///</summary>
    [SugarTable("sys_emp")]
	[Tenant("newDb")]
    public partial class sys_emp
    {
           public sys_emp(){


           }
           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? JobNum {get;set;}

           /// <summary>
           /// Desc:机构Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long? OrgId {get;set;}

           /// <summary>
           /// Desc:机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrgName {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffName {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TelNum {get;set;}

           /// <summary>
           /// Desc:紧急联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Urgencyperson {get;set;}

           /// <summary>
           /// Desc:紧急联系人关系
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPRelationship {get;set;}

           /// <summary>
           /// Desc:紧急联系人电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPTelNum {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:民族
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Nation {get;set;}

           /// <summary>
           /// Desc:籍贯
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Nativeplace {get;set;}

           /// <summary>
           /// Desc:雇佣/解雇日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? HireDate {get;set;}

           /// <summary>
           /// Desc:雇佣状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HireState {get;set;}

           /// <summary>
           /// Desc:证件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertificateType {get;set;}

           /// <summary>
           /// Desc:证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertificateNum {get;set;}

           /// <summary>
           /// Desc:身份证件保存路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDNumberPath {get;set;}

           /// <summary>
           /// Desc:身份证地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IdCardAddress {get;set;}

           /// <summary>
           /// Desc:生日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Birthday {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Sex {get;set;}

           /// <summary>
           /// Desc:婚姻状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaritalStatus {get;set;}

           /// <summary>
           /// Desc:员工类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffType {get;set;}

           /// <summary>
           /// Desc:工作地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WorkAddress {get;set;}

           /// <summary>
           /// Desc:区域
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Area {get;set;}

           /// <summary>
           /// Desc:银行账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccount {get;set;}

           /// <summary>
           /// Desc:银行类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankType {get;set;}

           /// <summary>
           /// Desc:工种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Craft {get;set;}

           /// <summary>
           /// Desc:学历
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Education {get;set;}

           /// <summary>
           /// Desc:学历性质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EducationProperty {get;set;}

           /// <summary>
           /// Desc:毕业时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? GraduateTime {get;set;}

           /// <summary>
           /// Desc:毕业学校
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GraduationSchool {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? FundValid {get;set;}

           /// <summary>
           /// Desc:职级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JobList {get;set;}

           /// <summary>
           /// Desc:职位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Job {get;set;}

           /// <summary>
           /// Desc:职称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JobDuty {get;set;}

           /// <summary>
           /// Desc:职等
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JobLevel {get;set;}

           /// <summary>
           /// Desc:专业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Major {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Department {get;set;}

           /// <summary>
           /// Desc:图片路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ImagePath {get;set;}

           /// <summary>
           /// Desc:社保类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SocialInsuranceType {get;set;}

           /// <summary>
           /// Desc:参保日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SSStartdate {get;set;}

           /// <summary>
           /// Desc:停保日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SSEnddate {get;set;}

           /// <summary>
           /// Desc:是否打卡
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NoAttend {get;set;}

           /// <summary>
           /// Desc:预离职日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PreDimissionDate {get;set;}

           /// <summary>
           /// Desc:预离职类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DimissionType {get;set;}

           /// <summary>
           /// Desc:预离职原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DimissionReason {get;set;}

           /// <summary>
           /// Desc:试用期几个月
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Probation {get;set;}

           /// <summary>
           /// Desc:试用期截止日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProbationDate {get;set;}

           /// <summary>
           /// Desc:是否试用期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ProbationValid {get;set;}

           /// <summary>
           /// Desc:直属主管
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Director {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
