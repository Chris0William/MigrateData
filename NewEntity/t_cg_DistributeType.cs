using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///分发类型表
    ///</summary>
    [SugarTable("t_cg_DistributeType")]
	[Tenant("newDb")]
    public partial class t_cg_DistributeType
    {
           public t_cg_DistributeType(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:通知人工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? InformStaffID {get;set;}

           /// <summary>
           /// Desc:关联材料类型表ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string referenceId {get;set;}

           /// <summary>
           /// Desc:所属公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:公司编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyNum {get;set;}

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
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

    }
}
