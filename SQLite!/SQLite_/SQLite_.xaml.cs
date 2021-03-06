﻿using System;
using Xamarin.Forms;

namespace SQLite_
{
    public partial class SQLite_ : ContentPage
    {
        /*
        public SQLite_()
        {
            InitializeComponent();
            　
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加
            UserModel.insertUser("鈴木");
            UserModel.insertUser("田中");
            UserModel.insertUser("斎藤");
            //↑この辺をボタンに突っ込む

            //Userテーブルの行データを取得
            var query = UserModel.selectUser();

            foreach (var user in query)
            {
                //Userテーブルの名前列をLabelに書き出します
                layout.Children.Add(new Label { Text = user.Name });
            }

            Content = layout;

        }*/
        public SQLite_()
        {
            InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            /*
            //Userテーブルに適当なデータを追加する
            UserModel.insertUser("鈴木");
            UserModel.insertUser("田中");
            UserModel.insertUser("斎藤");*/

            //-------------------------------insertします-------------------------------
            var Insert = new Button
            {
                WidthRequest = 60,
                Text = "Insert!",
                TextColor = Color.Red,
            };
            layout.Children.Add(Insert);
            Insert.Clicked += InsertClicked;

            //--------------------------------deleteします------------------------------
            var Delete = new Button
            {
                WidthRequest = 60,
                Text = "Delete!",
                TextColor = Color.Red,
            };

            layout.Children.Add(Delete);
            Delete.Clicked += DeleteClicked;

            //--------------------------------selectします------------------------------
            var Select = new Button
            {
                WidthRequest = 60,
                Text = "Select!",
                TextColor = Color.Red,
            };
            layout.Children.Add(Select);
            Select.Clicked += SelectClicked;

            Content = layout;
        }

        void SelectClicked(object sender, EventArgs e)
        {
            //Userテーブルの行データを取得
            var query = UserModel.selectUser(); //中身はSELECT * FROM [User]
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };
            foreach (var user in query)
            {
                //Userテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = user.Name });
            }
            Content = layout;
        }

        void InsertClicked(object sender, EventArgs e)
        {
            //Userテーブルに適当なデータを追加する
            UserModel.insertUser("鈴木");
            UserModel.insertUser("田中");
            UserModel.insertUser("斎藤");

        }

        void DeleteClicked(object sender, EventArgs e)
        {

            UserModel.deleteUser("鈴木");

        }
    }
}
