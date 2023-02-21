using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///分发材料表
    ///</summary>
    [SugarTable("t_cg_DistributeM")]
	[Tenant("newDb")]
    public partial class t_cg_DistributeM
    {
           public t_cg_DistributeM(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:物料表自增ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? MaterialUID {get;set;}

           /// <summary>
           /// Desc:处理人工号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? StaffID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:是否展示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Show {get;set;}

           /// <summary>
           /// Desc:关联ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string referenceID {get;set;}

    }
}
