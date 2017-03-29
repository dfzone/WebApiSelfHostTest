using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public class Goods : BasePoco
    {
        [Display(Name = "会员标识")]
        [StringLength(200)]
        public string BPOID { get; set; }

        [Display(Name = "会员门牌号")]
        [StringLength(10)]
        public string MemberNo { get; set; }

        [Display(Name = "商品编号")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GoodsCode { get; set; }

        [Display(Name = "商品名称")]
        [Required]
        [StringLength(200)]
        public string GoodsName { get; set; }

        [Display(Name = "商品描述")]
        [StringLength(500)]
        public string Description { get; set; }

        [Display(Name = "备注")]
        public string Memo { get; set; }

        [Display(Name = "虚拟信息")]
        public string VirtualInfo { get; set; }

        [Display(Name = "最小价格")]
        public decimal PriceMin { get; set; }

        [Display(Name = "最大价格")]
        public decimal PriceMax { get; set; }

        [Display(Name = "是否上架")]
        public bool IsMarketable { get; set; }

        [Display(Name = "是否包邮")]
        public bool IsFreeShipping { get; set; }

        [Display(Name = "是否删除")]
        public bool IsDelete { get; set; }

        [Display(Name = "是否虚拟商品")]
        public bool IsVirtual { get; set; }

        [Display(Name = "是否隐藏")]
        public bool IsHidden { get; set; }

        [Display(Name = "是否活动商品")]
        public bool? IsActivity { get; set; }

        [Display(Name = "是否代理商品")]
        public bool? IsAgent { get; set; }

        [Display(Name = "成本价")]
        public decimal? CostPrice { get; set; }

        [Display(Name = "平台价")]
        public decimal? PlatPrice { get; set; }

        [Display(Name = "市场价")]
        public decimal? MarketPrice { get; set; }

        [Display(Name = "提成比例")]
        public decimal? Percentage { get; set; }

        [Display(Name = "运费价")]
        public decimal? TranPrice { get; set; }

    }

}
