using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using Entities;
using Services;

namespace UnitOfWorkSample01
{
    /// <summary>
    /// データベースアクセスのサンプル
    /// 
    /// RepositoryパターンでのPersistent Frameworkの隠蔽
    /// Unit of workパターンでのトランザクション管理
    /// ビジネスロジックはService層に分離
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IUserService _userService = new UserService();

            //ユーザーデータの取得
            var allUsers = _userService.GetAllData();

            //ユーザーデータの出力
            foreach(var user in allUsers)
            {
                Console.WriteLine($"UserId: {user.UserId}, UserName: {user.UserName}");
            }

            Console.Read();
        }
    }
}
