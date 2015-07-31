using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Win32;

namespace Spinpreach.SwordsDanceViewer
{
    public static class ViewerRegistry
    {

        #region enum

        #region ENUM_RENDERING_MODE

        /// <summary>ENUM_RENDERING_MODE</summary>
        public enum ENUM_RENDERING_MODE
        {
            IE8 = 8000,
            IE9 = 9000,
            IE10 = 10000,
            IE11 = 11000,
        }

        #endregion

        #endregion

        #region SetRenderingMode

        /// <summary>
        /// [ WebBrowser Control Rendering Mode ] を設定するメソッドです。
        /// </summary>
        public static void SetRenderingMode(ENUM_RENDERING_MODE value)
        {

            string FEATURE_BROWSER_EMULATION = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            //string exename = Assembly.GetEntryAssembly().ManifestModule.Name;
            string exename = System.AppDomain.CurrentDomain.FriendlyName;

            try
            {
                using (RegistryKey reg2 = Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION))
                {
                    reg2.SetValue(exename, value, RegistryValueKind.DWord);
                    reg2.Close();
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("[ WebBrowser Control Rendering Mode ] の設定に失敗しました。");
            }

        }

#endregion

    }
}
