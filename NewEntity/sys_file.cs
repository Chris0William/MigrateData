using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///文件信息表
    ///</summary>
    [SugarTable("sys_file")]
	[Tenant("newDb")]
    public partial class sys_file
    {
           public sys_file(){


           }
           /// <summary>
           /// Desc:Id主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long Id {get;set;}

           /// <summary>
           /// Desc:文件存储位置
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int FileLocation {get;set;}

           /// <summary>
           /// Desc:文件仓库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileBucket {get;set;}

           /// <summary>
           /// Desc:文件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileOriginName {get;set;}

           /// <summary>
           /// Desc:文件后缀
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSuffix {get;set;}

           /// <summary>
           /// Desc:文件大小kb
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSizeKb {get;set;}

           /// <summary>
           /// Desc:文件大小信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileSizeInfo {get;set;}

           /// <summary>
           /// Desc:存储到bucket的名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileObjectName {get;set;}

           /// <summary>
           /// Desc:存储路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FilePath {get;set;}

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
           /// Desc:软删除标记
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
