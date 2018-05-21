﻿using Common.Logging;
using LazyWelfare.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;
using System.Windows;
using LazyWelfare.ServerCore;
namespace LazyWelfare.ServerHost.Service
{
    public class ServiceProcess
    {
        private static readonly ILog logger = LogManager.GetLogger(nameof(ServiceProcess));

        public readonly static ServiceProcess Instance = new ServiceProcess();

        #region Process

        public Process Process { get; private set; }

        ProcessStartInfo SetProcessInfo(string args)
        {
            ProcessStartInfo psi;
            psi = new ProcessStartInfo("dotnet");
            psi.Arguments += args;

            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;  //允许重定向标准输出
            psi.RedirectStandardInput = true;   //接受来自调用程序的输入信息

            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            return psi;
        }

        public void Start()
        {
            if (Process != null) return;
            Task.Run(() =>
            {
                ServerEnvironment.Instance.Port = FreePort.FindNextAvailableTCPPort(ServerEnvironment.Instance.Port);
                var line = $@"{ServerEnvironment.Instance.Path}{ServerEnvironment.Instance.WebName}.dll --urls=http://*:{ServerEnvironment.Instance.Port}";
                var psi = SetProcessInfo(line);
                Process = Process.Start(psi);
                Process.OutputDataReceived += new DataReceivedEventHandler(Instance.OnDataReceived);
                Process.BeginOutputReadLine();
                Process.WaitForExit();
                if (Process.ExitCode != 0)
                {
                    logger.Info(Process.StandardError.ReadToEnd());
                }
                Process.Close();
                Process = null;
            });
        }

        public void Stop()
        {
            if (Process == null) return;
            Process.Kill();
            logger.Info("Process Closed");
        }

        void OnDataReceived(object Sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                logger.Info(e.Data);
            }
        }

        #endregion

        #region QRCode


        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);

        public ImageSource CreateImageSource( int width, int height)
        {
            if (Process == null) return CreateImageSource(()=> ServerCore.ImageCreate.TextBitmap("未启动", width, height));
            return CreateImageSource(()=> ServerCore.ImageCreate.QRCode(ServerEnvironment.Instance.WebAddress, width, height));
        }

        ImageSource CreateImageSource( Func<System.DrawingCore.Bitmap> fetchImage)
        {
            var bitmap = fetchImage();
            IntPtr ip = bitmap.GetHbitmap();//从GDI+ Bitmap创建GDI位图对象
                                            //Imaging.CreateBitmapSourceFromHBitmap方法，基于所提供的非托管位图和调色板信息的指针，返回一个托管的BitmapSource
            BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip, IntPtr.Zero, Int32Rect.Empty,
            System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            DeleteObject(ip);
            return bitmapSource;
        }

        #endregion


    }
}
