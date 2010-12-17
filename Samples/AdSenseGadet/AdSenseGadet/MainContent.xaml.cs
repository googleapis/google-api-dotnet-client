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
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.DataVisualization.Charting;


using Com.Google.AdSense.Gadget.Ui.ViewModel;

namespace Com.Google.AdSense.Gadget.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainContent : Grid
    {
        public MainContent()
        {
            InitializeComponent();
            DataContext = new RevenueBy7DaysViewModel();
            //Chart testChart = new Chart();
            {
                var recent7Days = new LineSeries();
                recent7Days.Name = "recent7Days";
                recent7Days.Title = "Recent 7 Days";
                recent7Days.DependentValuePath = "Y";
                recent7Days.IndependentValuePath = "X";
                PointCollection points = new PointCollection(10);
                points.Add(new Point(7, 55.95));
                points.Add(new Point(6, 45.95));
                points.Add(new Point(5, 35.95));
                points.Add(new Point(4, 65.95));
                points.Add(new Point(3, 85.95));
                points.Add(new Point(2, 75.95));
                points.Add(new Point(1, 55.95));
                //for (double i = 1; i <= 7; i++)
                //{
                //    points.Add(new Point(i, i + i));
                //}
                recent7Days.ItemsSource = points;

                testChart.Series.Add(recent7Days);
            }

            {
                var past7Days = new LineSeries();
                past7Days.Name = "past7Days";
                past7Days.Title = "7 Days before";
                past7Days.DependentValuePath = "Y";
                past7Days.IndependentValuePath = "X";
                PointCollection points = new PointCollection(10);
                points.Add(new Point(1, 55.95));
                points.Add(new Point(2, 45.95));
                points.Add(new Point(3, 35.95));
                points.Add(new Point(4, 65.95));
                points.Add(new Point(5, 85.95));
                points.Add(new Point(6, 75.95));
                points.Add(new Point(7, 55.95));
                //for (double i = 1; i <= 7; i++)
                //{
                //    points.Add(new Point(10 - i, i + i));
                //}
                past7Days.ItemsSource = points;

                testChart.Series.Add(past7Days);
            }
        }
    }
}
