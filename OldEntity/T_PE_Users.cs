using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PE_Users")]
	[Tenant("oldDb")]
    public partial class T_PE_Users
    {
           public T_PE_Users(){


           }
           /// <summary>
           /// Desc:用户ID（GUID）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// Desc:用户真实姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserDspName {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Sex {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserImage {get;set;}

           /// <summary>
           /// Desc:生日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Birthday {get;set;}

           /// <summary>
           /// Desc:手机号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MobilePhone {get;set;}

           /// <summary>
           /// Desc:办公号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OfficePhone {get;set;}

           /// <summary>
           /// Desc:家庭号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HomePhone {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? SendEmailMsg {get;set;}

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
           public string QQ {get;set;}

           /// <summary>
           /// Desc:住址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:雇佣ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EmployeeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Activity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserType {get;set;}

           /// <summary>
           /// Desc:部门ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DeptID {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DeptName {get;set;}

           /// <summary>
           /// Desc:公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyID {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Style {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Editor {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditeTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LastLoginIP {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastLoginTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LastMacAddress {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CurrentLoginIP {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CurrentLoginTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CurrentMacAddress {get;set;}

           /// <summary>
           /// Desc:上次修改密码时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastPasswordTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LoginUserKey {get;set;}

    }
}
