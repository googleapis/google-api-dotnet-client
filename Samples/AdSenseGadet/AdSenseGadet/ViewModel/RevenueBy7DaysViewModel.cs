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
using System.Windows.Media;
using System.Windows;
namespace Com.Google.AdSense.Gadget.Ui.ViewModel
{
    public class RevenueBy7DaysViewModel
    {
        private static readonly List<Point> mockCurrentPoints = new List<Point>
        {
            new Point(5,15), new Point(15,80), new Point(25,34), new Point(35,76), new Point(45,52), new Point(44,45), new Point(65,12)
        };
        private static readonly List<Point> mockPreviousPoints = new List<Point>
        {
             new Point(5,52), new Point(15,10), new Point(25,80), new Point(35,50), new Point(45,12), new Point(55,40), new Point(65,50)
        };

        public PointCollection CurrentPoints { get; set; }
        public PointCollection PreviousPoints { get; set; }
        public String Name { get; set; }

        public RevenueBy7DaysViewModel()
        {
            CurrentPoints = new PointCollection(mockCurrentPoints);
            PreviousPoints = new PointCollection(mockPreviousPoints);
            Name = "FoundObject";
        }


    }
}
