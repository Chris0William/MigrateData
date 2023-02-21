using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///供应商信息表
    ///</summary>
    [SugarTable("T_GM_SupplierInfo")]
	[Tenant("oldDb")]
    public partial class T_GM_SupplierInfo
    {
           public T_GM_SupplierInfo(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal UID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GID {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:供应商名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierClass {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contact {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Fax {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:供应商信息录入人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InputPerson {get;set;}

           /// <summary>
           /// Desc:供应商信息录入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InputTime {get;set;}

           /// <summary>
           /// Desc:银行账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccount {get;set;}

           /// <summary>
           /// Desc:主营产品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainProduct {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:资质路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QualificationPath {get;set;}

           /// <summary>
           /// Desc:供应商资质名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QualificationName {get;set;}

           /// <summary>
           /// Desc:开户行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:付款周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentCycle {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Bank {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyProperity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PicturePathName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PicturePath {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isEnable {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReviewTable {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReviewTableName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierGrade {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? ON_OFF {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string paymentWay {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IntegrityFile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IntegrityName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SafetyFile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SafetyName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AcceptanceFile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AcceptanceName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FrameworkFile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FrameworkName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string applicant {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FoundingTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Registeredcapital {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Businessscope {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Introductiondate {get;set;}

    }
}
