using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///现场信息管理
    ///</summary>
    [SugarTable("t_xm_FieldInfoManagement")]
	[Tenant("newDb")]
    public partial class t_xm_FieldInfoManagement
    {
           public t_xm_FieldInfoManagement(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:工地名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldName {get;set;}

           /// <summary>
           /// Desc:现场负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldPrincipalName {get;set;}

           /// <summary>
           /// Desc:现场负责人工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? FieldPrincipalId {get;set;}

           /// <summary>
           /// Desc:平面图名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldMapName {get;set;}

           /// <summary>
           /// Desc:平面图路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FieldMapPath {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:客户满意度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CustomRating {get;set;}

           /// <summary>
           /// Desc:项目描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectDescribe {get;set;}

           /// <summary>
           /// Desc:现场地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Adress {get;set;}

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

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarehouseID {get;set;}

    }
}
