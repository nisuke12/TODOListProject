using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.Contracts
{
    public class SqlContracts
    {
        //接続情報
        public const String SERVER_NAME = "localhost";　//サーバー名
        public const String PORT_NUM = "3306";　//ポート番号
        public const String DATABASE_NAME = "todoproject";　//データベース名
        public const String USER_NAME = "arimar";　//ユーザ名
        public const String PASSWORD = "arimar";　//パスワード

        //テーブル名
        public const String TABLE_NAME_PROJECTS = "projects";　//プロジェクト
        public const String TABLE_NAME_TODOLIST_TABLE = "todolist_table";　//todoリストテーブル

        //プロジェクトテーブル
        //列名
        public const String COLUMN_NAME_PROJECT_ID = "project_id";　//プロジェクトID
        public const String COLUMN_NAME_PROJECT_NAME = "project_name";　//プロジェクト名
        public const String COLUMN_NAME_PLANNED_HOURS = "planned_hours";　//予定工数
        public const String COLUMN_NAME_ACTUAL_HOURS = "actual_hours";　//実工数
        public const String COLUMN_NAME_DESIGN_DOCUMENT_LINK = "design_document_link";　//設計図リンク
        public const String COLUMN_NAME_SUPPLEMENT = "supplement";　//補足
        public const String COLUMN_NAME_COMPLETE = "complete"; //プロジェクトが完了したかどうか

        //todoリストテーブル
        //列名
        public const String COLUMN_NAME_TODOLIST_CONTENTS = "todoList_contents";　//内容
        public const String COLUMN_NAME_TODOLIST_CHECK = "todoList_check";　//チェック
        public const String COLUMN_NAME_TODOLIST_REGIST_DATE = "todolist_regist_date";　//登録日




    }
}
