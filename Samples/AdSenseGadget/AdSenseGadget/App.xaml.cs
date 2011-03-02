/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Com.Google.AdSense.Gadget.Ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new Window();
            MainWindow.Background = System.Windows.Media.Brushes.Transparent;
            MainWindow.AllowsTransparency = true;
            MainWindow.WindowStyle = WindowStyle.None;
            MainWindow.Content = new MainContent();
            MainWindow.SizeToContent = SizeToContent.WidthAndHeight;
            MainWindow.MouseLeftButtonDown += delegate
            {
                MainWindow.DragMove();
            };
            MainWindow.ShowDialog();
        }
    }
}
