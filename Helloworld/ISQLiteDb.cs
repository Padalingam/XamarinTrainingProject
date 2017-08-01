using System;
using SQLite;
namespace Helloworld
{
	public interface ISQLiteDb
	{
		SQLiteAsyncConnection GetConnection();
	}
}
