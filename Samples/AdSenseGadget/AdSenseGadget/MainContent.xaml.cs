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
using System.IO;
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

using log4net;

using Com.Google.AdSense.Gadget.Ui.ViewModel;
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Samples.AdSenseApi;
using Google.Apis.Samples.AdSenseApi.Service;
using Google.Apis.Samples.AdSenseApi.Auth;

namespace Com.Google.AdSense.Gadget.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainContent : Grid
    {
        private static ILog logger = log4net.LogManager.GetLogger(typeof(MainContent));

        public MainContent()
        {
            logger.Debug("Starting");
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
                points.Add(new Point(7, 60.29));
                points.Add(new Point(6, 54.79));
                points.Add(new Point(5, 51.36));
                points.Add(new Point(4, 60.04));
                points.Add(new Point(3, 61.30));
                points.Add(new Point(2, 51.73));
                points.Add(new Point(1, 52.43));
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
                points.Add(new Point(1, 52.51));
                points.Add(new Point(2, 57.85));
                points.Add(new Point(3, 63.25));
                points.Add(new Point(4, 57.05));
                points.Add(new Point(5, 57.92));
                points.Add(new Point(6, 45.31));
                points.Add(new Point(7, 51.98));
                //for (double i = 1; i <= 7; i++)
                //{
                //    points.Add(new Point(10 - i, i + i));
                //}
                past7Days.ItemsSource = points;

                testChart.Series.Add(past7Days);
            }
        }

        private void loadLiveData(object sender, RoutedEventArgs e)
        {
            logger.Debug("Button Clicked");
            ExecuteReport();
        }
        
        private void ExecuteReport()
        {
            AdsensemgmtService adSense = CreateLiveService();

            RevenueReport rp = new RevenueReport(adSense);
            rp.StartDate = new DateTime(2000, 01, 01);
            rp.EndDate = new DateTime(2010, 12, 31);
            rp.PublicationId = "ca-pub-0556581589806023";
            IEnumerable<RevenueReport.ResultRow> results = rp.ExecuteReport();

            var past7Days = new LineSeries();
            past7Days.Name = "past7Days";
            past7Days.Title = "7 Days before";
            past7Days.DependentValuePath = "Y";
            past7Days.IndependentValuePath = "X";
            PointCollection pastPoints = new PointCollection(10);

            var recent7Days = new LineSeries();
            recent7Days.Name = "recent7Days";
            recent7Days.Title = "Recent 7 Days";
            recent7Days.DependentValuePath = "Y";
            recent7Days.IndependentValuePath = "X";
            PointCollection recentPoints = new PointCollection(10);

            testChart.Series.Clear();
            int index = 0;
            foreach (RevenueReport.ResultRow rr in results.OrderBy(x => x.Date))
            {
                index++;
                logger.Debug(rr.ToString());

               
                if (index == 1)
                {
                    continue;
                }
                if (index <= 8)
                {
                    recentPoints.Add(new Point(index -1, Math.Round(rr.EstimatedRevenue, 2)));
                    continue;
                }
                if (index <= 15)
                {
                    pastPoints.Add(new Point(index - 8, Math.Round(rr.EstimatedRevenue, 2)));
                    continue;
                }

                break;
            }
            recent7Days.ItemsSource = recentPoints;
            past7Days.ItemsSource = pastPoints;

            testChart.Series.Add(recent7Days);
            testChart.Series.Add(past7Days);
        }

        private static AdsensemgmtService CreateLiveService()
        {
            string username = Properties.Settings.Default.userName;
            string password = Properties.Settings.Default.password;

            var passwordSupplier = new PrefetchedUserNamePasswordSupplier(username, password);
            AuthenticatorFactory.GetInstance().RegisterAuthenticator(
                () => new ClientAuth(passwordSupplier, "adsense", "adsense"));

            var version = "v1beta1";
            string cacheDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GoogleApis.Tools.CodeGenCache");
            logger.Debug("Cache Directory was:" + cacheDirectory);
            if (Directory.Exists(cacheDirectory) == false)
            {
                Directory.CreateDirectory(cacheDirectory);
            }
            var webfetcher = new CachedWebDiscoveryDevice(
                                new Uri("http://elephant.lon:9996/discovery/v0.2beta1/describe/adsense-mgmt/v1beta1"),
                                new DirectoryInfo(cacheDirectory));
            var discovery = new DiscoveryService(webfetcher);
            // Build the service based on discovery information.
            var param = new ServiceFactory.FactoryV_0_2Parameter("http://elephant.lon:9996", null);
            var service = discovery.GetService(version, DiscoveryVersion.Version_0_2, param);

            return new AdsensemgmtService(service, AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator());
        }

       
    }
}
