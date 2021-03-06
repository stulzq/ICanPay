﻿using ICanPay.Core;
using Microsoft.AspNetCore.Mvc;

namespace ICanPay.Demo.Controllers
{
    public class RefundQueryController : Controller
    {
        private IGateways gateways;

        public RefundQueryController(IGateways gateways)
        {
            this.gateways = gateways;
        }

        public IActionResult Index(string id)
        {
            var notify = (Alipay.Notify)RefundQueryAlipayOrder(id);

            return Json(notify);
        }

        /// <summary>
        /// 查询支付宝的订单
        /// </summary>
        private Alipay.Notify RefundQueryAlipayOrder(string id)
        {
            var gateway = gateways.Get(GatewayType.Alipay);

            return (Alipay.Notify)gateway.RefundQuery(new Alipay.Auxiliary
            {
                OutTradeNo = id,
                TradeNo = "12",
                OutRefundNo = "123"
            });
        }

        /// <summary>
        /// 查询微信的订单
        /// </summary>
        private Wechatpay.Notify RefundQueryWechatpayOrder(string id)
        {
            var gateway = gateways.Get(GatewayType.Wechatpay);

            return (Wechatpay.Notify)gateway.RefundQuery(new Wechatpay.Auxiliary
            {
                OutTradeNo = id
            });
        }
    }
}
