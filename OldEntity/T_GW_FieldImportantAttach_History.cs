using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_GW_FieldImportantAttach_History")]
	[Tenant("oldDb")]
    public partial class T_GW_FieldImportantAttach_History
    {
           public T_GW_FieldImportantAttach_History(){


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
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:附件类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AnnetType {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AnnetPath {get;set;}

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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TypeName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? version {get;set;}

    }
}
