using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.Contracts
{
    public class SqlContracts
    {
        //JSON設定名
        public const String JSON_CONFIG_NAME = "MySQLSetting";

        //接続情報
        public const String SERVER_NAME = JSON_CONFIG_NAME+":"+ "ServerName";　//サーバー名
        public const String PORT_NUM = JSON_CONFIG_NAME + ":" + "PortNum";　//ポート番号
        public const String DATABASE_NAME =  JSON_CONFIG_NAME + ":" + "DatabaseName";　//データベース名
        public const String USER_NAME = JSON_CONFIG_NAME + ":" + "UserName";　//ユーザ名
        public const String PASSWORD = JSON_CONFIG_NAME + ":" + "Password";　//パスワード

        //テーブル名
        public const String TABLE_NAME_PROJECTS = JSON_CONFIG_NAME + ":" + "TableNameProjects";　//プロジェクト
        public const String TABLE_NAME_TODOLIST_TABLE = JSON_CONFIG_NAME + ":" + "TodolistTable";　//todoリストテーブル

        //プロジェクトテーブル
        //列名
        public const String COLUMN_NAME_PROJECT_ID = JSON_CONFIG_NAME + ":" + "columnNameProjectId";　//プロジェクトID
        public const String COLUMN_NAME_PROJECT_NAME = JSON_CONFIG_NAME + ":" + "columnNameProjectName";　//プロジェクト名
        public const String COLUMN_NAME_PLANNED_HOURS = JSON_CONFIG_NAME + ":" + "columnNamePlanHours";　//予定工数
        public const String COLUMN_NAME_ACTUAL_HOURS = JSON_CONFIG_NAME + ":" + "columnNameActualHours";　//実工数
        public const String COLUMN_NAME_DESIGN_DOCUMENT_LINK = JSON_CONFIG_NAME + ":" + "columnNameDocLink";　//設計図リンク
        public const String COLUMN_NAME_SUPPLEMENT = JSON_CONFIG_NAME + ":" + "columnNameSupplement";　//補足
        public const String COLUMN_NAME_COMPLETE = JSON_CONFIG_NAME + ":" + "columnNameComplete"; //プロジェクトが完了したかどうか

        //todoリストテーブル
        //列名
        public const String COLUMN_NAME_TODOLIST_CONTENTS = JSON_CONFIG_NAME + ":" + "columnNameContents";　//内容
        public const String COLUMN_NAME_TODOLIST_CHECK = JSON_CONFIG_NAME + ":" + "columnNameCheck";　//チェック
        public const String COLUMN_NAME_TODOLIST_REGIST_DATE = JSON_CONFIG_NAME + ":" + "columnNameRegiDate";　//登録日




    }
}
