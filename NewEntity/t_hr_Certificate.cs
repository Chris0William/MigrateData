using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///资质证书表
    ///</summary>
    [SugarTable("t_hr_Certificate")]
	[Tenant("newDb")]
    public partial class t_hr_Certificate
    {
           public t_hr_Certificate(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:员工工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long StaffID {get;set;}

           /// <summary>
           /// Desc:证书名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertificateName {get;set;}

           /// <summary>
           /// Desc:证书编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertificateNum {get;set;}

           /// <summary>
           /// Desc:发证日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Startdate {get;set;}

           /// <summary>
           /// Desc:截止日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Deadline {get;set;}

           /// <summary>
           /// Desc:证书保存路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CerImage {get;set;}

           /// <summary>
           /// Desc:生效（1表示生效）后期自动执行判断证书有效
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool Valid {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:创建者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
