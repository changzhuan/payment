﻿using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付 - JSAPI下单API
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_2.shtml">JSAPI下单API</a></para>
    /// 最新更新时间：2020.05.26
    /// </summary>
    public class WeChatPayTransactionsJsApiRequest : IWeChatPayPostRequest<WeChatPayTransactionsJsApiResponse>
    {
        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/pay/transactions/jsapi";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
