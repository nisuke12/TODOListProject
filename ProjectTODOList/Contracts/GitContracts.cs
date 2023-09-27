using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.Contracts
{
    /// <summary>
    /// Git関連のの定数クラス
    /// </summary>
    public class GitContracts
    {
        //Git設定名
        public const String GIT_CONFIG_NAME = "GitSetting";

        //ユーザ名
        public const String USER_NAME =GIT_CONFIG_NAME+":"+ "GitUserName";

        //Git接続のためのapiトークン
        public const String TOKEN = GIT_CONFIG_NAME + ":" + "GitApiToken";
    }
}
