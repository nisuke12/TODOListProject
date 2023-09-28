using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ProjectTODOList.Contracts;
using System.Text.RegularExpressions;

namespace ProjectTODOList.Common
{

    /// <summary>
    /// GitApi接続クラス
    /// </summary>
    internal class GitHubConnection
    {

        //コミット情報を格納するMap
        IDictionary<string, string> commitInfoMap = new Dictionary<string, string>();

        //ユーザ名
        private string _username = AppJsonAccess.getValue(GitContracts.USER_NAME);
        //トークン
       private string _accessToken = AppJsonAccess.getValue(GitContracts.TOKEN); 
        //リポジトリ
        private string _repositoryName = null;

        //レスポンス情報
        private HttpResponseMessage _response = null;

        private string _apiUrl = null;



        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="repositoryName"></param>
        public GitHubConnection(string repositoryName)
        {
            _repositoryName = repositoryName;
            setCommitInfo();

        }

        /// <summary>
        /// GitAPIの接続処理
        /// </summary>
        public void GitConnect()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "YourAppName");
                client.DefaultRequestHeaders.Add("Authorization", $"token {_accessToken}");

                _apiUrl = $"https://api.github.com/repos/{_username}/{_repositoryName}/commits";
                _response = client.GetAsync(_apiUrl).Result; // 同期呼び出し
            }
        }


        /// <summary>
        /// コミット情報を取得
        /// </summary>
        /// <returns>コミットメッセージ->差分URLのMap</returns>
        public  void setCommitInfo()
        {
            commitInfoMap = new Dictionary<string, string>();
                GitConnect();
            string responseBody = _response.Content.ReadAsStringAsync().Result;
            var commits = JsonConvert.DeserializeObject<JArray>(responseBody);


            // 最新のコミットのSHAを取得
            if (commits.Count > 0)
                {
                for (int i = 0; i < commits.Count; i++)
                {
                    String githubUrl = $"https://github.com/{_username}/{_repositoryName}/commit";
                    string commitSHA = commits[i]["sha"].ToString();
                    string commitUrl = githubUrl +"/"+ commitSHA;
                    String commitMessage = commits[i]["commit"]["message"].ToString();

                    commitInfoMap.Add(commitMessage, commitUrl);
                }
                }
            }

        /// <summary>
        /// コミットメッセージ -> URLのMapを返す
        /// </summary>
        /// <returns></returns>
       public IDictionary<string, string> getCommitInfo()
        {
            return commitInfoMap;
        }

        /// <summary>
        /// コミットメッセージから番号とメッセージをお取得する
        /// </summary>
        /// <param name="str">コミットメッセージ</param>
        /// <returns>数字と文字列のMap</returns>
       public static IDictionary<string, string> getCommitNumToMessage(String str)
        {
            // 正規表現パターンを定義
            string pattern = @"^#(\d+) (.+)$";
            // 正規表現に一致するかチェック
            Match match = Regex.Match(str, pattern);
            IDictionary<string, string> numToMessageMap = new Dictionary<string, string>();
            if (match.Success)
            {
                // グループ1に#の後の数字が、グループ2に文字列が一致
                string numberPart = match.Groups[1].Value;
                string textPart = match.Groups[2].Value;
                numToMessageMap.Add(numberPart, textPart);
                return numToMessageMap;

            }
            else
            {
                return null;
            }
        }
    }

}
