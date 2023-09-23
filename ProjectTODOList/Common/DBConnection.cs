using MySqlConnector;
using ProjectTODOList.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjectTODOList.Common
{
    public class DBConnection
    {
        // MySQLへの接続情報
       private string _server = null;   //サーバ名
       private  string _database = null;    // データーベース
        private string _port = null;
       private string _user = null;   //ユーザ名
       private string _pass = null;   //パスワード
       private string _charset = null;    // 文字コードセット
        private string _connectionString = null; //接続文字列
        private MySqlConnection _connection = null; //DBのコネクション
        private MySqlTransaction _transaction = null; //DBのトランザクション

        public DBConnection(String server,String port,String database,String user,String pass)
        {
            _server = server;
            _port = port;
            _database = database;
            _user = user;
               _pass = pass;

            _connectionString = string.Format($"Server={server};Port={port};Database={database};Uid={user};Pwd={pass}");
            _connection = new MySqlConnection(_connectionString);
        }


        /// <summary>
        /// データの登録を実行する
        /// </summary>
        /// <param name="sqlList">sqlが格納されたリスト</param>
        public void InsertCommand(String[] sqlList,Boolean isCommit)
        {
            
            try
            {

                using (var command = new MySqlCommand())
                {
                    // コネクションをオープンします。
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open(); // 接続を開く前に状態を確認し、閉じている場合のみ開く
                    }

                    // トランザクションを開始します。
                    if (_transaction == null || _transaction.Connection == null)
                    {
                        _transaction = _connection.BeginTransaction();
                    }
                    command.Transaction = _transaction;

                    // データ登録SQLを実行します。
                    command.Connection = _connection;
                    for(int i =0; i < sqlList.Length; i++) {
                        command.CommandText = sqlList[i];
                        var result = command.ExecuteNonQuery();
                        // データ登録できない場合
                        if (result != 1)
                        {
                            Console.WriteLine("データが登録できませんでした。");
                            _transaction.Rollback();
                        }
                    }

                    if (isCommit)
                    {
                        _transaction.Commit();
                    }
                    


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _transaction.Rollback();
            }
        }

        /// <summary>
        /// コミットを行う
        /// </summary>
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                RollBack();
            }

        }

        /// <summary>
        /// ロールバックを行う
        /// </summary>
        public void RollBack()
        {
                _transaction.Rollback();
        }

        /// <summary>
        /// データの削除を実行する
        /// </summary>
        /// <param name="sqlList">sqlが格納されたリスト</param>
        public void DeleteCommand(String[] sqlList, Boolean isCommit) {

            
            try
            {

                using (var command = new MySqlCommand())
                {
                    // コネクションをオープンします。
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open(); // 接続を開く前に状態を確認し、閉じている場合のみ開く
                    }

                    // トランザクションを開始します。
                    if (_transaction == null || _transaction.Connection == null)
                    {
                        _transaction = _connection.BeginTransaction();
                    }
                    command.Transaction = _transaction;

                    // データ更新SQLを実行します。
                    command.Connection = _connection;
                    for (int i = 0; i < sqlList.Length; i++)
                    {
                        command.CommandText = sqlList[i];
                        var result = command.ExecuteNonQuery();
                        // データ更新できない場合
                        if (result != 1)
                        {
                            Console.WriteLine("データが更新できませんでした。");
                            _transaction.Rollback();
                        }
                    }

                    if (isCommit)
                    {
                        _transaction.Commit();
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _transaction.Rollback();
            }
        }

        /// <summary>
        /// データの更新を実行する
        /// </summary>
        /// <param name="sqlList">sqlが格納されたリスト</param>
        public void UpdateCommand(String[] sqlList, Boolean isCommit)
        {
            
            try
            {
               
                using (var command = new MySqlCommand())
                {
                    // コネクションをオープンします。
                    if (_connection.State == ConnectionState.Closed)
                    {
                        _connection.Open(); // 接続を開く前に状態を確認し、閉じている場合のみ開く
                    }

                    // トランザクションを開始します。
                    if (_transaction == null || _transaction.Connection == null)
                    {
                        _transaction = _connection.BeginTransaction();
                    }
                    command.Transaction = _transaction;

                    // データ更新SQLを実行します。
                    command.Connection = _connection;
                    for (int i = 0; i < sqlList.Length; i++)
                    {
                        command.CommandText = sqlList[i];
                        var result = command.ExecuteNonQuery();
                        // データ更新できない場合
                        if (result != 1)
                        {
                            Console.WriteLine("データが更新できませんでした。");
                            _transaction.Rollback();
                        }
                    }

                    if (isCommit)
                    {
                        _transaction.Commit();
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _transaction.Rollback();
            }
        }

        /// <summary>
        /// データの選択を実行する
        /// </summary>
        public String[] SelectCommand(String tableName, String columnName)
        {
            try
            {
                // コネクションオブジェクトとコマンドオブジェクトを生成します。
                using (var connection = new MySqlConnection(_connectionString))
                using (var command = new MySqlCommand())
                {
                    // コネクションをオープンします。
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open(); // 接続を開く前に状態を確認し、閉じている場合のみ開く
                    }

                    // データ登録SQLを実行します。
                    command.Connection = connection;
                    command.CommandText = $"SELECT {columnName} FROM {tableName}";
                        var result = command.ExecuteNonQuery();

                    var reader = command.ExecuteReader();
                    ArrayList targetColumnList = new ArrayList();

                    // 検索結果が1行以上ある場合
                    if (reader.HasRows)
                    {
 

                        // 検索結果の行数分繰り返します。
                        while (reader.Read())
                        {
                            // 各カラムの値を取得し、表示します。
                             targetColumnList.Add(reader[columnName]) ;
                        }

                    }
                    return (String[])targetColumnList.ToArray(typeof(String));


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }


        }

        /// <summary>
        /// テーブルからすべてのカラムを取得する
        /// </summary>
        /// <param name="tableName"></param>
        public DataTable getAllColumn(String tableName)
        {

            try { 
            string query = $"SELECT * FROM {tableName}";
            // コネクションオブジェクトとコマンドオブジェクトを生成します。
            using (var connection = new MySqlConnection(_connectionString))
            // MySQLクエリを定義します（この例では全てのデータを取得します）。


            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataSet dataSet = new DataSet();

                // データを取得し、DataSetに格納します。
                adapter.Fill(dataSet, tableName);

                // テーブルを取得
                DataTable table = dataSet.Tables[tableName];
                return table;
            }
        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
}
    }
}
