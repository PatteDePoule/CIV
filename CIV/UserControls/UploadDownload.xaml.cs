﻿using System;
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

namespace CIV
{
    /// <summary>
    /// Interaction logic for UploadDownload.xaml
    /// </summary>
    public partial class UploadDownload : UserControl
    {
        public UploadDownload()
        {
            InitializeComponent();
        }

        private void InitializeColor(ProgressBar control, System.Windows.Media.Brush background)
        {
            Grid grid = control.Template.FindName("Grid", control) as Grid;

            if (grid != null)
            {
                System.Windows.Controls.Border border = grid.FindName("PART_Indicator") as System.Windows.Controls.Border;
                if (border != null)
                {
                    border.Background = background;
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeColor(pbUpload,
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(ProgramSettings.Instance.UploadColor.Red,
                                                                                                        ProgramSettings.Instance.UploadColor.Green,
                                                                                                        ProgramSettings.Instance.UploadColor.Blue)));
            InitializeColor(pbDownload,
                            new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(ProgramSettings.Instance.DownloadColor.Red,
                                                                                                        ProgramSettings.Instance.DownloadColor.Green,
                                                                                                        ProgramSettings.Instance.DownloadColor.Blue)));
        }
    }
}
