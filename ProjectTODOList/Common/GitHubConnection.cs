using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.Common
{

    
    internal class GitHubConnection
    {

        private static IConfigurationRoot _config = null;

        public GitHubConnection()
        {

        }
        public static void test()
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

        public static String getValue(String key)
        {
            return _config[key];
        }

    }
}
