using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsQueryResponse : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [XmlElement("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为“其它品牌”
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 最细的类目编号
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// leads认领时间
        /// </summary>
        [XmlElement("claim_time")]
        public string ClaimTime { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// leads创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 门店内景图。  建议上传3-10张，尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlArray("detail_images")]
        [XmlArrayItem("string")]
        public List<string> DetailImages { get; set; }

        /// <summary>
        /// 门店内景图名称列表
        /// </summary>
        [XmlArray("detail_images_name")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesName { get; set; }

        /// <summary>
        /// 门店内景图URL列表
        /// </summary>
        [XmlArray("detail_images_url")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesUrl { get; set; }

        /// <summary>
        /// 区县编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 扩展属性，JSON格式：keyMerchant-是否重点商户（T/F）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否隐藏：T-是，F-否。
        /// </summary>
        [XmlElement("is_hidden")]
        public string IsHidden { get; set; }

        /// <summary>
        /// 是否系统导入leads：T-是，F-否。
        /// </summary>
        [XmlElement("is_system_import")]
        public string IsSystemImport { get; set; }

        /// <summary>
        /// 纬度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 支付宝leads ID，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// PUBLIC：公海 PRIVATE：私海
        /// </summary>
        [XmlElement("leads_range")]
        public string LeadsRange { get; set; }

        /// <summary>
        /// 经度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 门店首图。  建议尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 门店首图名称
        /// </summary>
        [XmlElement("main_image_name")]
        public string MainImageName { get; set; }

        /// <summary>
        /// 门店首图URL
        /// </summary>
        [XmlElement("main_image_url")]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 主门店名
        /// </summary>
        [XmlElement("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 省份编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 请求ID，标识本次创建请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// leads状态。  INIT：未认领，CLAIMED：已认领，CONFIRMING：待商户确认，RELATED：已关联商户，OPENING：开店中，OPENED：已开店。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
