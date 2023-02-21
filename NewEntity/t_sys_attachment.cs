using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///附件表
    ///</summary>
    [SugarTable("t_sys_attachment")]
	[Tenant("newDb")]
    public partial class t_sys_attachment
    {
           public t_sys_attachment(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:文件路径
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FilePath {get;set;}

           /// <summary>
           /// Desc:文件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileOriginName {get;set;}

           /// <summary>
           /// Desc:文件大小
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSizeKb {get;set;}

           /// <summary>
           /// Desc:文件后缀
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSuffix {get;set;}

           /// <summary>
           /// Desc:关联识别Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReferneceId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:文件来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Source {get;set;}

           /// <summary>
           /// Desc:上传日期
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
           /// Desc:上传人
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
