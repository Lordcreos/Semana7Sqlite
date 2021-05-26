﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;  // importamos  la libreria
using Semana7Sqlite.Droid;
using Java.Nio.FileNio;

[assembly: Xamarin.Forms.Dependency(typeof(SqliteClient))] // implementmos el aseembly
 

namespace Semana7Sqlite.Droid
{
    public class SqliteClient : DataBase {  // implemento getconection

        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            //se crea la base de datos 
            var path = Path.Combine(documentsPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);

        }
    }
}