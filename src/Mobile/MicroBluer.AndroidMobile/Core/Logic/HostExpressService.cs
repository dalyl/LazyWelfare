﻿namespace MicroBluer.AndroidMobile.Logic
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Android.Content;
    using MicroBluer.AndroidMobile.AgreementServices;
    using MicroBluer.AndroidMobile.Models;
    using MicroBluer.AndroidUtils;
    using Newtonsoft.Json;

    internal class HostExpressService
    {
        const string ServiceDefineAddress = "/Data/ServiceDefine";
        const string DataAddress = "/Data/";
        const string CommandAddress = "/Command/";
        const string PageAddress = "/Page/";

        HttpClient Client { get; set; }

        public HostExpressService(HostModel model)
        {
            if (model == null) TryCatch.Current.Throw($"{nameof(HostModel)} 未实例化");
            Client = TryCatch.Current.Invoke(null, () => CreateClient(model.Address), "服务地址不可用");
        }

        public bool Enable => Client != null;

        public HostModel GetServiceDefine(string host)
        {
            var content = TryCatch.Current.Invoke(string.Empty, () => GetHostService(host, ServiceDefineAddress), "服务地址不正确或服务不可用");
            if (string.IsNullOrEmpty(content)) return null;
            return TryCatch.Current.Invoke(null, () => JsonConvert.DeserializeObject<HostModel>(content), "服务接口数据解析失败");
        }

        public bool InvokeCommand(Argument arg, Context context)
        {
            if (Enable == false) return TryCatch.Current.Throw<bool> ("Host 服务不可用");
            if (ActiveContext.Agreement.Contains(arg.Service)) return TryCatch.Current.Invoke<bool>(false, () => ActiveContext.Agreement.Execute(arg.Service, context));
            if (string.IsNullOrEmpty(arg.Uri)) return TryCatch.Current.Show(false, $"{arg.Name.Trim()}服务地址未提供");
            var result = TryCatch.Current.Invoke(false, () => SendCommand(arg.Uri));
            if (result == false) TryCatch.Current.Show(false, $"{arg.Name} 命令执行失败");
            return result;
        }

        public bool SendCommand(string cmd)
        {
            if (Enable == false) return TryCatch.Current.Throw<bool> ("Host 服务不可用");
            var url = $"{CommandAddress}{cmd}";
            var fetchResponse = Client.GetAsync(url);
            return true;
        }

        public string GetCommandResult(string cmd)
        {
            if (Enable == false) return TryCatch.Current.Throw<string>("Host 服务不可用");
            var url = $"{CommandAddress}{cmd}";
            var fetchResponse = Client.GetByteArrayAsync(url);
            Task.WaitAll(fetchResponse);
            return Encoding.Default.GetString(fetchResponse.Result);
        }

        public string GetPageContent(string page)
        {
            if (Enable == false) return TryCatch.Current.Throw<string>("Host 服务不可用");
            var url = $"{PageAddress}{page.Replace("-", string.Empty)}";
            var fetchResponse = Client.GetByteArrayAsync(url);
            Task.WaitAll(fetchResponse);
            return Encoding.Default.GetString(fetchResponse.Result);
        }

        string GetHostService(string host, string url)
        {
            var client = CreateClient(host);
            var fetchResponse = client.GetByteArrayAsync(url);
            Task.WaitAll(fetchResponse);
            return Encoding.Default.GetString(fetchResponse.Result);
        }

        HttpClient CreateClient(string host)
        {
            return new HttpClient
            {
                Timeout = new TimeSpan(0, 0, 5),
                BaseAddress = new Uri(host)
            };
        }

    }
}