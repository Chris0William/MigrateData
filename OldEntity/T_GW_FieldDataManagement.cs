using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_GW_FieldDataManagement")]
	[Tenant("oldDb")]
    public partial class T_GW_FieldDataManagement
    {
           public T_GW_FieldDataManagement(){


           }
           /// <summary>
           /// Desc:自增长主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public decimal ID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:现场名字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldName {get;set;}

           /// <summary>
           /// Desc:上传人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UploadMan {get;set;}

           /// <summary>
           /// Desc:上传时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UploadTime {get;set;}

           /// <summary>
           /// Desc:附件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnnetName {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnnetPath {get;set;}

    }
}
