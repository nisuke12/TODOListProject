using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.Common
{
    /// <summary>
    /// JSON設定ファイルの値を取得するためのクラス
    /// </summary>
    internal class AppJsonAccess
    {
        //設定ファイルを読み込むクラス
       private static IConfigurationRoot _config = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AppJsonAccess() { 
            LoadJsonFile();
        }

        /// <summary>
        /// JSON設定ファイルを読み込む
        /// </summary>
        public static void LoadJsonFile()
        {
            Console.WriteLine(System.Environment.CurrentDirectory);
            // appsettings.json ファイルのパスを環境変数から取得
            var appJsonFilePath = Environment.GetEnvironmentVariable("appsettings.json_path");

            // パスが空でないかを確認
            if (string.IsNullOrEmpty(appJsonFilePath))
            {
                appJsonFilePath = System.Environment.CurrentDirectory;
                appJsonFilePath = appJsonFilePath + "\\..\\..\\..\\external_Files\\appsettings.json";
            }

            if (!File.Exists(appJsonFilePath))
            {
                Console.WriteLine($"ファイルパスが存在しません：{appJsonFilePath}");
            }

            // ファイルパスを指定して設定情報を読み込む
            _config = new ConfigurationBuilder()
            .AddJsonFile(appJsonFilePath)
            .Build();

        }

        /// <summary>
        /// JSONファイルの設定ファイルから値を取得する
        /// </summary>
        /// <param name="key">キー</param>
        /// <returns></returns>
        public static String getValue(String key)
        {
            return _config[key];
        }

    }
}
